
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radKobieta = new System.Windows.Forms.RadioButton();
            this.radMezczyzna = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkIdealna = new System.Windows.Forms.CheckBox();
            this.checkStandard = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labWynik = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(119, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj wzrost [cm]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(119, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podaj płeć";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radKobieta
            // 
            this.radKobieta.AutoSize = true;
            this.radKobieta.Location = new System.Drawing.Point(284, 157);
            this.radKobieta.Name = "radKobieta";
            this.radKobieta.Size = new System.Drawing.Size(65, 19);
            this.radKobieta.TabIndex = 2;
            this.radKobieta.TabStop = true;
            this.radKobieta.Text = "Kobieta";
            this.radKobieta.UseVisualStyleBackColor = true;
            // 
            // radMezczyzna
            // 
            this.radMezczyzna.AutoSize = true;
            this.radMezczyzna.Location = new System.Drawing.Point(411, 157);
            this.radMezczyzna.Name = "radMezczyzna";
            this.radMezczyzna.Size = new System.Drawing.Size(82, 19);
            this.radMezczyzna.TabIndex = 3;
            this.radMezczyzna.TabStop = true;
            this.radMezczyzna.Text = "Męzczyzna";
            this.radMezczyzna.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkStandard);
            this.groupBox1.Controls.Add(this.checkIdealna);
            this.groupBox1.Location = new System.Drawing.Point(563, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "waga";
            // 
            // checkIdealna
            // 
            this.checkIdealna.AutoSize = true;
            this.checkIdealna.Location = new System.Drawing.Point(24, 31);
            this.checkIdealna.Name = "checkIdealna";
            this.checkIdealna.Size = new System.Drawing.Size(64, 19);
            this.checkIdealna.TabIndex = 0;
            this.checkIdealna.Text = "Idealna";
            this.checkIdealna.UseVisualStyleBackColor = true;
            // 
            // checkStandard
            // 
            this.checkStandard.AutoSize = true;
            this.checkStandard.Location = new System.Drawing.Point(24, 67);
            this.checkStandard.Name = "checkStandard";
            this.checkStandard.Size = new System.Drawing.Size(95, 19);
            this.checkStandard.TabIndex = 1;
            this.checkStandard.Text = "Standardowa";
            this.checkStandard.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labWynik
            // 
            this.labWynik.AutoSize = true;
            this.labWynik.Location = new System.Drawing.Point(69, 382);
            this.labWynik.Name = "labWynik";
            this.labWynik.Size = new System.Drawing.Size(40, 15);
            this.labWynik.TabIndex = 6;
            this.labWynik.Text = "Wynik";
            this.labWynik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labWynik);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radMezczyzna);
            this.Controls.Add(this.radKobieta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radKobieta;
        private System.Windows.Forms.RadioButton radMezczyzna;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkStandard;
        private System.Windows.Forms.CheckBox checkIdealna;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labWynik;
        private System.Windows.Forms.TextBox textBox1;
    }
}

