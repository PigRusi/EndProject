using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            if (IsExist(Id1.Text, Pass.Text))
            {
                Session["Login"] = Id1.Text;
                Response.Write("Loged In");
            }
        }

        public bool IsExist(string Myid, string pass)
        {
            bool flag = false;

            string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source=" + Server.MapPath("") + "\\DataBase.accdb";
            string cmdStr = $"SELECT * FROM Pilots WHERE MyID='{Myid}' AND MyPassword='{pass}'";
            OleDbConnection conObj = new OleDbConnection(conStr);
            OleDbCommand cmdObj = new OleDbCommand(cmdStr, conObj);

            conObj.Open();
            OleDbDataReader dr = cmdObj.ExecuteReader();
            if (dr.HasRows)
                flag = true;
            conObj.Close();

            return flag;
        }
    }
}