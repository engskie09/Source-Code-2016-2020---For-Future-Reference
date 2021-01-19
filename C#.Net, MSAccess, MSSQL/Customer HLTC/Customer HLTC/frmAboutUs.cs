﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_HLTC
{
    public partial class frmAboutUs : Form
    {
        public frmAboutUs()
        {
            InitializeComponent();
        }

        string userid1 = "";
        string fname1 = "";
        string lname1 = "";
        string email1 = "";

        public string connectionString = "Data Source=(LocalDB)\\HTLC;Initial Catalog=db_hltc;Integrated Security=True";

        public void sendData(string userid, string fname, string lname, string email)
        {

            userid1 = userid;
            fname1 = fname;
            lname1 = lname;
            email1 = email;


        }
        private void lnkMyAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMainMenu ff = new frmMainMenu();
            ff.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            ff.Show();
        }

        private void lnkReservation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReservation hh = new frmReservation();
            hh.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            hh.Show();
        }

        private void linkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAboutUs bb = new frmAboutUs();
            bb.sendData(userid1, fname1, lname1, email1);
            bb.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmContactUs bb = new frmContactUs();
            bb.sendData(userid1, fname1, lname1, email1);
            bb.Show();
            this.Hide();
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            if (userid1 != "")
            {
                linkLogin.Visible = false;
                lnkMyAccount.Visible = true;
                linkLogout.Visible = true;
            }
            else
            {
                linkLogin.Visible = true;
                lnkMyAccount.Visible = false;
            }
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin a = new frmLogin();
            a.Show();
            this.Hide();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin a = new frmLogin();
            a.Show();
            this.Hide();
        }

        private void lnkMyAccount_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMyAccount a = new frmMyAccount();
            a.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            a.Show();
        }
    }
}
