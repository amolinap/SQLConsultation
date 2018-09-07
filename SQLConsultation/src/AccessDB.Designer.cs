namespace SQLConsultation
{
    partial class AccessDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessDB));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cxPort = new System.Windows.Forms.CheckBox();
            this.nuPort = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.cxUser = new System.Windows.Forms.CheckBox();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDataBase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbInstance = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPort)).BeginInit();
            this.gbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cxPort);
            this.groupBox1.Controls.Add(this.nuPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbServer);
            this.groupBox1.Controls.Add(this.btLogin);
            this.groupBox1.Controls.Add(this.cxUser);
            this.groupBox1.Controls.Add(this.gbUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbDataBase);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbInstance);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(430, 305);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexión a BD";
            // 
            // cxPort
            // 
            this.cxPort.AutoSize = true;
            this.cxPort.Location = new System.Drawing.Point(20, 163);
            this.cxPort.Name = "cxPort";
            this.cxPort.Size = new System.Drawing.Size(79, 23);
            this.cxPort.TabIndex = 14;
            this.cxPort.Text = "Puerto";
            this.cxPort.UseVisualStyleBackColor = true;
            this.cxPort.CheckedChanged += new System.EventHandler(this.cxPort_CheckedChanged);
            // 
            // nuPort
            // 
            this.nuPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nuPort.Location = new System.Drawing.Point(149, 162);
            this.nuPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nuPort.Name = "nuPort";
            this.nuPort.Size = new System.Drawing.Size(110, 26);
            this.nuPort.TabIndex = 13;
            this.nuPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nuPort.Value = new decimal(new int[] {
            1433,
            0,
            0,
            0});
            this.nuPort.ValueChanged += new System.EventHandler(this.nuPort_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Instancia";
            // 
            // tbServer
            // 
            this.tbServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServer.Location = new System.Drawing.Point(149, 129);
            this.tbServer.Margin = new System.Windows.Forms.Padding(4);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(273, 26);
            this.tbServer.TabIndex = 11;
            this.tbServer.Text = "localhost";
            this.tbServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbServer.Leave += new System.EventHandler(this.tbServer_Leave);
            // 
            // btLogin
            // 
            this.btLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btLogin.Location = new System.Drawing.Point(322, 263);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(100, 28);
            this.btLogin.TabIndex = 10;
            this.btLogin.Text = "Aceptar";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // cxUser
            // 
            this.cxUser.AutoSize = true;
            this.cxUser.Location = new System.Drawing.Point(13, 26);
            this.cxUser.Margin = new System.Windows.Forms.Padding(4);
            this.cxUser.Name = "cxUser";
            this.cxUser.Size = new System.Drawing.Size(87, 23);
            this.cxUser.TabIndex = 9;
            this.cxUser.Text = "Usuario";
            this.cxUser.UseVisualStyleBackColor = true;
            this.cxUser.CheckedChanged += new System.EventHandler(this.cxUser_CheckedChanged);
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.tbUser);
            this.gbUser.Controls.Add(this.label3);
            this.gbUser.Controls.Add(this.tbPassword);
            this.gbUser.Controls.Add(this.label5);
            this.gbUser.Location = new System.Drawing.Point(8, 36);
            this.gbUser.Margin = new System.Windows.Forms.Padding(4);
            this.gbUser.Name = "gbUser";
            this.gbUser.Padding = new System.Windows.Forms.Padding(4);
            this.gbUser.Size = new System.Drawing.Size(364, 86);
            this.gbUser.TabIndex = 8;
            this.gbUser.TabStop = false;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(108, 15);
            this.tbUser.Margin = new System.Windows.Forms.Padding(4);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(241, 26);
            this.tbUser.TabIndex = 3;
            this.tbUser.Text = "sa";
            this.tbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(108, 49);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(241, 26);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Base de Datos";
            // 
            // cbDataBase
            // 
            this.cbDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDataBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBase.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDataBase.FormattingEnabled = true;
            this.cbDataBase.Location = new System.Drawing.Point(149, 229);
            this.cbDataBase.Margin = new System.Windows.Forms.Padding(4);
            this.cbDataBase.Name = "cbDataBase";
            this.cbDataBase.Size = new System.Drawing.Size(273, 26);
            this.cbDataBase.TabIndex = 5;
            this.cbDataBase.SelectedIndexChanged += new System.EventHandler(this.cbDataBase_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Servidor";
            // 
            // cbInstance
            // 
            this.cbInstance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbInstance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInstance.FormattingEnabled = true;
            this.cbInstance.Location = new System.Drawing.Point(149, 195);
            this.cbInstance.Margin = new System.Windows.Forms.Padding(4);
            this.cbInstance.Name = "cbInstance";
            this.cbInstance.Size = new System.Drawing.Size(273, 26);
            this.cbInstance.TabIndex = 3;
            this.cbInstance.SelectedIndexChanged += new System.EventHandler(this.cbInstance_SelectedIndexChanged);
            this.cbInstance.Leave += new System.EventHandler(this.cbInstance_Leave);
            // 
            // AccessDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 333);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccessDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso a BD";
            this.Load += new System.EventHandler(this.AccessDB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPort)).EndInit();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cxUser;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDataBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbInstance;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.CheckBox cxPort;
        private System.Windows.Forms.NumericUpDown nuPort;
    }
}