using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormApp
{
    public partial class _Default : Page
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadInfo();
            }
        }

        protected void Insert(object sender, EventArgs e)
        {

            SqlConnection Conn = new SqlConnection(connectionString);

            string query = "Insert Into StudentTbl Values('"+ int.Parse(TextBox1.Text) + "','"+TextBox2.Text+"','"+DropDownList1.SelectedValue+"','"+Double.Parse(TextBox3.Text)+"', '"+TextBox4.Text+"')";
            Conn.Open();
            SqlCommand cmd = new SqlCommand(query,Conn);
            cmd.ExecuteNonQuery();
            Conn.Close();
            
                LoadInfo();
            
            
        }
        void LoadInfo()
        {
            SqlConnection Connn = new SqlConnection(connectionString);
            string Query = "select * from StudentTbl";
            SqlCommand cmd = new SqlCommand(Query,Connn);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource=dt;
            GridView1.DataBind();
        }

        protected void Delete(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(connectionString);
            Con.Open();
            string qry = "Delete from StudentTbl where St_Id ='" + int.Parse(TextBox1.Text) + "'";
            SqlCommand cmd = new SqlCommand(qry,Con);
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        protected void Update(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(connectionString);
            Con.Open();
            string qry = "Update StudentTbl Set  Name='" + TextBox2.Text + "', Address='" + DropDownList1.SelectedValue + "', Age= '" + Double.Parse(TextBox3.Text) + "', Contrac= '" + TextBox4.Text + "' where St_Id =  '" + int.Parse(TextBox1.Text) +"' ";
            SqlCommand cmd = new SqlCommand(qry,Con);
            cmd.ExecuteNonQuery();
            Con.Close();
        }
    }
}