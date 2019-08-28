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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public int counter;

        public bool IsCanceled { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "En cours";
            counter = counter +1;
            label4.Text= DateTime.Now.ToString("dd/mm/yy HH:mm");
            Loop();
         //   Thread thread = new Thread(this.Loop);
         //   thread.Start();
        }

        private void Loop()
        {
            double Indice = 0;
            IsCanceled = false;
           
                label4.Text = DateTime.Now.ToString("dd/MM/yy HH:mm");
                label4.Refresh();
                label5.Text = Indice.ToString();
                label5.Refresh();
             //   toto2 = DateTime.Now - toto1; 
             //   label8.Text = toto2.ToString(@"hh\:mm\:ss");
                label8.Refresh();

                Thread _thread = new Thread(loopThread);
                _thread.Start();
                Indice = Indice + 1;       
        }

         private void loopThread()
         {
            DateTime toto = new DateTime();
            DateTime toto1 = new DateTime();
            TimeSpan toto2 = new TimeSpan();
            toto1 = DateTime.Now;
            toto = DateTime.Now;
            toto = toto.AddHours(3);
            while (toto > DateTime.Now && IsCanceled == false)

            {
                Thread.Sleep(100000);
                SendKeys.SendWait("{DOWN}");
            }
        }
      
        

        private void button2_Click(object sender, EventArgs e)
        {
            // label5.Text = "En pause";
            //  label4.Text = DateTime.Now.ToString("dd/mm/yy HH:mm");
            IsCanceled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("exit?", "exit", MessageBoxButtons.YesNo);
            if (dialog ==DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                IsCanceled = true;
            }
        }
    }
}
