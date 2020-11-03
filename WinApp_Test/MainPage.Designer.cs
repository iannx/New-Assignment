namespace WinApp_Test
{
    partial class MainPage
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbCV = new System.Windows.Forms.Label();
            this.lbGoogle = new System.Windows.Forms.Label();
            this.lbABC = new System.Windows.Forms.Label();
            this.lbXYZ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.lbCV);
            this.splitContainer1.Panel1.Controls.Add(this.lbGoogle);
            this.splitContainer1.Panel1.Controls.Add(this.lbABC);
            this.splitContainer1.Panel1.Controls.Add(this.lbXYZ);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(784, 561);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbCV
            // 
            this.lbCV.AutoSize = true;
            this.lbCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbCV.Location = new System.Drawing.Point(12, 282);
            this.lbCV.Name = "lbCV";
            this.lbCV.Size = new System.Drawing.Size(45, 29);
            this.lbCV.TabIndex = 7;
            this.lbCV.Text = "CV";
            this.lbCV.Click += new System.EventHandler(this.lbCV_Click);
            // 
            // lbGoogle
            // 
            this.lbGoogle.AutoSize = true;
            this.lbGoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbGoogle.Location = new System.Drawing.Point(12, 242);
            this.lbGoogle.Name = "lbGoogle";
            this.lbGoogle.Size = new System.Drawing.Size(189, 29);
            this.lbGoogle.TabIndex = 6;
            this.lbGoogle.Text = "API Google Map";
            this.lbGoogle.Click += new System.EventHandler(this.lbGoogle_Click);
            // 
            // lbABC
            // 
            this.lbABC.AutoSize = true;
            this.lbABC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbABC.Location = new System.Drawing.Point(12, 200);
            this.lbABC.Name = "lbABC";
            this.lbABC.Size = new System.Drawing.Size(204, 29);
            this.lbABC.TabIndex = 5;
            this.lbABC.Text = "Assignment A B C";
            this.lbABC.Click += new System.EventHandler(this.lbABC_Click);
            // 
            // lbXYZ
            // 
            this.lbXYZ.AutoSize = true;
            this.lbXYZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbXYZ.Location = new System.Drawing.Point(12, 158);
            this.lbXYZ.Name = "lbXYZ";
            this.lbXYZ.Size = new System.Drawing.Size(191, 29);
            this.lbXYZ.TabIndex = 4;
            this.lbXYZ.Text = "Assignment XYZ";
            this.lbXYZ.Click += new System.EventHandler(this.lbXYZ_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(57, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "SCG Assignment 2020";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(74, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Welcome to SCG Assignment!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(107, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "In your left panel is menu of assignment.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(91, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "You can click on them name to change page.";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainPage";
            this.Text = "SCG Assignment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbCV;
        private System.Windows.Forms.Label lbGoogle;
        private System.Windows.Forms.Label lbABC;
        private System.Windows.Forms.Label lbXYZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

