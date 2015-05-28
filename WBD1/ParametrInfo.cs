using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WBD1
{
    public class ParametrInfo
    {

        private string paramName;
        private System.Data.DbType paramType;
        private NpgsqlTypes.NpgsqlDbType npgsqlParamType;
        private object paramValue;
        private bool paramPuste2null;

        public ParametrInfo(string pName, NpgsqlTypes.NpgsqlDbType pType, object pValue)
        {
            this.paramName = pName;
            this.npgsqlParamType = pType;
            this.paramValue = pValue;
            this.paramPuste2null = false;
        }

        public ParametrInfo(string pName, System.Data.DbType pType, object pValue)
        {
            this.paramName = pName;
            this.paramType = pType;
            this.paramValue = pValue;
            this.paramPuste2null = false;
        }

        public ParametrInfo(string pName, System.Data.DbType pType, object pValue, bool pPuste2null)
        {
            this.paramName = pName;
            this.paramType = pType;
            this.paramValue = pValue;
            this.paramPuste2null = pPuste2null;
        }

        public bool ParamPuste2null
        {
            get
            {
                return paramPuste2null;
            }
        }

        public string ParamName
        {
            get
            {
                return paramName;
            }
        }
        public System.Data.DbType ParamType
        {
            get
            {
                return paramType;
            }
        }
        public object ParamValue
        {
            get
            {
                return paramValue;
            }
        }
        public NpgsqlTypes.NpgsqlDbType ParamTypeNpgsql
        {
            get
            {
                return npgsqlParamType;
            }
        }
    }
}
