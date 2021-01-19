using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenKiosk
{
    public partial class OrderingCart : Form
    {
        bool edit = true;
        public OrderingCart()
        {
            InitializeComponent();
        }

        private void OrderingCart_Load(object sender, EventArgs e)
        {
            CrazyKart.DataSource = Ordering.OrderTable;
            getTotal();

            CrazyKart.BorderStyle = BorderStyle.None;
            CrazyKart.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            CrazyKart.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CrazyKart.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            CrazyKart.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
           CrazyKart.BackgroundColor = Color.White;
          
            CrazyKart.EnableHeadersVisualStyles = false;
            CrazyKart.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            CrazyKart.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            CrazyKart.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void MinusQuantity_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(QuantityToBuy.Text.ToString());

            if (a > 0)
            {
                a--;
                QuantityToBuy.Text = a.ToString();
            }
        }

        private void PlusQuantity_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(QuantityToBuy.Text.ToString());

            if (a >= 0)
            {
                a++;
                QuantityToBuy.Text = a.ToString();
            }
        }

        int selectedRow = 0;

        private void CrazyKart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                DataGridViewRow SelectFromKart = CrazyKart.Rows[e.RowIndex];

                selectedFood.Text = SelectFromKart.Cells[0].Value.ToString();
                QuantityToBuy.Text = SelectFromKart.Cells[1].Value.ToString();
                selectedPrice.Text = SelectFromKart.Cells[2].Value.ToString();
            }
            catch { }
        }

        private void btnUpdateKart_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow UpdateKart = CrazyKart.Rows[selectedRow];
                int a = Convert.ToInt32(QuantityToBuy.Text);
                int b = Convert.ToInt32(selectedPrice.Text);
                int total = a * b;

                UpdateKart.Cells[1].Value = QuantityToBuy.Text;
                UpdateKart.Cells[3].Value = total.ToString();

                selectedFood.Text = "-----";
                selectedPrice.Text = "-----";
                QuantityToBuy.Text = "1";
                getTotal();

                
               
               

              
            }
            catch (Exception)
            {
                DialogNull a = new DialogNull();
                a.ShowDialog();
                //MessageBox.Show("The Value is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantityToBuy.Text = "1";

            }

        }

        private void btnRemoveFromKart_Click(object sender, EventArgs e)
        {



            try
            {
            
                DataRow row = Ordering.OrderTable.Rows[selectedRow];
            
                Ordering.OrderTable.Rows.Remove(row);
                selectedFood.Text = "-----";
                selectedPrice.Text = "-----";
                QuantityToBuy.Text = "1";
                getTotal();

                
               
             
             
            
            
            }

            catch (Exception)
            {
                DialogNull a = new DialogNull();
                a.ShowDialog();

                //MessageBox.Show("The Value is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Ordering xD = new Ordering();
    
        }

        public void getTotal()
        {

            int a = CrazyKart.Rows.Count - 1;
            int takeTotal = 0;


            for (int x = 0; x <= a; x++)
            {
                int take = Convert.ToInt16(CrazyKart.Rows[x].Cells[3].FormattedValue.ToString());

                takeTotal = takeTotal + take;
                TotalAll.Text = takeTotal.ToString()+".00";

            }

            if (CrazyKart.Rows.Count == 0)
            {
                TotalAll.Text = "-----";
            }






        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            panel6.BackColor = Color.FromArgb(100, 26, 63, 122);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CrazyKart.CurrentRow == null) return;
                if (CrazyKart.CurrentRow.Index - 1 >= 0)
                {


                    CrazyKart.CurrentCell = CrazyKart.Rows[CrazyKart.CurrentRow.Index - 1].Cells[0];
                    CrazyKart.Rows[CrazyKart.CurrentCell.RowIndex].Selected = true;

                    selectedRow = CrazyKart.CurrentCell.RowIndex;
                    DataGridViewRow SelectFromKart = CrazyKart.Rows[CrazyKart.CurrentCell.RowIndex];

                    selectedFood.Text = SelectFromKart.Cells[0].Value.ToString();
                    QuantityToBuy.Text = SelectFromKart.Cells[1].Value.ToString();
                    selectedPrice.Text = SelectFromKart.Cells[2].Value.ToString();
                }
            }
            catch (Exception)
            {
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (CrazyKart.CurrentRow == null) return;
                if (CrazyKart.CurrentRow.Index + 1 >= 0)
                {

                    CrazyKart.CurrentCell = CrazyKart.Rows[CrazyKart.CurrentRow.Index + 1].Cells[0];
                    CrazyKart.Rows[CrazyKart.CurrentCell.RowIndex].Selected = true;

                    selectedRow = CrazyKart.CurrentCell.RowIndex;
                    DataGridViewRow SelectFromKart = CrazyKart.Rows[CrazyKart.CurrentCell.RowIndex];

                    selectedFood.Text = SelectFromKart.Cells[0].Value.ToString();
                    QuantityToBuy.Text = SelectFromKart.Cells[1].Value.ToString();
                    selectedPrice.Text = SelectFromKart.Cells[2].Value.ToString();

                }
            }
            catch(Exception){
            }
        }

        private void CrazyKart_SelectionChanged(object sender, EventArgs e)
        {

        }

        public static String getTotalForResibo = "";

        private void FinishNa_Click(object sender, EventArgs e)
        {


            
            try
            {

                Double totalInt = Convert.ToDouble(TotalAll.Text);

                MessageBox.Show(totalInt.ToString());

                Rectangle rec = new Rectangle(0, 0, FinishNa.Width, FinishNa.Height);
                System.Drawing.Drawing2D.GraphicsPath gpx = new System.Drawing.Drawing2D.GraphicsPath();
                int b = 50;
                gpx.AddArc(rec.X, rec.Y, b, b, 180, 90);
                gpx.AddArc(rec.X + rec.Width - b, rec.Y, b, b, 270, 90);
                gpx.AddArc(rec.X + rec.Width - b, rec.Y + rec.Height - b, b, b, 0, 90);
                gpx.AddArc(rec.X, rec.Y + rec.Height - b, b, b, 90, 90);
                FinishNa.Region = new Region(gpx);
               // Keyboard.cashtoPay = Convert.ToInt32(TotalAll.Text);
                DataGridViewRow Nullcart = CrazyKart.Rows[selectedRow];

                Keyboard.getTotaltoReduceBalancePotekXD = totalInt.ToString();


                Finalizee a = new Finalizee();
                getTotalForResibo = totalInt.ToString();
                a.ShowDialog();

            }
            catch (Exception)
            {
                DialogNull a = new DialogNull();
                a.Show();

                // MessageBox.Show("Invalid");
            }
         
        }

        private void mealName4_Click(object sender, EventArgs e)
        {

        }

        private void TotalAll_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 26, 63, 122);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                btnRemoveFromKart.Enabled = true;
                btnUpdateKart.Enabled = true;
                PlusQuantity.Enabled = true;
                MinusQuantity.Enabled = true;
                edit = false;

                QuantityToBuy.Text = "1";
            }
            else 
            {
                btnRemoveFromKart.Enabled = false;
                btnUpdateKart.Enabled = false;
                PlusQuantity.Enabled = false;
                MinusQuantity.Enabled = false;
                edit = true;

                QuantityToBuy.Text = "1";
            }
       

        }
    }
}


