namespace zhilinskaya_5
{
    partial class Autorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCapha = new System.Windows.Forms.TextBox();
            this.pictureCapcha = new System.Windows.Forms.PictureBox();
            this.labelCapcha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapcha)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(77, 88);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(174, 20);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(77, 129);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(174, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(185)))), ((int)(((byte)(254)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(50, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // pictureIcon
            // 
            this.pictureIcon.Image = global::zhilinskaya_5.Properties.Resources.MIX_SLP10_150ppp_01;
            this.pictureIcon.Location = new System.Drawing.Point(287, 50);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(174, 174);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureIcon.TabIndex = 5;
            this.pictureIcon.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(47, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "Издательский центр «Печать»";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textCapha
            // 
            this.textCapha.Location = new System.Drawing.Point(305, 192);
            this.textCapha.Name = "textCapha";
            this.textCapha.Size = new System.Drawing.Size(137, 20);
            this.textCapha.TabIndex = 7;
            this.textCapha.Visible = false;
            // 
            // pictureCapcha
            // 
            this.pictureCapcha.Location = new System.Drawing.Point(287, 87);
            this.pictureCapcha.Name = "pictureCapcha";
            this.pictureCapcha.Size = new System.Drawing.Size(174, 98);
            this.pictureCapcha.TabIndex = 8;
            this.pictureCapcha.TabStop = false;
            this.pictureCapcha.Visible = false;
            // 
            // labelCapcha
            // 
            this.labelCapcha.AutoSize = true;
            this.labelCapcha.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCapcha.Location = new System.Drawing.Point(298, 62);
            this.labelCapcha.Name = "labelCapcha";
            this.labelCapcha.Size = new System.Drawing.Size(153, 18);
            this.labelCapcha.TabIndex = 9;
            this.labelCapcha.Text = "Выпишите символы";
            this.labelCapcha.Visible = false;
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(500, 310);
            this.Controls.Add(this.labelCapcha);
            this.Controls.Add(this.pictureCapcha);
            this.Controls.Add(this.textCapha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureIcon);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Autorization";
            this.Text = "Издательство \"Печать\"";
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCapha;
        private System.Windows.Forms.PictureBox pictureCapcha;
        private System.Windows.Forms.Label labelCapcha;
    }
}

