namespace OZSK.Client
{
    partial class DriverView
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
            this.components = new System.ComponentModel.Container();
            this.Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.bindingSourceViewModel = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.comboBoxAutos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDrivers = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceViewModel)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save.Location = new System.Drawing.Point(255, 257);
            this.Save.Margin = new System.Windows.Forms.Padding(4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(133, 37);
            this.Save.TabIndex = 21;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Транспортное средство";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Серия и номер ВУ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "ФИО";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceViewModel, "Number", true));
            this.textBoxNumber.Location = new System.Drawing.Point(73, 159);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(509, 22);
            this.textBoxNumber.TabIndex = 12;
            // 
            // bindingSourceViewModel
            // 
            this.bindingSourceViewModel.DataSource = typeof(OZSK.Client.ViewModel.Driver.DriverViewModel);
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceViewModel, "Fio", true));
            this.textBoxFIO.Location = new System.Drawing.Point(73, 110);
            this.textBoxFIO.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(509, 22);
            this.textBoxFIO.TabIndex = 11;
            // 
            // comboBoxAutos
            // 
            this.comboBoxAutos.DisplayMember = "Id";
            this.comboBoxAutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAutos.FormattingEnabled = true;
            this.comboBoxAutos.Location = new System.Drawing.Point(73, 209);
            this.comboBoxAutos.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAutos.Name = "comboBoxAutos";
            this.comboBoxAutos.Size = new System.Drawing.Size(509, 24);
            this.comboBoxAutos.TabIndex = 24;
            this.comboBoxAutos.ValueMember = "Id";
            this.comboBoxAutos.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Список водителей";
            // 
            // comboBoxDrivers
            // 
            this.comboBoxDrivers.DisplayMember = "Id";
            this.comboBoxDrivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrivers.FormattingEnabled = true;
            this.comboBoxDrivers.Location = new System.Drawing.Point(72, 42);
            this.comboBoxDrivers.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDrivers.Name = "comboBoxDrivers";
            this.comboBoxDrivers.Size = new System.Drawing.Size(509, 24);
            this.comboBoxDrivers.TabIndex = 26;
            this.comboBoxDrivers.ValueMember = "Id";
            this.comboBoxDrivers.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrivers_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(448, 257);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 37);
            this.button1.TabIndex = 39;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DriverView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxDrivers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxAutos);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxFIO);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DriverView";
            this.Text = "Добавить водителя";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceViewModel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.ComboBox comboBoxAutos;
        private System.Windows.Forms.BindingSource bindingSourceViewModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDrivers;
        private System.Windows.Forms.Button button1;
    }
}