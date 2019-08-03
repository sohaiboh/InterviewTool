using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InterviewTool.Code
{
    public class DB
    {


        public SqlDataReader ExecuteReader(string query)
        {

            var cn = new SqlConnection(ConfigurationManager.ConnectionStrings["InterviewToolContext"].ConnectionString);
            cn.Open();

            var cm = new SqlCommand(query, cn);

            return cm.ExecuteReader();
  
        }

    }
}