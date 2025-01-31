namespace Logical
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.btnLetter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(157, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Letter: ";
            // 
            // txtLetter
            // 
            this.txtLetter.Location = new System.Drawing.Point(194, 145);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(26, 20);
            this.txtLetter.TabIndex = 1;
            // 
            // btnLetter
            // 
            this.btnLetter.Location = new System.Drawing.Point(173, 171);
            this.btnLetter.Name = "btnLetter";
            this.btnLetter.Size = new System.Drawing.Size(75, 23);
            this.btnLetter.TabIndex = 2;
            this.btnLetter.Text = "Submit";
            this.btnLetter.UseVisualStyleBackColor = true;
            this.btnLetter.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.btnLetter);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Logical";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.Button btnLetter;
    }
}

