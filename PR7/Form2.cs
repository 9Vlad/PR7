using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Xml.Linq;

namespace PR7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Rivercls TheRiver { get; set; }

        public Form2(Rivercls river) : this()
        {
            TheRiver = river;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TheRiver.Name = textBox1.Text.Trim();
            TheRiver.Depth = double.Parse(textBox2.Text.Trim());
            TheRiver.Length = double.Parse(textBox3.Text.Trim());
            TheRiver.Speed = int.Parse(textBox4.Text.Trim());
            TheRiver.Region = textBox5.Text.Trim();
            TheRiver.Pool = textBox6.Text.Trim();
            TheRiver.Vityk = textBox7.Text.Trim();
            TheRiver.RiverSpeed = cbRiverSpeed.Checked;
            DialogResult = DialogResult.OK;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
