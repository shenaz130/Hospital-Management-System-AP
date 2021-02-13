namespace HospitalMangementSystem
{
    partial class UpdatePatient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbl_pname = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lbl_age = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.lbl_PId = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.PictureBox();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.BackgroundImage = global::HospitalMangementSystem.Properties.Resources.patients;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_home);
            this.groupBox1.Controls.Add(this.lbl_brand);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(-30, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 464);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.cbGender);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.lbl_address);
            this.groupBox2.Controls.Add(this.txtContact);
            this.groupBox2.Controls.Add(this.lbl_contact);
            this.groupBox2.Controls.Add(this.lbl_gender);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.lbl_pname);
            this.groupBox2.Controls.Add(this.txtAge);
            this.groupBox2.Controls.Add(this.lbl_age);
            this.groupBox2.Controls.Add(this.txtPatientId);
            this.groupBox2.Controls.Add(this.lbl_PId);
            this.groupBox2.Controls.Add(this.lbl_login);
            this.groupBox2.Location = new System.Drawing.Point(63, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 378);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(132, 190);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(262, 21);
            this.cbGender.TabIndex = 23;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtAddress.Location = new System.Drawing.Point(132, 277);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(262, 23);
            this.txtAddress.TabIndex = 20;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_update.FlatAppearance.BorderSize = 2;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_update.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Red;
            this.btn_update.Location = new System.Drawing.Point(99, 325);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(117, 33);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.BackColor = System.Drawing.Color.White;
            this.lbl_address.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(34, 280);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(54, 16);
            this.lbl_address.TabIndex = 19;
            this.lbl_address.Text = "Address";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtContact.Location = new System.Drawing.Point(132, 235);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(262, 23);
            this.txtContact.TabIndex = 18;
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.BackColor = System.Drawing.Color.White;
            this.lbl_contact.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact.Location = new System.Drawing.Point(34, 238);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(70, 16);
            this.lbl_contact.TabIndex = 17;
            this.lbl_contact.Text = "Contact No";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.BackColor = System.Drawing.Color.White;
            this.lbl_gender.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(34, 190);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(49, 16);
            this.lbl_gender.TabIndex = 15;
            this.lbl_gender.Text = "Gender";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtName.Location = new System.Drawing.Point(132, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(262, 23);
            this.txtName.TabIndex = 14;
            // 
            // lbl_pname
            // 
            this.lbl_pname.AutoSize = true;
            this.lbl_pname.BackColor = System.Drawing.Color.White;
            this.lbl_pname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pname.Location = new System.Drawing.Point(34, 109);
            this.lbl_pname.Name = "lbl_pname";
            this.lbl_pname.Size = new System.Drawing.Size(84, 16);
            this.lbl_pname.TabIndex = 13;
            this.lbl_pname.Text = "Patient Name";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtAge.Location = new System.Drawing.Point(132, 146);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(262, 23);
            this.txtAge.TabIndex = 12;
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.BackColor = System.Drawing.Color.White;
            this.lbl_age.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.Location = new System.Drawing.Point(34, 146);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(73, 16);
            this.lbl_age.TabIndex = 11;
            this.lbl_age.Text = "Patient Age";
            // 
            // txtPatientId
            // 
            this.txtPatientId.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtPatientId.Location = new System.Drawing.Point(132, 67);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(262, 23);
            this.txtPatientId.TabIndex = 10;
            // 
            // lbl_PId
            // 
            this.lbl_PId.AutoSize = true;
            this.lbl_PId.BackColor = System.Drawing.Color.White;
            this.lbl_PId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PId.Location = new System.Drawing.Point(34, 70);
            this.lbl_PId.Name = "lbl_PId";
            this.lbl_PId.Size = new System.Drawing.Size(63, 16);
            this.lbl_PId.TabIndex = 9;
            this.lbl_PId.Text = "Patient ID";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(127, 16);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(233, 28);
            this.lbl_login.TabIndex = 6;
            this.lbl_login.Text = "Patient Registration";
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_home.Image = global::HospitalMangementSystem.Properties.Resources.img_home1;
            this.btn_home.Location = new System.Drawing.Point(706, 5);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(61, 50);
            this.btn_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_home.TabIndex = 19;
            this.btn_home.TabStop = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_brand.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand.ForeColor = System.Drawing.Color.Red;
            this.lbl_brand.Location = new System.Drawing.Point(168, 19);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(247, 36);
            this.lbl_brand.TabIndex = 1;
            this.lbl_brand.Text = "Violet Hospital PLC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::HospitalMangementSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(452, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UpdatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 451);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdatePatient";
            this.Text = "UpdatePatient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbl_pname;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label lbl_PId;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.PictureBox btn_home;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}