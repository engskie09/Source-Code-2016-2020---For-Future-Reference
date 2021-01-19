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
    public partial class CustomerSession3_View_Rooms_ : Form
    {
        public CustomerSession3_View_Rooms_()
        {
            InitializeComponent();
        }      
   
        private void CustomerSession3_View_Rooms__Load(object sender, EventArgs e)
        {
            pnlShowRoomByButtons.Location = new Point(24, 50);
            pnlShowRoomByGrid.Location = new Point(24, 50);

            pnlShowRoomByButtons.Parent = panelGridviewOrListview;
            pnlShowRoomByGrid.Parent = panelGridviewOrListview;

            pnlShowRoomByButtons.Visible = true;
            pnlShowRoomByGrid.Visible = false;
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

                currentRow ++;
                
            }
        }

       
        private void btnShowGridviewOrListview_Click(object sender, EventArgs e)
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

        private void btnShowRoom_Click(object sender, EventArgs e)
        {
            Control ctrlCurrentButton = (Control)sender;
            String getRoomNo = ctrlCurrentButton.Text.Trim();
            getRoomNo = getRoomNo.Remove(0,4);
            CustomerSession3_View_Rooms__DialogShowRoomInformation.getRoomNo = Convert.ToInt32(getRoomNo); 
           
            
            CustomerSession3_View_Rooms__DialogShowRoomInformation navigate = new CustomerSession3_View_Rooms__DialogShowRoomInformation();
            navigate.ShowDialog();
            
        }

        private void cmboxGetFloorno_SelectedIndexChanged(object sender, EventArgs e)
        {
            SystemMethodsGeneral.setDGVRoomlist(cmboxGetFloorno.Text.Trim());
  
            setDGVRoomlist();   
            
        }

        private void btnExitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
