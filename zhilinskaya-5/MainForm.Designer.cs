namespace zhilinskaya_5
{
    partial class MainForm
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
            this.username = new System.Windows.Forms.Label();
            this.butRed = new System.Windows.Forms.Button();
            this.profil = new System.Windows.Forms.Button();
            this.wherebook = new System.Windows.Forms.Button();
            this.newOreder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.contactName = new System.Windows.Forms.Label();
            this.addres = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkPhone = new System.Windows.Forms.LinkLabel();
            this.linkAddress = new System.Windows.Forms.LinkLabel();
            this.linkFIO = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username.Location = new System.Drawing.Point(21, 9);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(130, 17);
            this.username.TabIndex = 0;
            this.username.Text = "*Имя пользователя*";
            // 
            // butRed
            // 
            this.butRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(254)))));
            this.butRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRed.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butRed.Location = new System.Drawing.Point(41, 178);
            this.butRed.Name = "butRed";
            this.butRed.Size = new System.Drawing.Size(115, 32);
            this.butRed.TabIndex = 1;
            this.butRed.Text = "Редактировать";
            this.butRed.UseVisualStyleBackColor = false;
            // 
            // profil
            // 
            this.profil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(185)))), ((int)(((byte)(254)))));
            this.profil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profil.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profil.Location = new System.Drawing.Point(278, 12);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(129, 42);
            this.profil.TabIndex = 2;
            this.profil.Text = "Данные профиля";
            this.profil.UseVisualStyleBackColor = false;
            // 
            // wherebook
            // 
            this.wherebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(254)))));
            this.wherebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wherebook.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wherebook.Location = new System.Drawing.Point(448, 12);
            this.wherebook.Name = "wherebook";
            this.wherebook.Size = new System.Drawing.Size(129, 42);
            this.wherebook.TabIndex = 3;
            this.wherebook.Text = "Найти книгу";
            this.wherebook.UseVisualStyleBackColor = false;
            // 
            // newOreder
            // 
            this.newOreder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(254)))));
            this.newOreder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOreder.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newOreder.Location = new System.Drawing.Point(621, 12);
            this.newOreder.Name = "newOreder";
            this.newOreder.Size = new System.Drawing.Size(129, 42);
            this.newOreder.TabIndex = 4;
            this.newOreder.Text = "Создать заказ";
            this.newOreder.UseVisualStyleBackColor = false;
            this.newOreder.Click += new System.EventHandler(this.newOreder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Персональные данные:";
            // 
            // customerName
            // 
            this.customerName.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerName.Location = new System.Drawing.Point(15, 54);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(183, 42);
            this.customerName.TabIndex = 6;
            this.customerName.Text = "Ваша организация:";
            // 
            // contactName
            // 
            this.contactName.AutoSize = true;
            this.contactName.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactName.Location = new System.Drawing.Point(15, 96);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(45, 17);
            this.contactName.TabIndex = 7;
            this.contactName.Text = "ФИО:";
            // 
            // addres
            // 
            this.addres.AutoSize = true;
            this.addres.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addres.Location = new System.Drawing.Point(15, 120);
            this.addres.Name = "addres";
            this.addres.Size = new System.Drawing.Size(48, 17);
            this.addres.TabIndex = 8;
            this.addres.Text = "Адрес:";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone.Location = new System.Drawing.Point(15, 149);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(66, 17);
            this.phone.TabIndex = 9;
            this.phone.Text = "Телефон:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.linkPhone);
            this.groupBox1.Controls.Add(this.linkAddress);
            this.groupBox1.Controls.Add(this.linkFIO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.customerName);
            this.groupBox1.Controls.Add(this.addres);
            this.groupBox1.Controls.Add(this.butRed);
            this.groupBox1.Controls.Add(this.contactName);
            this.groupBox1.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(24, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 228);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // linkPhone
            // 
            this.linkPhone.AutoSize = true;
            this.linkPhone.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkPhone.Location = new System.Drawing.Point(79, 149);
            this.linkPhone.Name = "linkPhone";
            this.linkPhone.Size = new System.Drawing.Size(65, 17);
            this.linkPhone.TabIndex = 12;
            this.linkPhone.TabStop = true;
            this.linkPhone.Text = "Показать";
            this.linkPhone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPhone_LinkClicked);
            // 
            // linkAddress
            // 
            this.linkAddress.AutoSize = true;
            this.linkAddress.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkAddress.Location = new System.Drawing.Point(61, 120);
            this.linkAddress.Name = "linkAddress";
            this.linkAddress.Size = new System.Drawing.Size(65, 17);
            this.linkAddress.TabIndex = 11;
            this.linkAddress.TabStop = true;
            this.linkAddress.Text = "Показать";
            this.linkAddress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddress_LinkClicked);
            // 
            // linkFIO
            // 
            this.linkFIO.AutoSize = true;
            this.linkFIO.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkFIO.Location = new System.Drawing.Point(58, 96);
            this.linkFIO.Name = "linkFIO";
            this.linkFIO.Size = new System.Drawing.Size(65, 17);
            this.linkFIO.TabIndex = 10;
            this.linkFIO.TabStop = true;
            this.linkFIO.Text = "Показать";
            this.linkFIO.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFIO_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(277, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ваши заказы:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 299);
            this.dataGridView1.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.newOreder);
            this.Controls.Add(this.wherebook);
            this.Controls.Add(this.profil);
            this.Controls.Add(this.username);
            this.Name = "MainForm";
            this.Text = "Издательство \"Печать\"";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button butRed;
        private System.Windows.Forms.Button profil;
        private System.Windows.Forms.Button wherebook;
        private System.Windows.Forms.Button newOreder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label contactName;
        private System.Windows.Forms.Label addres;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkPhone;
        private System.Windows.Forms.LinkLabel linkAddress;
        private System.Windows.Forms.LinkLabel linkFIO;
    }
}