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

namespace SoftwenTP_MasalloCaneteBartolomeTeamXD
{
    public partial class GeneralSession3_Group_ : Form
    {
        public GeneralSession3_Group_()
        {
            InitializeComponent();
        }       

        private void GeneralSession3_Group__Load(object sender, EventArgs e)
        {
            PanelGrouplist.Location = new Point(34, 46);
            setDGV_Group();
        }

        //set Datagridview value Group.
        private void setDGV_Group()
        {
            systemMethods_GeneralSession.setDGV_group();

            dgvGroupList.AutoGenerateColumns = false;
            dgvGroupList.Columns[0].DataPropertyName = "Photo";
            dgvGroupList.Columns[1].DataPropertyName = "Group_Name";
            dgvGroupList.Columns[2].DataPropertyName = "Total_Group_Members";

            dgvGroupList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvGroupList.DataSource = systemMethods_GeneralSession.dt;
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            GeneralSession3_Group_Add_Group__ navigate = new GeneralSession3_Group_Add_Group__();
            navigate.ShowDialog();
            setDGV_Group();
            
        }

        private void dgvGroupList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 getCurrentRowIndex = e.RowIndex;

            if (getCurrentRowIndex >= 0)
            {
                DataGridViewRow dgvr = dgvGroupList.Rows[getCurrentRowIndex];
                GeneralSession3_Group_Update_Group__.getGroupnameAsPrimaryKey = dgvr.Cells[1].Value.ToString();

                GeneralSession3_Group_Update_Group__ navigate = new GeneralSession3_Group_Update_Group__();
                navigate.ShowDialog();
                setDGV_Group();           

            }
        }
    }
}
