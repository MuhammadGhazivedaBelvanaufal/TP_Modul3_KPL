namespace TP_Modul3_KPL
{
    partial class Form1
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
            this.InputNama = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputNama
            // 
            this.InputNama.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InputNama.Location = new System.Drawing.Point(25, 36);
            this.InputNama.Name = "InputNama";
            this.InputNama.Size = new System.Drawing.Size(417, 26);
            this.InputNama.TabIndex = 0;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Submit.Location = new System.Drawing.Point(469, 25);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 49);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.BackColor = System.Drawing.SystemColors.Control;
            this.Output.Location = new System.Drawing.Point(63, 95);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(58, 20);
            this.Output.TabIndex = 2;
            this.Output.Text = "Output";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Output);
            this.groupBox1.Controls.Add(this.Submit);
            this.groupBox1.Controls.Add(this.InputNama);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 149);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 181);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "InputNama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox InputNama;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

