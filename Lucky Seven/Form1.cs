﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky_Seven
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Spin_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rndm = new Random();
            int firstPic = rndm.Next(0, picsList.Images.Count - 1);
            int secondPic = rndm.Next(0, picsList.Images.Count - 1);
            int thirdPic = rndm.Next(0, picsList.Images.Count - 1);

            

            cnt++;
            picBox_firstPic.Image = picsList.Images[firstPic];
            picBox_secondPic.Image = picsList.Images[secondPic];
            picBox_thirdPic.Image = picsList.Images[thirdPic];
            if(cnt == 10)
            {
                timer1.Interval = 100;
            }
            if(cnt == 15)
            {
                timer1.Interval = 150;
            }
            if(cnt == 20)
            {
                timer1.Stop();
                cnt = 0;
                timer1.Interval = 50;
                if(firstPic == secondPic && secondPic == thirdPic)
                {
                    if(firstPic == 5)
                    {
                        score += 700;
                        txtboxScore.Text = score.ToString();
                    }
                    else
                    {
                        score += 350;
                        txtboxScore.Text = score.ToString();
                    }
                }
                else if(firstPic == secondPic || firstPic == thirdPic || secondPic == thirdPic)
                {
                    score += 200;
                    txtboxScore.Text = score.ToString();
                }

            }
            
        }

        
    }
}