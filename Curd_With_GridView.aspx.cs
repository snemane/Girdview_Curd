using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_With_Curd_Gridview
{
    public partial class Curd_With_GridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string stron = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(stron);
            string sql = "insert into selfinfo(name,email,phone)values('" + name.Text + "','" + email.Text + "','" + phone.Text + "');";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteReader();
        }
    }
}