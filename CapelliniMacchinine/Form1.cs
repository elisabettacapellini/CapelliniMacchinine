using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapelliniMacchinine
{
    public partial class Form1 :  Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int arrivo;
        bool b;

        private void btnStart_Click(object sender, EventArgs e)
        {
            arrivo = rnd.Next(pictureBox1.Width / 2, pictureBox1.Width);
            b = false;

            MessageBox.Show("Traguardo fissato "+arrivo.ToString());
            bckwBlackCar.RunWorkerAsync(picbBlackCar);
            bckwRedCar.RunWorkerAsync(picbRedCar);
            
            Refresh();
        }



        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Cyan, 4f);
            Graphics g = e.Graphics;
            g.DrawLine(p,arrivo, 0, arrivo, pictureBox1.Height - 1);
        }
        
        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            PictureBox pb = (PictureBox)e.Argument;
            
            int i = 0;
            do
            {
                i++;
                Thread.Sleep(100);
                bw.ReportProgress(i, pb);
            } while (pb.Location.X < arrivo && b==false);
            b = true;
            e.Result = (pb);
           

        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PictureBox pb = e.UserState as PictureBox;

            pb.Location = new Point(pb.Location.X + rnd.Next(0, 30), pb.Location.Y);
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PictureBox pb = (PictureBox)e.Result;
            
            if (pb == picbBlackCar && pb.Location.X >= arrivo) 
                MessageBox.Show("La macchina nera ha vinto");
            
            if (pb == picbRedCar && pb.Location.X >= arrivo)
                MessageBox.Show("La macchina rossa ha vinto");
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Hide();
            f2.Show();
        }

        private void btnRivincita_Click(object sender, EventArgs e)
        {
            picbBlackCar.Location = new Point(pictureBox1.Location.X, picbBlackCar.Location.Y);
            picbRedCar.Location = new Point(pictureBox1.Location.X, picbRedCar.Location.Y);

            btnStart_Click(sender, e);
        }
    }
}
