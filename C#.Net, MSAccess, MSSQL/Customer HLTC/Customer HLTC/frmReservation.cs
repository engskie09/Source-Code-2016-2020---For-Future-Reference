using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Customer_HLTC
{
    public partial class frmReservation : Form
    {
        public frmReservation()
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
            frmMyAccount a = new frmMyAccount();
            a.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            a.Show();
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

        public void btn_Click(object sender, EventArgs e)
        {

            string objname = ((Button)sender).Name;

           

            if(objname == "btnHSAC")
            {

                frmReservation2 frm = new frmReservation2();
                frm.sendData(userid1, fname1, lname1, email1, objname);
                frm.Show();
                this.Hide();



            }

            else if (objname == "btnHSAI")
            {

                frmReservation2 frm = new frmReservation2();
                frm.sendData(userid1, fname1, lname1, email1, objname);
                frm.Show();
                this.Hide();

            }


            else if (objname == "btnFVR")
            {

                frmReservation2 frm = new frmReservation2();
                frm.sendData(userid1, fname1, lname1, email1, objname);
                frm.Show();
                this.Hide();



            }

            else if (objname == "btnDBF")
            {

                frmReservation2 frm = new frmReservation2();
                frm.sendData(userid1, fname1, lname1, email1, objname);
                frm.Show();
                this.Hide();

            }

            else if (objname == "btnDBH")
            {

                frmReservation2 frm = new frmReservation2();
                frm.sendData(userid1, fname1, lname1, email1, objname);
                frm.Show();
                this.Hide();



            }

                else if (objname == "btnFFHX")
                {

                    frmReservation2 frm = new frmReservation2();
                    frm.sendData(userid1, fname1, lname1, email1, objname);
                    frm.Show();
                    this.Hide();



                }

        }

    }
}
