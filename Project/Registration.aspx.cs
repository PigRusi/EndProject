using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit(object sender, EventArgs e)
        {

            try
            {
                OleDbConnection conObj = new OleDbConnection();
                conObj.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data source=" + Server.MapPath("") + "\\DataBase.accdb";

                string cmdStr = "";

                string gender = "";
                if (InsertMale.Checked)
                    gender = InsertMale.Text;
                if (InsertFemale.Checked)
                    gender = InsertFemale.Text;

                if (WhatTable.SelectedIndex == 1)
                    cmdStr = String.Format("INSERT INTO pilots (MyFirstName, MyLastName, MyID, MyLicence, MyGender, MyEmail, MyPhoneNum, MyPassword, MyBirthDay, MyPassport, MyNationality) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", InsertFName.Text, InsertLName.Text, InsertID.Text, InsertLicence.Text, gender, InsertEmail.Text, InsertPhone.Text, InsertPassword.Text, InsertBDay.Text, InsertPassport.Text, InserNationality.Text);
                else
                    cmdStr = String.Format("INSERT INTO travelers (MyFirstName, MyLastName, MyID, MyPassport, MyGender, MyEmail, MyPhoneNum, MyPassword, MyBirthDay, MyNationality) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", InsertFName.Text, InsertLName.Text, InsertID.Text, InsertPassport.Text, gender, InsertEmail.Text, InsertPhone.Text, InsertPassword.Text, InsertBDay.Text, InserNationality.Text);

                conObj.Open();
                OleDbCommand cmdObj = new OleDbCommand(cmdStr, conObj);
                cmdObj.ExecuteNonQuery();
                Response.Write("Succeed");
                conObj.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
    }
}