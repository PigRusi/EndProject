using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Select : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection Con1 = new OleDbConnection();
            Con1.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source=" + Server.MapPath("") + "\\DataBase.accdb";
            Con1.Open();
            string sqlstring = "";


            sqlstring = string.Format("SELECT * FROM {0}", WhatTable.SelectedValue);

            OleDbCommand cmd = new OleDbCommand(sqlstring, Con1);
            OleDbDataReader Dr = cmd.ExecuteReader();
            Dr.Read();

            int count = 0;

            Response.Write("<table border='1px'><tr align='center'><th>Name</th><th>ID</th><th>Gender</th><th>Nationality</th><th>Email</th><th>Phone Nun</th><th>Birth Day</th><th>Passport Num</th><th>Licence Num</th></tr>");
            if (Dr.HasRows)
            {
                do
                {
                    Response.Write("<td>" + Dr["MyFirstName"].ToString() +" " + Dr["MyLastName"].ToString() + "</td>");
                    Response.Write("<td>" + Dr["MyID"].ToString() + "</td>");
                    Response.Write("<td>" + Dr["MyGender"].ToString() + "</td>");
                    Response.Write("<td>" + Dr["MyNationality"].ToString() + "</td>");
                    Response.Write("<td>" + Dr["MyEmail"].ToString() + "</td>");
                    Response.Write("<td>" + Dr["MyPhoneNum"].ToString() + "</td>");
                    Response.Write("<td>" + Dr["MyBirthDay"].ToString() + "</td>");
                    Response.Write("<td>" + Dr["MyPassport"].ToString() + "</td>");
                    if (WhatTable.SelectedIndex == 0)
                    {
                        Response.Write("<td>" + Dr["MyLicence"].ToString() + "</td>");
                    }
                    else
                    {
                        Response.Write("<td></td>");
                    }
                    Response.Write("</tr>");
                    count++;
                }
                while (Dr.Read());

                Con1.Close();
                Response.Write("found " + count);
            }
            else
            {
                Con1.Close();
                Response.Write("NOT found");
            }
        }

    }
}