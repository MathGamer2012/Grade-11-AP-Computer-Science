namespace Quadrilateral
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
            this.lblCap1 = new System.Windows.Forms.Label();
            this.txtAngle1 = new System.Windows.Forms.TextBox();
            this.txtAngle2 = new System.Windows.Forms.TextBox();
            this.txtAngle3 = new System.Windows.Forms.TextBox();
            this.txtAngle4 = new System.Windows.Forms.TextBox();
            this.txtSide1 = new System.Windows.Forms.TextBox();
            this.txtSide2 = new System.Windows.Forms.TextBox();
            this.txtSide3 = new System.Windows.Forms.TextBox();
            this.txtSide4 = new System.Windows.Forms.TextBox();
            this.lblCap2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCap1
            // 
            this.lblCap1.AutoSize = true;
            this.lblCap1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCap1.Location = new System.Drawing.Point(72, 37);
            this.lblCap1.Name = "lblCap1";
            this.lblCap1.Size = new System.Drawing.Size(57, 17);
            this.lblCap1.TabIndex = 0;
            this.lblCap1.Text = "Angles";
            // 
            // txtAngle1
            // 
            this.txtAngle1.Location = new System.Drawing.Point(51, 68);
            this.txtAngle1.Name = "txtAngle1";
            this.txtAngle1.Size = new System.Drawing.Size(100, 20);
            this.txtAngle1.TabIndex = 1;
            this.txtAngle1.Text = "AngleA";
            // 
            // txtAngle2
            // 
            this.txtAngle2.Location = new System.Drawing.Point(51, 107);
            this.txtAngle2.Name = "txtAngle2";
            this.txtAngle2.Size = new System.Drawing.Size(100, 20);
            this.txtAngle2.TabIndex = 2;
            this.txtAngle2.Text = "AngleB";
            // 
            // txtAngle3
            // 
            this.txtAngle3.Location = new System.Drawing.Point(51, 148);
            this.txtAngle3.Name = "txtAngle3";
            this.txtAngle3.Size = new System.Drawing.Size(100, 20);
            this.txtAngle3.TabIndex = 3;
            this.txtAngle3.Text = "AngleC";
            // 
            // txtAngle4
            // 
            this.txtAngle4.Location = new System.Drawing.Point(51, 190);
            this.txtAngle4.Name = "txtAngle4";
            this.txtAngle4.Size = new System.Drawing.Size(100, 20);
            this.txtAngle4.TabIndex = 4;
            this.txtAngle4.Text = "AngleD";
            // 
            // txtSide1
            // 
            this.txtSide1.Location = new System.Drawing.Point(176, 68);
            this.txtSide1.Name = "txtSide1";
            this.txtSide1.Size = new System.Drawing.Size(100, 20);
            this.txtSide1.TabIndex = 5;
            this.txtSide1.Text = "SideA";
            // 
            // txtSide2
            // 
            this.txtSide2.Location = new System.Drawing.Point(176, 107);
            this.txtSide2.Name = "txtSide2";
            this.txtSide2.Size = new System.Drawing.Size(100, 20);
            this.txtSide2.TabIndex = 6;
            this.txtSide2.Text = "SideB";
            // 
            // txtSide3
            // 
            this.txtSide3.Location = new System.Drawing.Point(176, 148);
            this.txtSide3.Name = "txtSide3";
            this.txtSide3.Size = new System.Drawing.Size(100, 20);
            this.txtSide3.TabIndex = 7;
            this.txtSide3.Text = "SideC";
            // 
            // txtSide4
            // 
            this.txtSide4.Location = new System.Drawing.Point(176, 190);
            this.txtSide4.Name = "txtSide4";
            this.txtSide4.Size = new System.Drawing.Size(100, 20);
            this.txtSide4.TabIndex = 8;
            this.txtSide4.Text = "SideD";
            // 
            // lblCap2
            // 
            this.lblCap2.AutoSize = true;
            this.lblCap2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCap2.Location = new System.Drawing.Point(196, 37);
            this.lblCap2.Name = "lblCap2";
            this.lblCap2.Size = new System.Drawing.Size(48, 17);
            this.lblCap2.TabIndex = 9;
            this.lblCap2.Text = "Sides";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(65, 234);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(186, 234);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblOutput.Location = new System.Drawing.Point(302, 124);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 17);
            this.lblOutput.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 299);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblCap2);
            this.Controls.Add(this.txtSide4);
            this.Controls.Add(this.txtSide3);
            this.Controls.Add(this.txtSide2);
            this.Controls.Add(this.txtSide1);
            this.Controls.Add(this.txtAngle4);
            this.Controls.Add(this.txtAngle3);
            this.Controls.Add(this.txtAngle2);
            this.Controls.Add(this.txtAngle1);
            this.Controls.Add(this.lblCap1);
            this.Name = "frmMain";
            this.Text = "Quadrilateral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCap1;
        private System.Windows.Forms.TextBox txtAngle1;
        private System.Windows.Forms.TextBox txtAngle2;
        private System.Windows.Forms.TextBox txtAngle3;
        private System.Windows.Forms.TextBox txtAngle4;
        private System.Windows.Forms.TextBox txtSide1;
        private System.Windows.Forms.TextBox txtSide2;
        private System.Windows.Forms.TextBox txtSide3;
        private System.Windows.Forms.TextBox txtSide4;
        private System.Windows.Forms.Label lblCap2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblOutput;
    }
}

