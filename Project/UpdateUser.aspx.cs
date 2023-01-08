using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class UpdateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Update(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conObj = new OleDbConnection();
                conObj.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source=" + Server.MapPath("") + "\\DataBase.accdb";
                string cmdStr = String.Format("UPDATE {0} SET MyEmail='{3}', MyPhoneNum='{4}', MyPassword='{5}' WHERE MyID='{1}' AND MyPassword='{2}'", WhatTable.SelectedValue, InsertID.Text, InsertPass.Text, InsertEmail.Text, InsertPhone.Text, InsertNewPass.Text);

                conObj.Open();
                OleDbCommand cmdObj = new OleDbCommand(cmdStr, conObj);
                cmdObj.ExecuteNonQuery();
                Response.Write("User Updated!");
                conObj.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void CheckBtn_Click(object sender, EventArgs e)
        {
            OleDbConnection Con1 = new OleDbConnection();
            Con1.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source=" + Server.MapPath("") + "\\DataBase.accdb";
            Con1.Open();
            string sqlstring = "";


            sqlstring = string.Format("SELECT * FROM {0} WHERE MyID = '{1}' AND MyPassword = '{2}'", WhatTable.SelectedValue, InsertID.Text, InsertPass.Text);

            OleDbCommand cmd = new OleDbCommand(sqlstring, Con1);
            OleDbDataReader Dr = cmd.ExecuteReader();
            Dr.Read();

            if (Dr.HasRows)
            {
                do
                {
                    InsertEmail.Text = Dr["MyEmail"].ToString();
                    InsertPhone.Text = Dr["MyPhoneNum"].ToString();
                    InsertNewPass.Text = Dr["MyPassword"].ToString();
                } while (Dr.Read());

                Con1.Close();
            }
            else
            {
                Con1.Close();
                Response.Write("No such User");
            }
        }
    }
}