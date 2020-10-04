using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LikeDislikeCounter
{
    public partial class Form1 : Form
    {
        public float TotalLikes = 0;
        public float TotalDislikes = 0;




        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddLikes(1);
        }


        public void AddLikes(float Val)
        {
            TotalLikes += Val;
            progressBar1.Value = (int)((TotalLikes / (TotalLikes + TotalDislikes)) * 100);
            label1.Text = TotalLikes.ToString("N") + " Likes";
        }

        public void AddDisLikes(float Val)
        {
            TotalDislikes += Val;
            progressBar1.Value = (int)((TotalLikes / (TotalLikes + TotalDislikes)) * 100);
            label2.Text = TotalDislikes.ToString("N") + " DisLikes";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddLikes(10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddLikes(50);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddDisLikes(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddDisLikes(10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDisLikes(50);
            if (DisLiker.Enabled == false)
                DisLiker.Enabled = true;
        }

        private void Liker_Tick(object sender, EventArgs e)
        {
            AddLikes(1);
        }

        private void DisLiker_Tick(object sender, EventArgs e)
        {
            AddDisLikes(10);
        }
    }
}
