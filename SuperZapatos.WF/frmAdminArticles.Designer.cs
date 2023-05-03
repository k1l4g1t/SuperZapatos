namespace SuperZapatos.WF
{
    partial class frmAdminArticles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtTotalEstante = new TextBox();
            txtTotalBodega = new TextBox();
            cmbTienda = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 55);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 101);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 167);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 212);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 3;
            label4.Text = "Total en estante:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 262);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 4;
            label5.Text = "Total en bodega:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(109, 310);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 5;
            label6.Text = "Tienda:";
            // 
            // txtName
            // 
            txtName.Location = new Point(157, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 23);
            txtName.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(157, 96);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(322, 47);
            txtDescripcion.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(159, 164);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(194, 23);
            txtPrecio.TabIndex = 8;
            // 
            // txtTotalEstante
            // 
            txtTotalEstante.Location = new Point(160, 204);
            txtTotalEstante.Name = "txtTotalEstante";
            txtTotalEstante.Size = new Size(194, 23);
            txtTotalEstante.TabIndex = 9;
            // 
            // txtTotalBodega
            // 
            txtTotalBodega.Location = new Point(160, 254);
            txtTotalBodega.Name = "txtTotalBodega";
            txtTotalBodega.Size = new Size(194, 23);
            txtTotalBodega.TabIndex = 10;
            // 
            // cmbTienda
            // 
            cmbTienda.FormattingEnabled = true;
            cmbTienda.Location = new Point(160, 302);
            cmbTienda.Name = "cmbTienda";
            cmbTienda.Size = new Size(194, 23);
            cmbTienda.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(357, 388);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmAdminArticles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 450);
            Controls.Add(btnSave);
            Controls.Add(cmbTienda);
            Controls.Add(txtTotalBodega);
            Controls.Add(txtTotalEstante);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdminArticles";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Administración de articulos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private TextBox txtTotalEstante;
        private TextBox txtTotalBodega;
        private Button btnSave;
        public ComboBox cmbTienda;
    }
}