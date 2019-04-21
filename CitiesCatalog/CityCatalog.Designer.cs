namespace CitiesCatalog
{
    partial class CityCatalog
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
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.textBoxTelephoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxCityCode = new System.Windows.Forms.TextBox();
            this.labelTelephoneCode = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(56, 180);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(96, 13);
            this.labelTelephone.TabIndex = 0;
            this.labelTelephone.Text = "Номер телефона:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(56, 138);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(40, 13);
            this.labelCity.TabIndex = 1;
            this.labelCity.Text = "Город:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(56, 103);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(32, 13);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Имя:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(56, 70);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(59, 13);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Фамилия:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(150, 242);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "ок";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(130, 135);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCity.TabIndex = 5;
            this.comboBoxCity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // textBoxTelephoneNumber
            // 
            this.textBoxTelephoneNumber.Location = new System.Drawing.Point(231, 177);
            this.textBoxTelephoneNumber.Name = "textBoxTelephoneNumber";
            this.textBoxTelephoneNumber.Size = new System.Drawing.Size(73, 20);
            this.textBoxTelephoneNumber.TabIndex = 6;
            this.textBoxTelephoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelephoneNumber_KeyPress);
            // 
            // textBoxCityCode
            // 
            this.textBoxCityCode.Location = new System.Drawing.Point(186, 177);
            this.textBoxCityCode.Name = "textBoxCityCode";
            this.textBoxCityCode.ReadOnly = true;
            this.textBoxCityCode.Size = new System.Drawing.Size(39, 20);
            this.textBoxCityCode.TabIndex = 7;
            // 
            // labelTelephoneCode
            // 
            this.labelTelephoneCode.AutoSize = true;
            this.labelTelephoneCode.Location = new System.Drawing.Point(161, 180);
            this.labelTelephoneCode.Name = "labelTelephoneCode";
            this.labelTelephoneCode.Size = new System.Drawing.Size(19, 13);
            this.labelTelephoneCode.TabIndex = 8;
            this.labelTelephoneCode.Text = "+7";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(130, 103);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(174, 20);
            this.textBoxFirstName.TabIndex = 9;
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(130, 70);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(174, 20);
            this.textBoxLastName.TabIndex = 10;
            this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLastName_KeyPress);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(110, 287);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 11;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(127, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(110, 13);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Заполнение формы:";
            // 
            // CityCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 328);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelTelephoneCode);
            this.Controls.Add(this.textBoxCityCode);
            this.Controls.Add(this.textBoxTelephoneNumber);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelTelephone);
            this.Name = "CityCatalog";
            this.Text = "CityCatalog";
            this.Load += new System.EventHandler(this.CityCatalog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.TextBox textBoxTelephoneNumber;
        private System.Windows.Forms.TextBox textBoxCityCode;
        private System.Windows.Forms.Label labelTelephoneCode;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelTitle;
    }
}

