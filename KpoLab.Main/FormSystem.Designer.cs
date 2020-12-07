namespace KpoLab.Main
{
    partial class FormSystem
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
            this.textBoxOs = new System.Windows.Forms.TextBox();
            this.labelOs = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.labelRam = new System.Windows.Forms.Label();
            this.textBoxMemory = new System.Windows.Forms.TextBox();
            this.labelMemory = new System.Windows.Forms.Label();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxOs
            // 
            this.textBoxOs.Location = new System.Drawing.Point(109, 8);
            this.textBoxOs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOs.Name = "textBoxOs";
            this.textBoxOs.Size = new System.Drawing.Size(110, 23);
            this.textBoxOs.TabIndex = 0;
            // 
            // labelOs
            // 
            this.labelOs.AutoSize = true;
            this.labelOs.Location = new System.Drawing.Point(10, 11);
            this.labelOs.Name = "labelOs";
            this.labelOs.Size = new System.Drawing.Size(24, 15);
            this.labelOs.TabIndex = 1;
            this.labelOs.Text = "ОС";
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(109, 83);
            this.textBoxPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(110, 23);
            this.textBoxPlace.TabIndex = 0;
            // 
            // labelRam
            // 
            this.labelRam.AutoSize = true;
            this.labelRam.Location = new System.Drawing.Point(10, 86);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(33, 15);
            this.labelRam.TabIndex = 1;
            this.labelRam.Text = "ОЗУ ";
            // 
            // textBoxMemory
            // 
            this.textBoxMemory.Location = new System.Drawing.Point(109, 58);
            this.textBoxMemory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMemory.Name = "textBoxMemory";
            this.textBoxMemory.Size = new System.Drawing.Size(110, 23);
            this.textBoxMemory.TabIndex = 0;
            // 
            // labelMemory
            // 
            this.labelMemory.AutoSize = true;
            this.labelMemory.Location = new System.Drawing.Point(10, 61);
            this.labelMemory.Name = "labelMemory";
            this.labelMemory.Size = new System.Drawing.Size(95, 15);
            this.labelMemory.TabIndex = 1;
            this.labelMemory.Text = "Объём на диске";
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(109, 33);
            this.textBoxDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(110, 23);
            this.textBoxDatabase.TabIndex = 0;
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Location = new System.Drawing.Point(10, 36);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(37, 15);
            this.labelDatabase.TabIndex = 1;
            this.labelDatabase.Text = "СУБД";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(12, 111);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(35, 15);
            this.labelCost.TabIndex = 2;
            this.labelCost.Text = "Цена";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 108);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 23);
            this.textBox1.TabIndex = 3;
            // 
            // FormSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 141);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelDatabase);
            this.Controls.Add(this.textBoxDatabase);
            this.Controls.Add(this.labelMemory);
            this.Controls.Add(this.textBoxMemory);
            this.Controls.Add(this.labelRam);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.labelOs);
            this.Controls.Add(this.textBoxOs);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSystem";
            this.Text = "Конфигурация системы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOs;
        private System.Windows.Forms.Label labelOs;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.Label labelRam;
        private System.Windows.Forms.TextBox textBoxMemory;
        private System.Windows.Forms.Label labelMemory;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox textBox1;
    }
}