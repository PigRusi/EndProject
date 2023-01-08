using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class DeleteUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DelBtn_Click(object sender, EventArgs e)
        {
            //try
            //{
                OleDbConnection conObj = new OleDbConnection();
                conObj.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source=" + Server.MapPath("") + "\\DataBase.accdb";

                string cmdStr = "";

                if (DropDownList1.SelectedIndex == 1)
                    cmdStr = String.Format("DELETE * FROM pilots WHERE MyID = '{0}'", InsertID.Text);
                else
                    cmdStr = String.Format("DELETE * FROM travelers WHERE MyID = '{0}'", InsertID.Text);


                conObj.Open();

                OleDbCommand cmdObj = new OleDbCommand(cmdStr, conObj);

                cmdObj.ExecuteNonQuery();
                Response.Write("Succeed");

                conObj.Close();
            //}
            //catch (Exception ex)
            //{
                //Response.Write(ex.Message);
            //}

        }
    }
}