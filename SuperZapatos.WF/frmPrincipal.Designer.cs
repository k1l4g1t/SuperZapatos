namespace SuperZapatos.WF
{
    partial class frmPrincipal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabArticles = new TabPage();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            btnRemoveArticle = new Button();
            btnEditArticle = new Button();
            btnNewArticle = new Button();
            gv_Articulos = new DataGridView();
            tabStores = new TabPage();
            splitContainer2 = new SplitContainer();
            groupBox2 = new GroupBox();
            btnRemoveStore = new Button();
            btnEditStore = new Button();
            btnAddStore = new Button();
            gv_Tiendas = new DataGridView();
            tabControl1.SuspendLayout();
            tabArticles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gv_Articulos).BeginInit();
            tabStores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gv_Tiendas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabArticles);
            tabControl1.Controls.Add(tabStores);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabArticles
            // 
            tabArticles.Controls.Add(splitContainer1);
            tabArticles.Location = new Point(4, 24);
            tabArticles.Name = "tabArticles";
            tabArticles.Padding = new Padding(3);
            tabArticles.Size = new Size(792, 422);
            tabArticles.TabIndex = 0;
            tabArticles.Text = "Articulos";
            tabArticles.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(gv_Articulos);
            splitContainer1.Size = new Size(786, 416);
            splitContainer1.SplitterDistance = 43;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRemoveArticle);
            groupBox1.Controls.Add(btnEditArticle);
            groupBox1.Controls.Add(btnNewArticle);
            groupBox1.Location = new Point(4, -2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 45);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones";
            // 
            // btnRemoveArticle
            // 
            btnRemoveArticle.Location = new Point(183, 19);
            btnRemoveArticle.Name = "btnRemoveArticle";
            btnRemoveArticle.Size = new Size(75, 23);
            btnRemoveArticle.TabIndex = 2;
            btnRemoveArticle.Text = "Eliminar";
            btnRemoveArticle.UseVisualStyleBackColor = true;
            btnRemoveArticle.Click += btnRemoveArticle_Click;
            // 
            // btnEditArticle
            // 
            btnEditArticle.Location = new Point(94, 19);
            btnEditArticle.Name = "btnEditArticle";
            btnEditArticle.Size = new Size(75, 23);
            btnEditArticle.TabIndex = 1;
            btnEditArticle.Text = "Editar";
            btnEditArticle.UseVisualStyleBackColor = true;
            btnEditArticle.Click += btnEditArticle_Click;
            // 
            // btnNewArticle
            // 
            btnNewArticle.Location = new Point(5, 19);
            btnNewArticle.Name = "btnNewArticle";
            btnNewArticle.Size = new Size(75, 23);
            btnNewArticle.TabIndex = 0;
            btnNewArticle.Text = "Registrar";
            btnNewArticle.UseVisualStyleBackColor = true;
            btnNewArticle.Click += btnAddArticle_Click;
            // 
            // gv_Articulos
            // 
            gv_Articulos.AllowUserToAddRows = false;
            gv_Articulos.AllowUserToDeleteRows = false;
            gv_Articulos.AllowUserToResizeColumns = false;
            gv_Articulos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            gv_Articulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gv_Articulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gv_Articulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_Articulos.Dock = DockStyle.Fill;
            gv_Articulos.Location = new Point(0, 0);
            gv_Articulos.MultiSelect = false;
            gv_Articulos.Name = "gv_Articulos";
            gv_Articulos.RowTemplate.Height = 25;
            gv_Articulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gv_Articulos.Size = new Size(786, 369);
            gv_Articulos.TabIndex = 1;
            // 
            // tabStores
            // 
            tabStores.Controls.Add(splitContainer2);
            tabStores.Location = new Point(4, 24);
            tabStores.Name = "tabStores";
            tabStores.Padding = new Padding(3);
            tabStores.Size = new Size(792, 422);
            tabStores.TabIndex = 1;
            tabStores.Text = "Tiendas";
            tabStores.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(gv_Tiendas);
            splitContainer2.Size = new Size(786, 416);
            splitContainer2.SplitterDistance = 46;
            splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRemoveStore);
            groupBox2.Controls.Add(btnEditStore);
            groupBox2.Controls.Add(btnAddStore);
            groupBox2.Location = new Point(2, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(438, 45);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acciones";
            // 
            // btnRemoveStore
            // 
            btnRemoveStore.Location = new Point(183, 19);
            btnRemoveStore.Name = "btnRemoveStore";
            btnRemoveStore.Size = new Size(75, 23);
            btnRemoveStore.TabIndex = 2;
            btnRemoveStore.Text = "Eliminar";
            btnRemoveStore.UseVisualStyleBackColor = true;
            btnRemoveStore.Click += btnRemoveStore_Click;
            // 
            // btnEditStore
            // 
            btnEditStore.Location = new Point(94, 19);
            btnEditStore.Name = "btnEditStore";
            btnEditStore.Size = new Size(75, 23);
            btnEditStore.TabIndex = 1;
            btnEditStore.Text = "Editar";
            btnEditStore.UseVisualStyleBackColor = true;
            btnEditStore.Click += btnEditStore_Click;
            // 
            // btnAddStore
            // 
            btnAddStore.Location = new Point(5, 19);
            btnAddStore.Name = "btnAddStore";
            btnAddStore.Size = new Size(75, 23);
            btnAddStore.TabIndex = 0;
            btnAddStore.Text = "Registrar";
            btnAddStore.UseVisualStyleBackColor = true;
            btnAddStore.Click += btnAddStore_Click;
            // 
            // gv_Tiendas
            // 
            gv_Tiendas.AllowUserToAddRows = false;
            gv_Tiendas.AllowUserToDeleteRows = false;
            gv_Tiendas.AllowUserToResizeColumns = false;
            gv_Tiendas.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            gv_Tiendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            gv_Tiendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gv_Tiendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_Tiendas.Dock = DockStyle.Fill;
            gv_Tiendas.Location = new Point(0, 0);
            gv_Tiendas.Name = "gv_Tiendas";
            gv_Tiendas.ReadOnly = true;
            gv_Tiendas.RowTemplate.Height = 25;
            gv_Tiendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gv_Tiendas.Size = new Size(786, 366);
            gv_Tiendas.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenido a Super Zapatos";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            tabControl1.ResumeLayout(false);
            tabArticles.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gv_Articulos).EndInit();
            tabStores.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gv_Tiendas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabArticles;
        private SplitContainer splitContainer1;
        private TabPage tabStores;
        private SplitContainer splitContainer2;
        private GroupBox groupBox1;
        private Button btnRemoveArticle;
        private Button btnEditArticle;
        private Button btnNewArticle;
        private DataGridView gv_Articulos;
        private GroupBox groupBox2;
        private Button btnRemoveStore;
        private Button btnEditStore;
        private Button btnAddStore;
        private DataGridView gv_Tiendas;
    }
}