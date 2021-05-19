
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBardzoDuza = new System.Windows.Forms.RadioButton();
            this.radDuza = new System.Windows.Forms.RadioButton();
            this.radioMala = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radPodkreslona = new System.Windows.Forms.RadioButton();
            this.radPochylona = new System.Windows.Forms.RadioButton();
            this.radPogrubiona = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radPomaranczowy = new System.Windows.Forms.RadioButton();
            this.radNiebieski = new System.Windows.Forms.RadioButton();
            this.radCzerwony = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(133, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj tekst";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(286, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBardzoDuza);
            this.groupBox1.Controls.Add(this.radDuza);
            this.groupBox1.Controls.Add(this.radioMala);
            this.groupBox1.Location = new System.Drawing.Point(55, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wielkosc";
            // 
            // radBardzoDuza
            // 
            this.radBardzoDuza.AutoSize = true;
            this.radBardzoDuza.Location = new System.Drawing.Point(27, 103);
            this.radBardzoDuza.Name = "radBardzoDuza";
            this.radBardzoDuza.Size = new System.Drawing.Size(89, 19);
            this.radBardzoDuza.TabIndex = 2;
            this.radBardzoDuza.TabStop = true;
            this.radBardzoDuza.Text = "bardzo duża";
            this.radBardzoDuza.UseVisualStyleBackColor = true;
            // 
            // radDuza
            // 
            this.radDuza.AutoSize = true;
            this.radDuza.Location = new System.Drawing.Point(27, 69);
            this.radDuza.Name = "radDuza";
            this.radDuza.Size = new System.Drawing.Size(51, 19);
            this.radDuza.TabIndex = 1;
            this.radDuza.TabStop = true;
            this.radDuza.Text = "Duża";
            this.radDuza.UseVisualStyleBackColor = true;
            // 
            // radioMala
            // 
            this.radioMala.AutoSize = true;
            this.radioMala.Location = new System.Drawing.Point(27, 33);
            this.radioMala.Name = "radioMala";
            this.radioMala.Size = new System.Drawing.Size(51, 19);
            this.radioMala.TabIndex = 0;
            this.radioMala.TabStop = true;
            this.radioMala.Text = "mała";
            this.radioMala.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radPodkreslona);
            this.groupBox2.Controls.Add(this.radPochylona);
            this.groupBox2.Controls.Add(this.radPogrubiona);
            this.groupBox2.Location = new System.Drawing.Point(313, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 137);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Styl czcionki";
            // 
            // radPodkreslona
            // 
            this.radPodkreslona.AutoSize = true;
            this.radPodkreslona.Location = new System.Drawing.Point(37, 103);
            this.radPodkreslona.Name = "radPodkreslona";
            this.radPodkreslona.Size = new System.Drawing.Size(92, 19);
            this.radPodkreslona.TabIndex = 2;
            this.radPodkreslona.TabStop = true;
            this.radPodkreslona.Text = "Podkreslenie";
            this.radPodkreslona.UseVisualStyleBackColor = true;
            // 
            // radPochylona
            // 
            this.radPochylona.AutoSize = true;
            this.radPochylona.Location = new System.Drawing.Point(37, 69);
            this.radPochylona.Name = "radPochylona";
            this.radPochylona.Size = new System.Drawing.Size(83, 19);
            this.radPochylona.TabIndex = 1;
            this.radPochylona.TabStop = true;
            this.radPochylona.Text = "Pochylenie";
            this.radPochylona.UseVisualStyleBackColor = true;
            // 
            // radPogrubiona
            // 
            this.radPogrubiona.AutoSize = true;
            this.radPogrubiona.Location = new System.Drawing.Point(37, 32);
            this.radPogrubiona.Name = "radPogrubiona";
            this.radPogrubiona.Size = new System.Drawing.Size(89, 19);
            this.radPogrubiona.TabIndex = 0;
            this.radPogrubiona.TabStop = true;
            this.radPogrubiona.Text = "Pogrubienie";
            this.radPogrubiona.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radPomaranczowy);
            this.groupBox3.Controls.Add(this.radNiebieski);
            this.groupBox3.Controls.Add(this.radCzerwony);
            this.groupBox3.Location = new System.Drawing.Point(577, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 137);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kolor czcionki";
            // 
            // radPomaranczowy
            // 
            this.radPomaranczowy.AutoSize = true;
            this.radPomaranczowy.Location = new System.Drawing.Point(23, 102);
            this.radPomaranczowy.Name = "radPomaranczowy";
            this.radPomaranczowy.Size = new System.Drawing.Size(106, 19);
            this.radPomaranczowy.TabIndex = 2;
            this.radPomaranczowy.TabStop = true;
            this.radPomaranczowy.Text = "pomaranczowy";
            this.radPomaranczowy.UseVisualStyleBackColor = true;
            // 
            // radNiebieski
            // 
            this.radNiebieski.AutoSize = true;
            this.radNiebieski.Location = new System.Drawing.Point(23, 69);
            this.radNiebieski.Name = "radNiebieski";
            this.radNiebieski.Size = new System.Drawing.Size(71, 19);
            this.radNiebieski.TabIndex = 1;
            this.radNiebieski.TabStop = true;
            this.radNiebieski.Text = "niebieski";
            this.radNiebieski.UseVisualStyleBackColor = true;
            // 
            // radCzerwony
            // 
            this.radCzerwony.AutoSize = true;
            this.radCzerwony.Location = new System.Drawing.Point(23, 31);
            this.radCzerwony.Name = "radCzerwony";
            this.radCzerwony.Size = new System.Drawing.Size(75, 19);
            this.radCzerwony.TabIndex = 0;
            this.radCzerwony.TabStop = true;
            this.radCzerwony.Text = "czerwony";
            this.radCzerwony.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(302, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aktualizuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBardzoDuza;
        private System.Windows.Forms.RadioButton radDuza;
        private System.Windows.Forms.RadioButton radioMala;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radPodkreslona;
        private System.Windows.Forms.RadioButton radPochylona;
        private System.Windows.Forms.RadioButton radPogrubiona;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radPomaranczowy;
        private System.Windows.Forms.RadioButton radNiebieski;
        private System.Windows.Forms.RadioButton radCzerwony;
        private System.Windows.Forms.Button button1;
    }
}

