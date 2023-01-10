using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class ShowRes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string yourId = Request.QueryString["res"].ToString();

                OleDbConnection conObj = new OleDbConnection();
                conObj.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source=" + Server.MapPath("") + "\\DataBase.accdb";
                conObj.Open();

                string cmdString = $"SELECT * FROM orders WHERE MyId='{yourId}'";
                OleDbCommand cmdObj = new OleDbCommand(cmdString, conObj);
                OleDbDataReader Dr = cmdObj.ExecuteReader();

                ShowR.DataSource = Dr;
                ShowR.DataBind();
                conObj.Close();
            }
        }

        protected void ShowR_ItemCommand(object source, DataListCommandEventArgs e)
        {
        }

    }
}