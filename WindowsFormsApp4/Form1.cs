using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int time = 0, com;
        Random rd = new Random();

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(msktext.Text) >= 3)
            {
                MessageBox.Show("請重新輸入", "錯誤");
                return;
            }
            msktext.Enabled = false;
            btnstart.Enabled = false;
            timer1.Enabled = true;
            lbltime.Visible = true;
        }

        private void msktext_TextChanged(object sender, EventArgs e)
        {
            if (msktext.Text == "0")
                picboxplayer.Image = imageList1.Images[0];
            else if (msktext.Text == "1")
                picboxplayer.Image = imageList1.Images[1];
            else if (msktext.Text == "2")
                picboxplayer.Image = imageList1.Images[2];
            else if(msktext.Text=="")
                picboxplayer.Image = null;
            else
            {
                picboxplayer.Image = null;
                MessageBox.Show("請重新輸入", "錯誤");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += timer1.Interval;
            com = rd.Next(0, 3);
            picboxcom.Image = imageList1.Images[com];
            lbltime.Text = (time / 1000).ToString();
            if (time == 5000)
            {
                timer1.Enabled = false;
                btnstart.Enabled = true;
                msktext.Enabled = true;
                time = 0;
                if (Int32.Parse(msktext.Text) == 0 && com == 2)
                    lbltime.Text="玩家勝利";
                else if (Int32.Parse(msktext.Text) == 2 && com == 0)
                    lbltime.Text = "電腦勝利";
                else if (Int32.Parse(msktext.Text) > com)
                    lbltime.Text = "玩家勝利";
                else if (Int32.Parse(msktext.Text) == com)
                    lbltime.Text = "平手";
                else
                    lbltime.Text = "電腦勝利";
            }
        }
    }
}
