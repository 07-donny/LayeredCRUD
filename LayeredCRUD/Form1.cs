using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LayeredCRUD
{
    public partial class Form1 : Form
    {
        ShipDb db = new ShipDb();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.GetAll();
        }

        private void BTNRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Ship s = (Ship)dataGridView1.SelectedRows[0].DataBoundItem;
                db.Delete(s.Id);
            }

            dataGridView1.DataSource = db.GetAll();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void BTNEdit_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.TXTId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f.TXTManufacturer.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f.TXTLine.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f.TXTModel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f.TXTClass.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f.ShowDialog();
        }

        private void FilterBox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.GetAll();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.GetAll();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
