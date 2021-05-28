using Common.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL.BLL
{
    public class PositionBLL 
    {
        private static string connectString = ConfigurationSettings.AppSettings["Default"];

        public static void Save(PositionEntity entity)
        {
            using (SqlConnection _connection = new SqlConnection(connectString))
            {
                using (SqlCommand _cmd = new SqlCommand("PositionInsert", _connection))
                {
                    _cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    
                    _cmd.Parameters.Add("@PositionName", SqlDbType.VarChar).Value = entity.PositionName;
                    _cmd.Parameters.Add("@Rate", SqlDbType.Float).Value = entity.Rate;
                    
                    _connection.Open();
                    _cmd.ExecuteNonQuery();
                    _connection.Close();

                }
            }
        }
    }
}
