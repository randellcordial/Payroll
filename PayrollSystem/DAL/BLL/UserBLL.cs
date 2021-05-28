using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Entity;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BLL.BLL
{
    public class UserBLL
    {
        private static string connectString = ConfigurationSettings.AppSettings["Default"];

        public static void Save(UserEntity entity)
        {
            using (SqlConnection _connection = new SqlConnection(connectString))
            {
                using (SqlCommand _cmd = new SqlCommand("UserInsert", _connection))
                {
                    _cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    if (entity.UserID == Guid.Empty)
                        entity.UserID = Guid.NewGuid();

                    _cmd.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = entity.UserID;
                    _cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = entity.FirstName;
                    _cmd.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = entity.MiddleName;
                    _cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = entity.LastName;
                    _cmd.Parameters.Add("@PositionID", SqlDbType.SmallInt).Value = entity.PositionType;

                    _connection.Open();
                    _cmd.ExecuteNonQuery();
                    _connection.Close();
                
                }
            }
        }
    }
}
