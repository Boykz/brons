using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BRONKZ.HLPClasess
{
    
    public class SqlClass
    {
        ArrayList paramsList;
        public string conct;
        public SqlClass(string connect)
        {
            this.conct = connect;
            paramsList = new ArrayList();
        }
        public SqlDataReader select(string request)
        {
            SqlDataReader reader;
            reader = null;
            SqlConnection connection = new SqlConnection(ShareClass.BRONCONNECTION);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = request;
           try
            {
                connection.Open();
                 //new SqlCommand(request,connection);
                FillWithParams(command, paramsList);
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        
           return reader;
            
           
        }

        public int execute(string request)
        {
            int rec = -1;
            SqlConnection connection = new SqlConnection(ShareClass.BRONCONNECTION);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = request;
            try
            {
                connection.Open();
                 
                FillWithParams(command, paramsList);
                rec = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
                command.Dispose();
              //  SqlConnection.ClearPool(connection);
                connection.Dispose();
            }
            return rec;
        }


        public void paramClear()
        {
            paramsList.Clear();
        }
        public void FillWithParams(SqlCommand command, ArrayList parametrs)
        {
            if(parametrs != null)
            foreach(DefaultParametr pr in parametrs)
            {
                if(pr.value == null)   command.Parameters.Add(pr.name,pr.type,pr.size).Value = DBNull.Value;
                else command.Parameters.Add(pr.name, pr.type, pr.size).Value = pr.value;
            }
        }

        public class DefaultParametr
        {
           public  String name;
           public int size;
           public object value;
           public SqlDbType type;
            public DefaultParametr(String Name, SqlDbType DbType, int Size, object Value)
            {
                this.name = Name;
                this.type = DbType;
                this.size = Size;
                this.value = Value;
            }
        }
        public void AddSqlParametr(string Name, SqlDbType DbType, int Size, object Value)
        {             
            paramsList.Add(new DefaultParametr(Name, DbType, Size, Value));
        }
    }
}
