using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBD1
{

        public delegate void OnCommitRollback();
    public class TransactionManager
    {
        NpgsqlConnection m_Conn;
        NpgsqlTransaction m_Trn;
        NoticeEventHandler _noticeEventHandler;
        public event OnCommitRollback _OnCommit;
        public event OnCommitRollback _OnRollback;
        public TransactionManager()
        {
            m_Conn = null;
            m_Trn = null;
            NpgsqlConnection conn = new NpgsqlConnection("Server=89.65.47.175;Port=5432;" +
                            "User Id=adam;Password= szwagier1;Database=wbd;SSL=true;SslMode=Require;");
            m_Conn = conn;
            m_Conn.Open();
            m_Trn = m_Conn.BeginTransaction();

        }

        public NpgsqlConnection Conn
        {
            get
            {
                return m_Conn;
            }
        }
        public NpgsqlTransaction Trn
        {
            get
            {
                return m_Trn;
            }
        }

        public void CommitConnection()
        {
            try
            {
                if (m_Conn != null && m_Trn != null && m_Trn.Connection != null)
                {
                    m_Trn.Commit();
                    if (_OnCommit != null)
                        _OnCommit();
                    m_Conn.Close();
                    m_Conn.ClearPool();
                    m_Trn.Dispose();
                    m_Conn.Dispose();
                    m_Trn = null;
                }
                else
                {
                    if (m_Trn != null)
                        m_Trn.Dispose();
                    m_Trn = null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("lsadhaksfdasn");
                /*
                if (e is Npgsql.NpgsqlException && Query.NoticeSql.noticeSqlFormFoonsy != null)
                {
                   Query.NoticeSql.noticeSqlFormFoonsy(this, new NoticeSqlEventArgs((e as Npgsql.NpgsqlException).Errors[0] as NpgsqlError, (e as Npgsql.NpgsqlException).Message, true));
                }*/
            }
            finally
            {
                if (m_Conn != null)
                {
                    try
                    {
                        m_Conn.Close();
                        m_Conn.ClearPool();
                        if (m_Trn != null)
                            m_Trn.Dispose();
                        m_Conn.Dispose();
                    }
                    catch
                    {
                        Console.WriteLine("fasfdsadfas");
                    }
                }
            }
        }
        public void ZgloszonyWyjatek()
        {
            try
            {
                if (m_Trn != null)
                {
                    m_Trn.Rollback();
                    m_Trn.Dispose();
                    m_Trn = null;
                }
            }
            catch (InvalidOperationException io)
            {
                Console.WriteLine("Fsafsafasdasdsa");
                Console.WriteLine(io.StackTrace);
                m_Trn = null;
            }
            finally
            {
                if (m_Conn != null)
                {
                    m_Conn.Close();
                    m_Conn.ClearPool();
                    if (m_Trn != null)
                        m_Trn.Dispose();
                    m_Conn.Dispose();
                }
                else
                {
                    if (m_Trn != null)
                        m_Trn.Dispose();
                }
                m_Conn = null;
                if (_OnRollback != null)
                    _OnRollback();
            }

        }

        public bool SavePoint(string name)
        {
            if (m_Trn == null)
                return false;
            m_Trn.Save(name);
            return true;
        }

        public bool RollbackToSavePoint(string name)
        {
            if (m_Trn == null)
                return false;
            m_Trn.Rollback(name);
            return true;
        }

        public void SetNoticeEventHandler(NoticeEventHandler noticeEventHandler)
        {
            if (_noticeEventHandler == null)
            {
                _noticeEventHandler = noticeEventHandler;
                m_Conn.Notice += _noticeEventHandler;
            }
        }
    }
}
