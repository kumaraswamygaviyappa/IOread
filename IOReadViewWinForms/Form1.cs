﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IORead;

namespace IOReadViewWinForms
{
    public partial class IOSatus : Form
    {

        bool bInputButton = false;
        bool IO_g_ReadIO = false;

        public IOSatus()
        {
            InitializeComponent();
            //this.bStart.Click += new EventHandler(ButtonOk_Click);
            Timer t = new Timer() { Interval = 250 };
            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            var IOData = Entry.IOReadPlc.MAIN.MainReadIO;
            
            Entry.IOReadPlc.IO.g_ReadIO.Cyclic = bool.Parse(this.cbinput.Text);
            Entry.IOReadPlc.IO.g_ReadIO.Cyclic = IO_g_ReadIO;
            this.lbIO_Status.Text = IOData.st_ReadIO.AttributeName;
            this.tbIO_Status.Text = IOData.st_ReadIO.Cyclic.ToString();

            this.tbIO_Status.Text = Entry.IOReadPlc.IO.g_ReadIO.Cyclic.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbIO_Status_Click(object sender, EventArgs e)
        {

        }

        private void btInput_Click(object sender, EventArgs e)
        {
            if(bInputButton)
            {
                bInputButton = false;
                btInput.BackColor = Color.Red;
                IO_g_ReadIO = false;
                lboutput.ForeColor = Color.Red;
            }
            else
            {
                bInputButton = true;
                btInput.BackColor = Color.Green;
                IO_g_ReadIO = true;
                lboutput.ForeColor = Color.Green;
            }
        }

        //void ButtonOk_Click(object sender, EventArgs e)
        //{
        //    //MessageBox.Show("clicked");
        //    Timer t = new Timer() { Interval = 250 };
        //    t.Tick += T_Tick;
        //    t.Start();
        //}
    }    
}
