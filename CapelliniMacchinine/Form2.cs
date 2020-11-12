using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapelliniMacchinine
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int arrivo;
        Random rnd = new Random();
        bool b;
        private void btnStart2_Click(object sender, EventArgs e)
        {
            arrivo = rnd.Next(pictureBox1.Height-150, pictureBox1.Height);
            b = false;

            MessageBox.Show("Traguardo fissato " + arrivo.ToString());
            bgwBabbo.RunWorkerAsync(picbBabbo);
            bgwSacco.RunWorkerAsync(picbSacco);

            Refresh();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Cyan, 4f);
            Graphics g = e.Graphics;
            g.DrawLine(p, 0, arrivo, pictureBox1.Width, arrivo);
        }

        private void btnRivincita2_Click(object sender, EventArgs e)
        {
            picbBabbo.Location = new Point(picbBabbo.Location.X, pictureBox1.Location.Y);
            picbSacco.Location = new Point(picbSacco.Location.X, pictureBox1.Location.Y);

            btnStart2_Click(sender, e);
        }

        private void btnSwitch2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.Show();
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
            } while (pb.Location.Y < arrivo && b == false);
            b = true;
            e.Result = (pb);
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PictureBox pb = e.UserState as PictureBox;

            pb.Location = new Point(pb.Location.X , pb.Location.Y+ rnd.Next(0, 30));
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PictureBox pb = (PictureBox)e.Result;

            if (pb == picbBabbo && pb.Location.Y >= arrivo)
                MessageBox.Show("Babbo Natale ha vinto");

            if (pb == picbSacco && pb.Location.Y >= arrivo)
                MessageBox.Show("I regali hanno vinto");
            
        }
    }
}
