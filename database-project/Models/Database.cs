using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace database_project.Models
{
    public class Database
    {
        private string connstring;
        public List<Course> courseobj;
        public IEnumerable<Course> DisplayData()
        {
            connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

            SqlConnection p_connection;
            p_connection = new SqlConnection(connstring);
            p_connection.Open();
            string sql_statement = "select id,name from Course";

            
            SqlCommand cmd = new SqlCommand(sql_statement, p_connection);
            SqlDataReader dbreader = cmd.ExecuteReader();

            courseobj = new List<Course>();
            while (dbreader.Read())
            {
                Course newobj = new Course();
                newobj.id = dbreader.GetInt32(0);
                newobj.name = dbreader.GetString(1);
                
                
                courseobj.Add(newobj);
            }
            return courseobj;
        }
        
    }
}