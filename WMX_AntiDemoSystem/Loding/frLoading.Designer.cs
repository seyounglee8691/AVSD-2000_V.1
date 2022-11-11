namespace WMX_Anti
{
    partial class frLoading
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
            this.btstart = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.loadingbar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btstart
            // 
            this.btstart.BackColor = System.Drawing.SystemColors.Control;
            this.btstart.FlatAppearance.BorderSize = 2;
            this.btstart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btstart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btstart.ForeColor = System.Drawing.Color.Black;
            this.btstart.Location = new System.Drawing.Point(237, 97);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(117, 55);
            this.btstart.TabIndex = 97;
            this.btstart.Text = "Start";
            this.btstart.UseVisualStyleBackColor = false;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            // 
            // btexit
            // 
            this.btexit.BackColor = System.Drawing.SystemColors.Control;
            this.btexit.FlatAppearance.BorderSize = 2;
            this.btexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexit.ForeColor = System.Drawing.Color.Black;
            this.btexit.Location = new System.Drawing.Point(360, 97);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(117, 55);
            this.btexit.TabIndex = 98;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = false;
            // 
            // loadingbar
            // 
            this.loadingbar.Location = new System.Drawing.Point(0, 80);
            this.loadingbar.Name = "loadingbar";
            this.loadingbar.Size = new System.Drawing.Size(473, 10);
            this.loadingbar.TabIndex = 99;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.loadingbar);
            this.groupBox1.Location = new System.Drawing.Point(7, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 90);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(159, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loading...";
            // 
            // frLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 159);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btstart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frLoading";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frLoading";
            this.Load += new System.EventHandler(this.frLoading_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.ProgressBar loadingbar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}