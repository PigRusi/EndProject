using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class PurchasePlane : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string query = "SELECT Plane, Quantity FROM planes";
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
                                if (Convert.ToInt32(sdr["Quantity"].ToString()) > 0)
                                {
                                    ListItem item = new ListItem();
                                    item.Text = sdr["Plane"].ToString();
                                    PlaneList.Items.Add(item);
                                }
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

            conObj.Open();

            string cmdStr2 = $"SELECT * FROM planes WHERE Plane='{PlaneList.SelectedValue}'";
            OleDbCommand cmd2 = new OleDbCommand(cmdStr2, conObj);
            OleDbDataReader dr = cmd2.ExecuteReader();
            dr.Read();
            int quantity = Convert.ToInt32(dr["Quantity"].ToString()) - 1;
            int occupied = Convert.ToInt32(dr["Occupied"].ToString()) + 1;

            string cmdStr3 = $"UPDATE planes SET Quantity={quantity}, Occupied={occupied} WHERE Plane='{PlaneList.SelectedValue}'";
            OleDbCommand cmd3 = new OleDbCommand(cmdStr3, conObj);
            cmd3.ExecuteNonQuery();

            string cmdStr1 = $"INSERT INTO orders (MyId, Plane, DepDate, RetDate, MyDestenation) VALUES ('{Session["Login"]}', '{PlaneList.SelectedValue}', '{DepartureDate.Text}', '{RerturnDate.Text}', '{Destenation.Text}')";
            OleDbCommand cmd4 = new OleDbCommand(cmdStr1, conObj);
            cmd4.ExecuteNonQuery();

            conObj.Close();
        }
    }
}