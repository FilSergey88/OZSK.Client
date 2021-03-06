﻿namespace OZSK.Client
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            this.textBoxTN = new System.Windows.Forms.TextBox();
            this.bindingSourceViewModel = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxOV = new System.Windows.Forms.TextBox();
            this.textBoxConsigneeName = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxMassa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCarriers = new System.Windows.Forms.ComboBox();
            this.ComboBoxCipherList = new System.Windows.Forms.ComboBox();
            this.comboBoxNameShipping = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBoxDrivers = new System.Windows.Forms.ComboBox();
            this.comboBoxAutos = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceViewModel)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTN
            // 
            this.textBoxTN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceViewModel, "Tn", true));
            this.textBoxTN.Location = new System.Drawing.Point(165, 42);
            this.textBoxTN.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTN.Name = "textBoxTN";
            this.textBoxTN.Size = new System.Drawing.Size(105, 22);
            this.textBoxTN.TabIndex = 0;
            // 
            // bindingSourceViewModel
            // 
            this.bindingSourceViewModel.DataSource = typeof(OZSK.Client.ViewModel.Main.MainViewModel);
            // 
            // textBoxOV
            // 
            this.textBoxOV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceViewModel, "Ov", true));
            this.textBoxOV.Location = new System.Drawing.Point(296, 42);
            this.textBoxOV.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOV.Name = "textBoxOV";
            this.textBoxOV.Size = new System.Drawing.Size(105, 22);
            this.textBoxOV.TabIndex = 1;
            // 
            // textBoxConsigneeName
            // 
            this.textBoxConsigneeName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceViewModel, "ConsigneeName", true));
            this.textBoxConsigneeName.Location = new System.Drawing.Point(40, 145);
            this.textBoxConsigneeName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConsigneeName.Name = "textBoxConsigneeName";
            this.textBoxConsigneeName.Size = new System.Drawing.Size(361, 22);
            this.textBoxConsigneeName.TabIndex = 2;
            // 
            // textBoxCount
            // 
            this.textBoxCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceViewModel, "Count", true));
            this.textBoxCount.Location = new System.Drawing.Point(41, 257);
            this.textBoxCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(147, 22);
            this.textBoxCount.TabIndex = 3;
            // 
            // textBoxMassa
            // 
            this.textBoxMassa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceViewModel, "Massa", true));
            this.textBoxMassa.Location = new System.Drawing.Point(255, 257);
            this.textBoxMassa.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMassa.Name = "textBoxMassa";
            this.textBoxMassa.Size = new System.Drawing.Size(147, 22);
            this.textBoxMassa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Шифр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "№ ТН";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "№ ОВ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Грузополучатель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Наименование груза";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Количество мест";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Масса груза";
            // 
            // comboBoxCarriers
            // 
            this.comboBoxCarriers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarriers.FormattingEnabled = true;
            this.comboBoxCarriers.Location = new System.Drawing.Point(40, 306);
            this.comboBoxCarriers.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCarriers.Name = "comboBoxCarriers";
            this.comboBoxCarriers.Size = new System.Drawing.Size(361, 24);
            this.comboBoxCarriers.TabIndex = 18;
            this.comboBoxCarriers.SelectedValueChanged += new System.EventHandler(this.comboBoxCarriers_SelectedValueChanged);
            // 
            // ComboBoxCipherList
            // 
            this.ComboBoxCipherList.DisplayMember = "Id";
            this.ComboBoxCipherList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCipherList.FormattingEnabled = true;
            this.ComboBoxCipherList.Location = new System.Drawing.Point(40, 42);
            this.ComboBoxCipherList.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxCipherList.Name = "ComboBoxCipherList";
            this.ComboBoxCipherList.Size = new System.Drawing.Size(105, 24);
            this.ComboBoxCipherList.TabIndex = 19;
            this.ComboBoxCipherList.ValueMember = "Id";
            this.ComboBoxCipherList.SelectedValueChanged += new System.EventHandler(this.ComboBoxCipherList_SelectedValueChanged);
            // 
            // comboBoxNameShipping
            // 
            this.comboBoxNameShipping.DisplayMember = "Id";
            this.comboBoxNameShipping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNameShipping.FormattingEnabled = true;
            this.comboBoxNameShipping.Location = new System.Drawing.Point(41, 208);
            this.comboBoxNameShipping.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxNameShipping.Name = "comboBoxNameShipping";
            this.comboBoxNameShipping.Size = new System.Drawing.Size(361, 24);
            this.comboBoxNameShipping.TabIndex = 20;
            this.comboBoxNameShipping.ValueMember = "Id";
            this.comboBoxNameShipping.SelectedValueChanged += new System.EventHandler(this.comboBoxNameShipping_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 287);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Перевозчик";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 383);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "ФИО водителя";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 334);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Транспортное средство";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceViewModel, "Date", true));
            this.dateTimePickerDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceViewModel, "Date", true));
            this.dateTimePickerDate.Location = new System.Drawing.Point(39, 97);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(260, 22);
            this.dateTimePickerDate.TabIndex = 24;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 450);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 62);
            this.button3.TabIndex = 27;
            this.button3.Text = "Создать ОВ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(243, 450);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 62);
            this.button4.TabIndex = 28;
            this.button4.Text = "Создать ТН";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBoxDrivers
            // 
            this.comboBoxDrivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrivers.FormattingEnabled = true;
            this.comboBoxDrivers.Location = new System.Drawing.Point(40, 403);
            this.comboBoxDrivers.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDrivers.Name = "comboBoxDrivers";
            this.comboBoxDrivers.Size = new System.Drawing.Size(361, 24);
            this.comboBoxDrivers.TabIndex = 30;
            this.comboBoxDrivers.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrivers_SelectedIndexChanged);
            // 
            // comboBoxAutos
            // 
            this.comboBoxAutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAutos.FormattingEnabled = true;
            this.comboBoxAutos.Location = new System.Drawing.Point(39, 355);
            this.comboBoxAutos.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAutos.Name = "comboBoxAutos";
            this.comboBoxAutos.Size = new System.Drawing.Size(361, 24);
            this.comboBoxAutos.TabIndex = 31;
            this.comboBoxAutos.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutos_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 529);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 62);
            this.button1.TabIndex = 32;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 604);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxAutos);
            this.Controls.Add(this.comboBoxDrivers);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxNameShipping);
            this.Controls.Add(this.ComboBoxCipherList);
            this.Controls.Add(this.comboBoxCarriers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMassa);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxConsigneeName);
            this.Controls.Add(this.textBoxOV);
            this.Controls.Add(this.textBoxTN);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainView_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceViewModel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTN;
        private System.Windows.Forms.TextBox textBoxOV;
        private System.Windows.Forms.TextBox textBoxConsigneeName;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxMassa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCarriers;
        private System.Windows.Forms.ComboBox ComboBoxCipherList;
        private System.Windows.Forms.ComboBox comboBoxNameShipping;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource bindingSourceViewModel;
        private System.Windows.Forms.ComboBox comboBoxDrivers;
        private System.Windows.Forms.ComboBox comboBoxAutos;
        private System.Windows.Forms.Button button1;
    }
}

