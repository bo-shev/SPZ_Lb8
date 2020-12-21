using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lb8
{
    public partial class Form1 : Form
    {
        RegInfo inf = new RegInfo();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Виробник материнськоїплати", inf.boardManufacturer);
            dataGridView1.Rows.Add("Ревізія материнськоїплати", inf.boardVersion);
            dataGridView1.Rows.Add("Дата релізу BIOS", inf.BIOSreliseDate);
            dataGridView1.Rows.Add("Постачальник BIOS", inf.BIOSvendor);
            dataGridView1.Rows.Add("Версія BIOS", inf.BiosVersion);

            dataGridView1.Rows.Add("Ідентифікатор процесора", inf.identifier);
            dataGridView1.Rows.Add("Назва процесора", inf.cpuName);
            dataGridView1.Rows.Add("Виробник процесора", inf.cpuVendor);
            // MessageBox.Show(i.ToString());
            button1.Enabled = false;
        }
    }
}
