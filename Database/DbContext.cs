using System;
using Npgsql;

namespace Database
{
    public interface IDBContex {
        public int ExecuteInsertQuery(string sql);
    }
    public class DBContext:IDBContex
    {
        string _conexion;
        NpgsqlConnection _connection;
        public DBContext(string conexion) {
            _conexion = conexion;
        }
        private void SetConnection()
        {
            _connection = new NpgsqlConnection(_conexion);
        }
        public int ExecuteInsertQuery(string sql)
        {
            try
            {
                SetConnection();
                NpgsqlCommand command = new NpgsqlCommand(sql, _connection);
                if(_connection.State!= System.Data.ConnectionState.Open)
                    _connection.Open();
                int i = command.ExecuteNonQuery();
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                
            }
        }
    }
}
