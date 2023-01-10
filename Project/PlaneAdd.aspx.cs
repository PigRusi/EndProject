using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class PlaneAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string query = "SELECT Plane FROM planes";
                string constr = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source=" + Server.MapPath("") + "\\DataBase.accdb";
                using (OleDbConnection con = new OleDbConnection(constr))
                {
                    using (OleDbCommand cmd = new OleDbCommand(query))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        using (OleDbDataReader sdr = cmd.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                ListItem item = new ListItem();
                                item.Text = sdr["Plane"].ToString();
                                PlaneList.Items.Add(item);
                            }
                        }
                        con.Close();
                    }
                }
                PlaneList.Items.Insert(0, new ListItem("--Select Plane To Add--"));
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            OleDbConnection conObj = new OleDbConnection();
            conObj.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source=" + Server.MapPath("") + "\\DataBase.accdb";

            OleDbCommand cmdObj;
            int quantity;
                string cmdStr = "";
            if (PlaneList.SelectedIndex == 0)
            {
                quantity = int.Parse(Quantity.Text);
                cmdStr = $"INSERT INTO planes (Plane, Quantity) VALUES ('{NewPlane.Text}', '{quantity}')";
                conObj.Open();
                cmdObj = new OleDbCommand(cmdStr, conObj);
                cmdObj.ExecuteNonQuery();

                Response.Write("Succeed");
                conObj.Close();
            }

            else
            {
                cmdStr = $"SELECT Quantity FROM planes WHERE Plane='{PlaneList.SelectedValue}'";

                conObj.Open();
                cmdObj = new OleDbCommand(cmdStr, conObj);
                OleDbDataReader Dr = cmdObj.ExecuteReader();
                Dr.Read();
                int x = int.Parse(Dr["Quantity"].ToString());
                quantity = int.Parse(Quantity.Text);
                conObj.Close();


                cmdStr = $"UPDATE planes SET Quantity='{x + quantity}' WHERE Plane='{PlaneList.SelectedValue}'";
                conObj.Open();
                cmdObj = new OleDbCommand(cmdStr, conObj);
                cmdObj.ExecuteNonQuery();
                Response.Write("Succeed");
                conObj.Close();
            }
        }
    }
}