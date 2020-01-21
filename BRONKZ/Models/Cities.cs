using BRONKZ.HLPClasess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BRONKZ.Models
{
    public  class Cities
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public string Name { get; set; }
        public int Status { get; set; } = ShareClass.NORMAL_STATUS;



        public static List<Cities> GetCitiesList(SqlClass sql)
        {
            //sql.paramClear();
          //  sql.AddSqlParametr("@name", System.Data.SqlDbType.Int, 10, 5);
            string query = "select Id, Name from cities";
            List<Cities> cts;
            cts = new List<Cities>();
            SqlDataReader read = sql.select(query);
            while (read.Read()) {

                cts.Add(new Cities {
                    Name = (string)read["Name"],
                    Id = (int)read["Id"]
                });
            }
            return cts;
        }

        public static void setCity(SqlClass sql, string Name)
        {
            sql.paramClear();
            sql.AddSqlParametr("@name", System.Data.SqlDbType.NVarChar, 70, Name);
            string query = "insert into Cities(Name,CountryId,Status) values(@name,2,1)";
            
            int rec = sql.execute(query);            
            
        }
    }
}
