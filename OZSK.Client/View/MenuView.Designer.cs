namespace OZSK.Client.View
{
    partial class MenuView
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
            this.buttonAddAuto = new System.Windows.Forms.Button();
            this.buttonAddCarrier = new System.Windows.Forms.Button();
            this.buttonAddDriver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddAuto
            // 
            this.buttonAddAuto.Location = new System.Drawing.Point(13, 13);
            this.buttonAddAuto.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddAuto.Name = "buttonAddAuto";
            this.buttonAddAuto.Size = new System.Drawing.Size(120, 62);
            this.buttonAddAuto.TabIndex = 32;
            this.buttonAddAuto.Text = "Добавить ТС";
            this.buttonAddAuto.UseVisualStyleBackColor = true;
            this.buttonAddAuto.Click += new System.EventHandler(this.buttonAddAuto_Click);
            // 
            // buttonAddCarrier
            // 
            this.buttonAddCarrier.Location = new System.Drawing.Point(13, 165);
            this.buttonAddCarrier.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddCarrier.Name = "buttonAddCarrier";
            this.buttonAddCarrier.Size = new System.Drawing.Size(120, 62);
            this.buttonAddCarrier.TabIndex = 31;
            this.buttonAddCarrier.Text = "Добавить перевозчика";
            this.buttonAddCarrier.UseVisualStyleBackColor = true;
            this.buttonAddCarrier.Click += new System.EventHandler(this.buttonAddCarrier_Click);
            // 
            // buttonAddDriver
            // 
            this.buttonAddDriver.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddDriver.Location = new System.Drawing.Point(13, 95);
            this.buttonAddDriver.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddDriver.Name = "buttonAddDriver";
            this.buttonAddDriver.Size = new System.Drawing.Size(120, 62);
            this.buttonAddDriver.TabIndex = 30;
            this.buttonAddDriver.Text = "Добавить водителя";
            this.buttonAddDriver.UseVisualStyleBackColor = true;
            this.buttonAddDriver.Click += new System.EventHandler(this.buttonAddDriver_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 62);
            this.button1.TabIndex = 33;
            this.button1.Text = "Изменить ТС";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(154, 95);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 62);
            this.button2.TabIndex = 34;
            this.button2.Text = "Изменить водителя";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(154, 165);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 62);
            this.button3.TabIndex = 35;
            this.button3.Text = "Изменить перевозчика";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 235);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 62);
            this.button4.TabIndex = 36;
            this.button4.Text = "Создать документ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 447);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddAuto);
            this.Controls.Add(this.buttonAddCarrier);
            this.Controls.Add(this.buttonAddDriver);
            this.Name = "MenuView";
            this.Text = "MenuViewModel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddAuto;
        private System.Windows.Forms.Button buttonAddCarrier;
        private System.Windows.Forms.Button buttonAddDriver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}