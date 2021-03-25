namespace IOReadViewWinForms
{
    partial class IOSatus
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
            this.lbIO_Status = new System.Windows.Forms.Label();
            this.tbIO_Status = new System.Windows.Forms.TextBox();
            this.bStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIO_Status
            // 
            this.lbIO_Status.AutoSize = true;
            this.lbIO_Status.Location = new System.Drawing.Point(73, 59);
            this.lbIO_Status.Name = "lbIO_Status";
            this.lbIO_Status.Size = new System.Drawing.Size(46, 17);
            this.lbIO_Status.TabIndex = 0;
            this.lbIO_Status.Text = "label1";
            // 
            // tbIO_Status
            // 
            this.tbIO_Status.Location = new System.Drawing.Point(286, 59);
            this.tbIO_Status.Name = "tbIO_Status";
            this.tbIO_Status.Size = new System.Drawing.Size(100, 22);
            this.tbIO_Status.TabIndex = 1;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(64, 134);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "button1";
            this.bStart.UseVisualStyleBackColor = true;
            // 
            // IOSatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.tbIO_Status);
            this.Controls.Add(this.lbIO_Status);
            this.Name = "IOSatus";
            this.Text = "IOSatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIO_Status;
        private System.Windows.Forms.TextBox tbIO_Status;
        private System.Windows.Forms.Button bStart;
    }
}

