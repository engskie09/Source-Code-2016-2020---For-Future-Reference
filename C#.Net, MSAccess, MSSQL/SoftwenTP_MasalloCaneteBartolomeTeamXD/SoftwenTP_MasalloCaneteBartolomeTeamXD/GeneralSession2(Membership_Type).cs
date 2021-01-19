using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Reflection;
using System.IO;

namespace SoftwenTP_MasalloCaneteBartolomeTeamXD
{
    public partial class GeneralSession2_Membership_Type_ : Form
    {
        public GeneralSession2_Membership_Type_()
        {
            InitializeComponent();
        }        

        /*public  void DoubleBuffered( DataGridView dgv, bool setting)
        {
          Type dgvType = dgv.GetType();
              PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
             pi.SetValue(dgv, setting, null);
            
        }*/

        private void GeneralSession2_Membership_Type__Load(object sender, EventArgs e)
        {
            PanelMembershiplist.Location = new Point(34, 46);            
            setDGV_membershiptype();

            if (systemMethods_GeneralSession.setSessionName == "Admin")
            {
                btnAddMembership.Visible = true;
            }
            else if (systemMethods_GeneralSession.setSessionName == "Customer")
            {
                btnAddMembership.Visible = false;
            }
            
        }

        public static Byte[] getPhoto;
        public static String getMembership_Name;
        public static String getMembership_Period;
        public static String getInstallment_Plan;
        public static String getSignup_Fee;

        //set Datagridvew value Membership type.
        private void setDGV_membershiptype()
        {
            
            systemMethods_GeneralSession.setDGV_membershiptype();
            dgvMembershiptypeList.AutoGenerateColumns = false;
            dgvMembershiptypeList.Columns[0].DataPropertyName = "Photo";
            dgvMembershiptypeList.Columns[1].DataPropertyName = "Membership_Name";
            dgvMembershiptypeList.Columns[2].DataPropertyName = "Membership_Period";
            dgvMembershiptypeList.Columns[3].DataPropertyName = "Installment_Plan";
            dgvMembershiptypeList.Columns[4].DataPropertyName = "Signup_Fee";

            dgvMembershiptypeList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;     

            dgvMembershiptypeList.DataSource = systemMethods_GeneralSession.dt;

            
        } 

        private void btnAddMembership_Click(object sender, EventArgs e)
        {
            GeneralSession2_Membership_Type_Add_Membership__ showForm = new GeneralSession2_Membership_Type_Add_Membership__();
            showForm.ShowDialog();
            setDGV_membershiptype();            
        }

        

        private void dgvMembershiptypeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Int32 getCurrentRowIndex = e.RowIndex;

            if (getCurrentRowIndex >= 0) 
            {
            DataGridViewRow dgvr = dgvMembershiptypeList.Rows[getCurrentRowIndex];
            GeneralSession2_Membership_Type_Update_Membership__.getMembershipNameAsPrimaryKey = dgvr.Cells[1].Value.ToString();

            GeneralSession2_Membership_Type_Update_Membership__ navigate = new GeneralSession2_Membership_Type_Update_Membership__();
            navigate.ShowDialog();
            setDGV_membershiptype();

            }

        }      
      
        private void txtSearchdgv_TextChanged(object sender, EventArgs e)
        {
            /*f (systemMethods_GeneralSession.dt != null)
            {
                DataView dv = new DataView(systemMethods_GeneralSession.dt);
                dv.RowFilter = string.Format("Membership_Name LIKE '%{0}%'", txtSearchdgv.Text.Trim());
                dgvMembershiptypeList.DataSource = dv;

            }*/

            systemMethods_GeneralSession.search_membershiptype(txtSearchdgv.Text.Trim());
        }
    }
}
