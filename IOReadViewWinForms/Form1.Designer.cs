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
            this.lboutput = new System.Windows.Forms.Label();
            this.cbinput = new System.Windows.Forms.ComboBox();
            this.btInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIO_Status
            // 
            this.lbIO_Status.AutoSize = true;
            this.lbIO_Status.Location = new System.Drawing.Point(108, 75);
            this.lbIO_Status.Name = "lbIO_Status";
            this.lbIO_Status.Size = new System.Drawing.Size(39, 17);
            this.lbIO_Status.TabIndex = 0;
            this.lbIO_Status.Text = "Input";
            this.lbIO_Status.Click += new System.EventHandler(this.lbIO_Status_Click);
            // 
            // tbIO_Status
            // 
            this.tbIO_Status.Location = new System.Drawing.Point(532, 77);
            this.tbIO_Status.Name = "tbIO_Status";
            this.tbIO_Status.Size = new System.Drawing.Size(100, 22);
            this.tbIO_Status.TabIndex = 1;
            // 
            // lboutput
            // 
            this.lboutput.AutoSize = true;
            this.lboutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboutput.ForeColor = System.Drawing.Color.Red;
            this.lboutput.Location = new System.Drawing.Point(443, 77);
            this.lboutput.Name = "lboutput";
            this.lboutput.Size = new System.Drawing.Size(58, 18);
            this.lboutput.TabIndex = 3;
            this.lboutput.Text = "Output";
            this.lboutput.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbinput
            // 
            this.cbinput.AutoCompleteCustomSource.AddRange(new string[] {
            "True",
            "False"});
            this.cbinput.FormattingEnabled = true;
            this.cbinput.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbinput.Location = new System.Drawing.Point(198, 75);
            this.cbinput.Name = "cbinput";
            this.cbinput.Size = new System.Drawing.Size(121, 24);
            this.cbinput.TabIndex = 4;
            this.cbinput.Text = "False";
            // 
            // btInput
            // 
            this.btInput.BackColor = System.Drawing.Color.Red;
            this.btInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btInput.Location = new System.Drawing.Point(198, 141);
            this.btInput.Name = "btInput";
            this.btInput.Size = new System.Drawing.Size(86, 27);
            this.btInput.TabIndex = 5;
            this.btInput.Text = "Input";
            this.btInput.UseVisualStyleBackColor = false;
            this.btInput.Click += new System.EventHandler(this.btInput_Click);
            // 
            // IOSatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btInput);
            this.Controls.Add(this.cbinput);
            this.Controls.Add(this.lboutput);
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
        private System.Windows.Forms.Label lboutput;
        private System.Windows.Forms.ComboBox cbinput;
        private System.Windows.Forms.Button btInput;
    }
}

