using BRONKZ.HLPClasess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BRONKZ.Models
{
    public class Districts
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public Cities City { get; set; }
        public string Name { get; set; }
        public int Status { get; set; } = ShareClass.NORMAL_STATUS;
        
        public static List<Districts> GetDistrictsListByCityID(SqlClass sql, int cityId)
        {
            sql.paramClear();
            sql.AddSqlParametr("@cityId", System.Data.SqlDbType.Int, 10, 5);
            string query = "select Id, Name from districts where cityId = @cityId";
            List<Districts> cts;
            cts = new List<Districts>();
            SqlDataReader read = sql.select(query);
            while (read.Read())
            {

                cts.Add(new Districts
                {
                    Name = (string)read["Name"],
                    Id = (int)read["Id"]                    
                });
            }
            return cts;
        }
    }
}
