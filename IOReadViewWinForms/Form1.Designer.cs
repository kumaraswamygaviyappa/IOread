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
            this.btInput1 = new System.Windows.Forms.Button();
            this.TrBaInput = new System.Windows.Forms.TrackBar();
            this.tbTrBaInput = new System.Windows.Forms.TextBox();
            this.btInput2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrBaInput)).BeginInit();
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
            // btInput1
            // 
            this.btInput1.BackColor = System.Drawing.Color.Red;
            this.btInput1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btInput1.Location = new System.Drawing.Point(198, 141);
            this.btInput1.Name = "btInput1";
            this.btInput1.Size = new System.Drawing.Size(86, 27);
            this.btInput1.TabIndex = 5;
            this.btInput1.Text = "Input";
            this.btInput1.UseVisualStyleBackColor = false;
            this.btInput1.Click += new System.EventHandler(this.btInput_Click);
            // 
            // TrBaInput
            // 
            this.TrBaInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TrBaInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrBaInput.Location = new System.Drawing.Point(64, 190);
            this.TrBaInput.Maximum = 100;
            this.TrBaInput.Minimum = -100;
            this.TrBaInput.Name = "TrBaInput";
            this.TrBaInput.Size = new System.Drawing.Size(169, 56);
            this.TrBaInput.TabIndex = 6;
            this.TrBaInput.Scroll += new System.EventHandler(this.TrBaInput_Scroll);
            // 
            // tbTrBaInput
            // 
            this.tbTrBaInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbTrBaInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTrBaInput.Location = new System.Drawing.Point(337, 224);
            this.tbTrBaInput.Name = "tbTrBaInput";
            this.tbTrBaInput.ReadOnly = true;
            this.tbTrBaInput.Size = new System.Drawing.Size(100, 22);
            this.tbTrBaInput.TabIndex = 7;
            this.tbTrBaInput.Text = "Input Bar";
            this.tbTrBaInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btInput2
            // 
            this.btInput2.BackColor = System.Drawing.Color.Red;
            this.btInput2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btInput2.Location = new System.Drawing.Point(316, 141);
            this.btInput2.Name = "btInput2";
            this.btInput2.Size = new System.Drawing.Size(86, 27);
            this.btInput2.TabIndex = 8;
            this.btInput2.Text = "Input2";
            this.btInput2.UseVisualStyleBackColor = false;
            this.btInput2.Click += new System.EventHandler(this.btInput_Click);
            // 
            // IOSatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btInput2);
            this.Controls.Add(this.tbTrBaInput);
            this.Controls.Add(this.TrBaInput);
            this.Controls.Add(this.btInput1);
            this.Controls.Add(this.cbinput);
            this.Controls.Add(this.lboutput);
            this.Controls.Add(this.tbIO_Status);
            this.Controls.Add(this.lbIO_Status);
            this.Name = "IOSatus";
            this.Text = "IOSatus";
            ((System.ComponentModel.ISupportInitialize)(this.TrBaInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIO_Status;
        private System.Windows.Forms.TextBox tbIO_Status;
        private System.Windows.Forms.Label lboutput;
        private System.Windows.Forms.ComboBox cbinput;
        private System.Windows.Forms.Button btInput1;
        private System.Windows.Forms.TrackBar TrBaInput;
        private System.Windows.Forms.TextBox tbTrBaInput;
        private System.Windows.Forms.Button btInput2;
    }
}

