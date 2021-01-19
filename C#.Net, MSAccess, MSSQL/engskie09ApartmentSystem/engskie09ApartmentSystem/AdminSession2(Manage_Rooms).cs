using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace engskie09ApartmentSystem
{
    public partial class AdminSession2_Manage_Rooms_ : Form
    {
        public AdminSession2_Manage_Rooms_()
        {
            InitializeComponent();
        }



        private void AdminSession2_Manage_Rooms__Load(object sender, EventArgs e)
        {
          

            panelGridviewOrListview.Location = new Point(18, 33);
            pnlShowRoomByButtons.Location = new Point(24, 50);
            pnlShowRoomByGrid.Location = new Point(24, 50);

            pnlShowRoomByButtons.Parent = panelGridviewOrListview;
            pnlShowRoomByGrid.Parent = panelGridviewOrListview;

            pnlShowRoomByButtons.Visible = true;
            pnlShowRoomByGrid.Visible = false;
            

         

        }

        Int32 RoomNoAsKey;

        //--------------------------------------------------
        //--------------------------------------------------
        //--------------------------------------------------
        //--------------------------------------------------
        //--------------------------------------------------

        private void setImageAvailability(String getRoomAvailability)
        {
            if (getRoomAvailability == "0" || getRoomAvailability == "Available")
            {
                MessageBox.Show("Available");
                pctbxgetAvailability.BackgroundImage = Properties.Resources.AvailableSign;
            }
            else if (getRoomAvailability == "1" || getRoomAvailability == "Not Available")
            {
                MessageBox.Show("Not Available");
                pctbxgetAvailability.BackgroundImage = Properties.Resources.NotAvailableSign;
            }
        }

        private void setRoomInformation()
        {

            if (SystemMethodsGeneral.setRoomNo == 0)
            {
                MessageBox.Show("This Room doesn`t exist!");                
                return;
            }

            txtsetRoomNo.Text = SystemMethodsGeneral.setRoomNo.ToString();
            RoomNoAsKey = Convert.ToInt32(SystemMethodsGeneral.setRoomNo.ToString());
            cmboxsetFloorNo.Text = SystemMethodsGeneral.setFloorNo;
            cmboxsetRoomType.Text = SystemMethodsGeneral.setRoomType;
            lblgetRoomAmount.Text = SystemMethodsGeneral.setRoomAmount.ToString();            


        }

        private void resetControlsValues()
        {
            txtsetRoomNo.Text = "";
            cmboxsetFloorNo.SelectedIndex = -1;
            cmboxsetRoomType.SelectedIndex = -1;
            lblgetRoomAmount.Text = "";
            cmboxGetFloorno.SelectedIndex = -1;
            pctbxgetAvailability.BackgroundImage = null;
        }

        private void btnSelectedRoom_Click(object sender, EventArgs e)
        {
            Control ctrlCurrentButton = (Control)sender;
            String getRoomNo = ctrlCurrentButton.Text.Trim();
            getRoomNo = getRoomNo.Remove(0, 4);

            SystemMethodsGeneral.getRoomInformation(Convert.ToInt32(getRoomNo));
            setRoomInformation();
            setImageAvailability(SystemMethodsGeneral.setRoomAvailability);

            dgvRoomlist.DataSource = null;

        }

        //getDatafordgvRoomlist
        public static DataTable getRoominfo = new DataTable();
        //getListofAvailability
        List<String> getRoomAvailability = new List<String>();

        private void setDGVRoomlist()
        {
            getRoominfo = SystemMethodsGeneral.dt;
            dgvRoomlist.DataSource = null;
            dgvRoomlist.AutoGenerateColumns = false;

            dgvRoomlist.Columns[0].DataPropertyName = "RoomNo";
            dgvRoomlist.Columns[1].DataPropertyName = "FloorNo";
            dgvRoomlist.Columns[2].DataPropertyName = "RoomType";
            dgvRoomlist.Columns[3].DataPropertyName = "RoomAmount";
            dgvRoomlist.DataSource = getRoominfo;

            getRoomAvailability = (from row in getRoominfo.AsEnumerable() select row["RoomAvailability"].ToString()).ToList();
            
            int currentRow = 0;

            foreach (String ZeroOrOne in getRoomAvailability)
            {


                if (ZeroOrOne == "0")
                {
                    //dgvRoomlist.Rows[currentRow].Cells[4].Value = Properties.Resources.AvailableSign;
                    dgvRoomlist.Rows[currentRow].Cells[4].Value = "Available";
                    dgvRoomlist.Rows[currentRow].Height = 20;
                }

                else if (ZeroOrOne == "1")
                {
                    //dgvRoomlist.Rows[currentRow].Cells[4].Value = Properties.Resources.NotAvailableSign;
                    dgvRoomlist.Rows[currentRow].Cells[4].Value = "Not Available";
                    dgvRoomlist.Rows[currentRow].Height = 20;
                }

                currentRow++;

            }
        }

        //--------------------------------------------------
        //--------------------------------------------------
        //--------------------------------------------------
        //--------------------------------------------------
        //--------------------------------------------------

        private void btnFloor1_Click(object sender, EventArgs e)
        {
            btnShowRoom1.Text = "Room 101";
            btnShowRoom2.Text = "Room 102";
            btnShowRoom3.Text = "Room 103";
            btnShowRoom4.Text = "Room 104";
            btnShowRoom5.Text = "Room 105";
            btnShowRoom6.Text = "Room 106";
            btnShowRoom7.Text = "Room 107";
        }

        private void btnFloor2_Click(object sender, EventArgs e)
        {
            btnShowRoom1.Text = "Room 201";
            btnShowRoom2.Text = "Room 202";
            btnShowRoom3.Text = "Room 203";
            btnShowRoom4.Text = "Room 204";
            btnShowRoom5.Text = "Room 205";
            btnShowRoom6.Text = "Room 206";
            btnShowRoom7.Text = "Room 207";
        }

        private void btnFloor3_Click(object sender, EventArgs e)
        {
            btnShowRoom1.Text = "Room 301";
            btnShowRoom2.Text = "Room 302";
            btnShowRoom3.Text = "Room 303";
            btnShowRoom4.Text = "Room 304";
            btnShowRoom5.Text = "Room 305";
            btnShowRoom6.Text = "Room 306";
            btnShowRoom7.Text = "Room 307";
        }

        private void btnFloor4_Click(object sender, EventArgs e)
        {
            btnShowRoom1.Text = "Room 401";
            btnShowRoom2.Text = "Room 402";
            btnShowRoom3.Text = "Room 403";
            btnShowRoom4.Text = "Room 404";
            btnShowRoom5.Text = "Room 405";
            btnShowRoom6.Text = "Room 406";
            btnShowRoom7.Text = "Room 407";
        }

        private void btnFloor5_Click(object sender, EventArgs e)
        {
            btnShowRoom1.Text = "Room 501";
            btnShowRoom2.Text = "Room 502";
            btnShowRoom3.Text = "Room 503";
            btnShowRoom4.Text = "Room 504";
            btnShowRoom5.Text = "Room 505";
            btnShowRoom6.Text = "Room 506";
            btnShowRoom7.Text = "Room 507";
        }

        private void btnFloor6_Click(object sender, EventArgs e)
        {
            btnShowRoom1.Text = "Room 601";
            btnShowRoom2.Text = "Room 602";
            btnShowRoom3.Text = "Room 603";
            btnShowRoom4.Text = "Room 604";
            btnShowRoom5.Text = "Room 605";
            btnShowRoom6.Text = "Room 606";
            btnShowRoom7.Text = "Room 607";
        }

        private void btnFloor7_Click(object sender, EventArgs e)
        {
            btnShowRoom1.Text = "Room 701";
            btnShowRoom2.Text = "Room 702";
            btnShowRoom3.Text = "Room 703";
            btnShowRoom4.Text = "Room 704";
            btnShowRoom5.Text = "Room 705";
            btnShowRoom6.Text = "Room 706";
            btnShowRoom7.Text = "Room 707";
        }

        

        private void btnExitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowListviewOrGridview_Click(object sender, EventArgs e)
        {
            if (pnlShowRoomByButtons.Visible)
            {
                pnlShowRoomByButtons.Visible = false;
                pnlShowRoomByGrid.Visible = true;

                
            }
            else if (pnlShowRoomByGrid.Visible)
            {
                pnlShowRoomByGrid.Visible = false;
                pnlShowRoomByButtons.Visible = true;
            }
        }     

     

        private void cmboxGetFloorno_SelectedIndexChanged(object sender, EventArgs e)
        {
            SystemMethodsGeneral.setDGVRoomlist(cmboxGetFloorno.Text.Trim());
            setDGVRoomlist();
        }

        private void dgvRoomlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow dgvRow = new DataGridViewRow();
            dgvRow = dgvRoomlist.Rows[e.RowIndex];

            
            try
            {
               

                txtsetRoomNo.Text = dgvRow.Cells[0].Value.ToString();
                RoomNoAsKey = Convert.ToInt32(dgvRow.Cells[0].Value.ToString());
                cmboxsetFloorNo.Text = dgvRow.Cells[1].Value.ToString();
                cmboxsetRoomType.Text = dgvRow.Cells[2].Value.ToString();
                lblgetRoomAmount.Text = dgvRow.Cells[3].Value.ToString();
                setImageAvailability(dgvRow.Cells[4].Value.ToString());
            }
            catch (Exception)
            { }



        }

        private void btnSetbuttonAction_Click(object sender, EventArgs e)
        {
            Control btncurrentControl = (Control)sender;

            resetControlsValues();
            
            if (btncurrentControl.Name == "btnAddRoom")
            {
                btngetAction.Visible = true;
                btngetAction.Text = "Add";

                txtsetRoomNo.Enabled = true;
                cmboxsetFloorNo.Enabled = true;
                cmboxsetRoomType.Enabled = true;

                txtsetRoomNo.BackColor = Color.FromArgb(224, 252, 149);
                cmboxsetFloorNo.BackColor = Color.FromArgb(224, 252, 149);
                cmboxsetRoomType.BackColor = Color.FromArgb(224, 252, 149);

                
            }

            if (btncurrentControl.Name == "btnUpdateRoom")
            {
                btngetAction.Visible = true;
                btngetAction.Text = "Update";

                txtsetRoomNo.Enabled = true;
                cmboxsetFloorNo.Enabled = true;
                cmboxsetRoomType.Enabled = true;

                txtsetRoomNo.BackColor = Color.FromArgb(224, 252, 149);
                cmboxsetFloorNo.BackColor = Color.FromArgb(224, 252, 149);
                cmboxsetRoomType.BackColor = Color.FromArgb(224, 252, 149);
            }

            if (btncurrentControl.Name == "btnDeleteRoom")
            {
                btngetAction.Visible = true;
                btngetAction.Text = "Delete";
            }
            
        }        

        private void btngetAction_Click(object sender, EventArgs e)
        {            

            if (btngetAction.Text == "Add")
            {
                SystemMethodsAdmin.addRoom(Convert.ToInt32(txtsetRoomNo.Text.Trim()), cmboxsetFloorNo.Text.Trim(), cmboxsetRoomType.Text.Trim(), Convert.ToInt32(lblgetRoomAmount.Text.Trim()), "0");

            }
            
            if (btngetAction.Text == "Update")
            {                
                SystemMethodsAdmin.updateRoom(Convert.ToInt32(txtsetRoomNo.Text.Trim()), cmboxsetFloorNo.Text.Trim(), cmboxsetRoomType.Text.Trim(), Convert.ToInt32(lblgetRoomAmount.Text.Trim()), "0", RoomNoAsKey);                
            }

            if (btngetAction.Text == "Delete")
            {
                SystemMethodsAdmin.deleteRoom(Convert.ToInt32(txtsetRoomNo.Text.Trim()));                
            }

            txtsetRoomNo.Enabled = false;
            cmboxsetFloorNo.Enabled = false;
            cmboxsetRoomType.Enabled = false;

            txtsetRoomNo.BackColor = Color.FromArgb(244, 255, 223);
            cmboxsetFloorNo.BackColor = Color.FromArgb(244, 255, 223);
            cmboxsetRoomType.BackColor = Color.FromArgb(244, 255, 223);

            btngetAction.Visible = false;

            resetControlsValues();

            

            
            
        }

        private void cmboxgetRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmboxsetRoomType.Text == "Small")
            {
                lblgetRoomAmount.Text = "3500";
            }

            if (cmboxsetRoomType.Text == "Medium")
            {
                lblgetRoomAmount.Text = "4500";
            }

            if (cmboxsetRoomType.Text == "Large")
            {
                lblgetRoomAmount.Text = "5500";
            }
        }
       

        private void txtBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {            
            SystemGeneralValidations.txtBoxNumber(sender, e);
        }
    }
}
