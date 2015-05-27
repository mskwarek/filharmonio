using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WBD1
{
    public static class Query
    {
        private static IDataReader reader;
        internal static string connStr = "jakis string";
        public static void nowaPoczta(NpgsqlConnection connection, string id, 
            string kod_pocztowy, string miejscowosc)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT wbd.ins_poczty("+
                id+", '"+kod_pocztowy+"', "+"'"+miejscowosc+"');");
        }
        public static void WykonajFunkcjeTrm(NpgsqlConnection psqlConnection, string nazwaFunkcji, TransactionManager trnMgr, params ParametrInfo[] p){
            try
            {
                //psqlConnection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(nazwaFunkcji, psqlConnection);
                cmd.Transaction = trnMgr.Trn;
               // cmd.CommandTimeout += command_timeout;
                cmd.CommandType = CommandType.StoredProcedure;


                foreach (ParametrInfo itemParam in p)
                {
                    Boolean typNpgsql = false;
                    NpgsqlParameter pIn;
                    int typ = (int)itemParam.ParamTypeNpgsql;
                    if (typ != 0)
                    {
                        pIn = new NpgsqlParameter(itemParam.ParamName, itemParam.ParamTypeNpgsql);
                        typNpgsql = true;
                    }
                    else
                    {
                        pIn = new NpgsqlParameter(itemParam.ParamName, itemParam.ParamType);
                    }

                    pIn.Value = itemParam.ParamValue;
                    cmd.Parameters.Add(pIn);
                    if (typNpgsql)
                    {
                        if (itemParam.ParamTypeNpgsql == NpgsqlTypes.NpgsqlDbType.Timestamp || itemParam.ParamTypeNpgsql == NpgsqlTypes.NpgsqlDbType.Date)
                        {
                            if (itemParam.ParamValue != null && itemParam.ParamValue != Convert.DBNull && Convert.ToDateTime(itemParam.ParamValue) == new DateTime(1, 1, 1))
                            {
                                cmd.Parameters[itemParam.ParamName].Value = Convert.DBNull;
                            }
                        }
                        else if (itemParam.ParamTypeNpgsql == NpgsqlDbType.Double)
                        {
                            if ((Convert.ToDouble(itemParam.ParamValue) == 0 || itemParam.ParamValue == null) && itemParam.ParamPuste2null)
                            {
                                cmd.Parameters[itemParam.ParamName].Value = Convert.DBNull;
                            }
                        }
                        else
                        {
                            if ((itemParam.ParamValue == null || itemParam.ParamValue.ToString().Trim() == "") && itemParam.ParamPuste2null)
                                cmd.Parameters[itemParam.ParamName].Value = Convert.DBNull;
                            else
                                cmd.Parameters[itemParam.ParamName].Value = itemParam.ParamValue;
                        }
                    }
                    else
                    {
                        if (itemParam.ParamType == DbType.DateTime || itemParam.ParamType == DbType.Date)
                        {
                            if (itemParam.ParamValue != null && itemParam.ParamValue != Convert.DBNull && Convert.ToDateTime(itemParam.ParamValue) == new DateTime(1, 1, 1))
                            {
                                cmd.Parameters[itemParam.ParamName].Value = Convert.DBNull;
                            }
                        }
                        else if (itemParam.ParamType == DbType.Double)
                        {
                            if ((Convert.ToDouble(itemParam.ParamValue) == 0 || itemParam.ParamValue == null) && itemParam.ParamPuste2null)
                            {
                                cmd.Parameters[itemParam.ParamName].Value = Convert.DBNull;
                            }
                        }
                        else
                        {
                            if ((itemParam.ParamValue == null || itemParam.ParamValue.ToString().Trim() == "") && itemParam.ParamPuste2null)
                                cmd.Parameters[itemParam.ParamName].Value = Convert.DBNull;
                            else
                                cmd.Parameters[itemParam.ParamName].Value = itemParam.ParamValue;
                        }
                    }
                }

                NpgsqlParameter pOut = new NpgsqlParameter("idPk", NpgsqlTypes.NpgsqlDbType.Integer);
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);

                NpgsqlParameter pOut2 = new NpgsqlParameter("result", NpgsqlTypes.NpgsqlDbType.Integer);
                pOut2.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut2);

                NpgsqlParameter pOut3 = new NpgsqlParameter("msg", NpgsqlTypes.NpgsqlDbType.Varchar);
                pOut3.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut3);

                NpgsqlParameter pOut4 = new NpgsqlParameter("info_dod_chv", NpgsqlTypes.NpgsqlDbType.Bytea);
                pOut4.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut4);

                reader = cmd.ExecuteReader();
                /*
                bInfo.IdLong = Convert.ToInt64(cmd.Parameters["idPk"].Value == Convert.DBNull ? -1 : cmd.Parameters["idPk"].Value);
                bInfo.Lp = Convert.ToInt32(cmd.Parameters["result"].Value);
                bInfo.Info_db = Convert.ToString(cmd.Parameters["msg"].Value);
                bInfo.Info_dod_chv = cmd.Parameters["info_dod_chv"].Value as string[];*/
            }
            catch (NpgsqlException ee)
            {
                if (ee.Message.Contains("timeout"))
                {
                    string message = "TIMEOUT: " + nazwaFunkcji + "(";
                    foreach (ParametrInfo itemParam in p)
                    {
                        if (message.Substring(message.Length - 1) != "(")
                            message += ",";
                        message += itemParam.ParamValue == null ? "null" : itemParam.ParamValue.ToString();
                    }
                    message += ")";
                    Console.WriteLine(message);
                }
                Console.WriteLine(ee.Message);
                /*
                bInfo.ErrorMessage = ee.Message;
                if (ee.Code != "57014" && !ee.Message.Contains("socket.gaierror") && !ee.Message.Contains("ssl.SSLError: The read operation timed out") && !ee.Message.Contains("canceling statement due to user request")) // nie informujemy o anulowaniu zapytania i o głupim gaierror oraz ssl timeout
                {
                    if (ee.Code == "23503")
                    {
                        bInfo.ErrorCode = Box_info.ReturnErrorCode.ErrorRowRelated;
                    }
                    else if (ee.Code == "23505")
                    {
                        bInfo.ErrorCode = Box_info.ReturnErrorCode.ErrorRowDuplicate;
                    }
                    else if (ee.Code == "P0001")
                    {
                        bInfo.ErrorCode = Box_info.ReturnErrorCode.ErrorDataRelated;
                    }
                    else
                    {
                        bInfo.ErrorCode = Box_info.ReturnErrorCode.Other;
                    }
                    bInfo.ErrorMessageDetail = ee.Message + "\n Where: " + ee.Where + "\n ErrorSql: " + ee.ErrorSql + "\n ErrorCode: " + ee.ErrorCode + "\n InnerException: " + ee.InnerException + "";
                    //bInfo.ErrorLine = ee.
                    //noticeSqlInfo.SetMessages(ee.Errors);*/
            }
                trnMgr.ZgloszonyWyjatek();

            
        }
    }

}
