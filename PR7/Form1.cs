using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace PR7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);

            gvRivers.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Назва";
            gvRivers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); column.DataPropertyName =
            "Depth"; column.Name = "Глибина";
            gvRivers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); column.DataPropertyName =
            "Length"; column.Name = "Довжина";
            gvRivers.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn(); column.DataPropertyName =
            "RiverSpeed"; column.Name = "Чи є швидкісною?";
            column.Width = 80; gvRivers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); column.DataPropertyName =
            "Speed"; column.Name = "Швидкість";
            gvRivers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); column.DataPropertyName =
            "Region"; column.Name = "Знаходиться в області";
            column.Width = 100; gvRivers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); column.DataPropertyName =
            "Pool"; column.Name = "Відноситься до басейну";
            column.Width = 100; gvRivers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); column.DataPropertyName =
            "Vityk"; column.Name = "Витікає з";
            column.Width = 80; gvRivers.Columns.Add(column);


            bindSrcRiver.Add(new Rivercls("Дніпро", 24353, 24354, true, 35464, "Дніпропетровська", "Чорного моря", "Бочарово"));
            EventArgs args = new EventArgs(); OnResize(args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Rivercls river = new Rivercls();
            Form2 ft = new Form2(river);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcRiver.Add(river);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Rivercls river = (Rivercls)bindSrcRiver.List[bindSrcRiver.Position];
            Form2 ft = new Form2(river);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcRiver.List[bindSrcRiver.Position] = river;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcRiver.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсi данi будуть втрачені", "Очищення даних", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcRiver.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити додаток?", "Вихiд з додатку", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}