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
    public partial class Form2 : Form
    {
        ShipDb db = new ShipDb();
        public Form2()
        {
            InitializeComponent();
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            Ship ship = new Ship();
            ship.Id = Convert.ToInt32(TXTId.Text);
            ship.Manufacturer = TXTManufacturer.Text;
            ship.Line = TXTLine.Text;
            ship.Model = TXTModel.Text;
            ship.Class = TXTClass.Text;

            db.Update(ship);

            Close();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            Ship ship = new Ship();
            ship.Manufacturer = TXTManufacturer.Text;
            ship.Line = TXTLine.Text;
            ship.Model = TXTModel.Text;
            ship.Class = TXTClass.Text;

            db.Add(ship);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
