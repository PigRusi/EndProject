using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class ShowPilots : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OleDbConnection conObj = new OleDbConnection();
                conObj.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source=" + Server.MapPath("") + "\\DataBase.accdb";
                conObj.Open();
                string sqlstring = "SELECT * FROM pilots";
                OleDbCommand Cmd = new OleDbCommand(sqlstring, conObj);
                OleDbDataReader dr1 = Cmd.ExecuteReader();

                PilotsList.DataSource = dr1;
                PilotsList.DataBind();
                conObj.Close();
            }

        }

        protected void PilotsList_ItemCommand(object source, DataListCommandEventArgs e)
        {

        }
    }
}