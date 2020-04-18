﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Nadhemni_2020
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_form a = new Main_form();
            a.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Close();
            Main_form a = new Main_form();
            a.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            information_famille a = new information_famille();
            a.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (o.ShowDialog()==DialogResult.OK)
            {
                String img = o.FileName.ToString();
                pictureBox3.ImageLocation = img;
            }



        }
    }
}
