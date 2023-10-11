using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace WebApplication1
{
    

    public partial class REGISTREATIONaspx : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=DESKTOP-QF1NUFG\\SQLEXPRESS01;Initial Catalog=UserRegistrationDB;Integrated Security=True";
            con.Open();
            if (!IsPostBack)
            {
                DataShow();
            }

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            dt = new DataTable();
            cmd.CommandText = "Insert into phonebook (Name,PhoneNum,Address)values('" + txtname.Text.ToString() + "','" + txtphonenum.Text.ToString() + "','" + txtaddress.Text.ToString() + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }
        public void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "Select * from phonebook";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update phonebook set  PhoneNum='"+txtphonenum.Text.ToString()+"',Address='"+txtaddress.Text.ToString()+"' where Name='"+txtname.Text.ToString()+"'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Delete from phonebook where Name='" + txtname.Text.ToString() + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();

        }
    }
}