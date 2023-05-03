namespace SuperZapatos.WF
{
    partial class frmAdminStore
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
            btnSave = new Button();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(399, 165);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 25;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(152, 87);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(322, 47);
            txtAddress.TabIndex = 20;
            // 
            // txtName
            // 
            txtName.Location = new Point(152, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 23);
            txtName.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 92);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 14;
            label2.Text = "Dirección";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 46);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 13;
            label1.Text = "Nombre:";
            // 
            // frmAdminStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 230);
            Controls.Add(btnSave);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdminStore";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAdminStore";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label2;
        private Label label1;
    }
}