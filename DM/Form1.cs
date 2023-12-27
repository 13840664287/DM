using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public static bool cellsRef = false;
        public static bool globalparsRef = false;
        public static bool layoutsRef = false;
        public static bool productlinesRef = false;
        public static bool ProductsRef = false;
        public static bool ScanareasRef = false;

        private void buttonScanareas_Click(object sender, EventArgs e)
        {
            Scanareas scanareas = new Scanareas();
            scanareas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productlines productlines = new Productlines();
            productlines.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Layouts layouts = new Layouts();
            layouts.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cells cells = new Cells();
            cells.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Globalpars globalpars = new Globalpars();
            globalpars.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            SQLite.CreateTable(SQLite.connectionString);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form_users fu = new Form_users();
            fu.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
