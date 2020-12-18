﻿using OZSK.Client.ViewModel.Auto;

namespace OZSK.Client
{
    partial class AutoView
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPTS = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxSTS = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCarriers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSourceViewModel = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceViewModel)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(200, 283);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(133, 37);
            this.buttonSave.TabIndex = 30;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "СТС";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "ПТС";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Марка ТС";
            // 
            // textBoxPTS
            // 
            this.textBoxPTS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceViewModel, "PTS", true));
            this.textBoxPTS.Location = new System.Drawing.Point(16, 80);
            this.textBoxPTS.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPTS.Name = "textBoxPTS";
            this.textBoxPTS.Size = new System.Drawing.Size(509, 22);
            this.textBoxPTS.TabIndex = 26;
            // 
            // textBoxModel
            // 
            this.textBoxModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceViewModel, "Model", true));
            this.textBoxModel.Location = new System.Drawing.Point(16, 32);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(509, 22);
            this.textBoxModel.TabIndex = 25;
            // 
            // textBoxSTS
            // 
            this.textBoxSTS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceViewModel, "STS", true));
            this.textBoxSTS.Location = new System.Drawing.Point(16, 130);
            this.textBoxSTS.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSTS.Name = "textBoxSTS";
            this.textBoxSTS.Size = new System.Drawing.Size(509, 22);
            this.textBoxSTS.TabIndex = 31;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceViewModel, "Number", true));
            this.textBoxNumber.Location = new System.Drawing.Point(16, 183);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(509, 22);
            this.textBoxNumber.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Гос Номер ТС";
            // 
            // comboBoxCarriers
            // 
            this.comboBoxCarriers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarriers.FormattingEnabled = true;
            this.comboBoxCarriers.Location = new System.Drawing.Point(16, 234);
            this.comboBoxCarriers.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCarriers.Name = "comboBoxCarriers";
            this.comboBoxCarriers.Size = new System.Drawing.Size(509, 24);
            this.comboBoxCarriers.TabIndex = 34;
            this.comboBoxCarriers.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Перевозчик";
            // 
            // bindingSourceViewModel
            // 
            this.bindingSourceViewModel.DataSource = typeof(OZSK.Client.ViewModel.Auto.AutoViewModel);
            // 
            // AutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 335);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCarriers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxSTS);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPTS);
            this.Controls.Add(this.textBoxModel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AutoView";
            this.Text = "Добавление ТС";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceViewModel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPTS;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxSTS;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCarriers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSourceViewModel;
    }
}