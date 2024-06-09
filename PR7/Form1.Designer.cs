namespace PR7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            tsSeparator1 = new ToolStripSeparator();
            btnDel = new ToolStripButton();
            btnClear = new ToolStripButton();
            tsSeparator2 = new ToolStripSeparator();
            btnExit = new ToolStripButton();
            gvRivers = new DataGridView();
            bindSrcRiver = new BindingSource(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvRivers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindSrcRiver).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, tsSeparator1, btnDel, btnClear, tsSeparator2, btnExit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(23, 22);
            btnAdd.Text = "Додати запис про місто";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(23, 22);
            btnEdit.Text = "Редагувати запис";
            btnEdit.Click += btnEdit_Click;
            // 
            // tsSeparator1
            // 
            tsSeparator1.Name = "tsSeparator1";
            tsSeparator1.Size = new Size(6, 25);
            // 
            // btnDel
            // 
            btnDel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDel.Image = (Image)resources.GetObject("btnDel.Image");
            btnDel.ImageTransparentColor = Color.Magenta;
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(23, 22);
            btnDel.Text = "Видалити запис";
            btnDel.Click += btnDel_Click;
            // 
            // btnClear
            // 
            btnClear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.ImageTransparentColor = Color.Magenta;
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(23, 22);
            btnClear.Text = "Очистити дані";
            btnClear.Click += btnClear_Click;
            // 
            // tsSeparator2
            // 
            tsSeparator2.Name = "tsSeparator2";
            tsSeparator2.Size = new Size(6, 25);
            // 
            // btnExit
            // 
            btnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(23, 22);
            btnExit.Text = "Вийти з програми";
            btnExit.Click += btnExit_Click;
            // 
            // gvRivers
            // 
            gvRivers.AllowUserToAddRows = false;
            gvRivers.AllowUserToDeleteRows = false;
            gvRivers.AutoGenerateColumns = false;
            gvRivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvRivers.DataSource = bindSrcRiver;
            gvRivers.Dock = DockStyle.Fill;
            gvRivers.Location = new Point(0, 25);
            gvRivers.Name = "gvRivers";
            gvRivers.ReadOnly = true;
            gvRivers.RowTemplate.Height = 25;
            gvRivers.Size = new Size(800, 425);
            gvRivers.TabIndex = 1;
            // 
            // bindSrcRiver
            // 
            bindSrcRiver.DataSource = typeof(BindingSource);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gvRivers);
            Controls.Add(toolStrip1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Практична робота №7";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvRivers).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindSrcRiver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnAdd;
        private ToolStripButton btnEdit;
        private ToolStripSeparator tsSeparator1;
        private ToolStripButton btnDel;
        private ToolStripButton btnClear;
        private ToolStripSeparator tsSeparator2;
        private ToolStripButton btnExit;
        private DataGridView gvRivers;
        private BindingSource bindSrcRiver;
    }
}