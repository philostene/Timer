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
    public partial class TimerApp : Form
    {
        public int counter;

        private BackgroundWorker worker;
        private System.Windows.Forms.Timer timer1;
        private DateTime heureDebut;
        private TimeSpan heureIntervalle;
        public TimerApp()
        {
            InitializeComponent();
            heureDebut = DateTime.Now;
            heure.Text = heureDebut.ToString("dd/MM/yy HH:mm");
            nbreIteration.Text = "";
            tempsEcoule.Text = "";
            //Configurarion timer events 
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            //Timer configuration
            timer1 = new System.Windows.Forms.Timer();
           // timer1.Enabled = true;
           // timer1.Start();
            timer1.Interval = 1000; //
            timer1.Tick += new EventHandler(Timer1_Tick);
        }

        private void TimerApp_Load(object sender, EventArgs e)
        {

        }

        private void TimerApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //Change the status of the buttons on the UI accordingly
            //The start button is disabled as soon as the background operation is started
            //The Cancel button is enabled so that the user can stop the operation 
            //at any point of time during the execution
            startButton.Enabled = false;
            cancelButton.Enabled = true;
            timer1.Start();

            // Kickoff the worker thread to begin it's DoWork function.
            worker.RunWorkerAsync();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (worker.IsBusy)
            {
                // Notify the worker thread that a cancel has been requested.
                // The cancel will not actually happen until the thread in the
                // DoWork checks the m_oWorker.CancellationPending flag. 
                timer1.Stop();
                worker.CancelAsync();
            }
        }
            // <summary>
            // On completed do the appropriate task
            // </summary>
            // <param name="sender"></param>
            // <param name="e"></param>
            void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // The background process is complete. We need to inspect
            // our response to see if an error occurred, a cancel was
            // requested or if we completed successfully.  
            if (e.Cancelled)
            {
                labelStatus.Text = "Task Cancelled.";
            }

            // Check to see if an error occurred in the background process.

            else if (e.Error != null)
            {
                labelStatus.Text = "Error while performing background operation.";
            }
            else
            {
                // Everything completed normally.
                labelStatus.Text = "Task Completed...";
            }
            //Change the status of the buttons on the UI accordingly
            startButton.Enabled = true;
            cancelButton.Enabled = false;
        }

        // <summary>
        // Notification is performed here to the progress bar
        // </summary>
        // <param name="sender"></param>
        // <param name="e"></param>
        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // This function fires on the UI thread so it's safe to edit
            // the UI control directly, no funny business with Control.Invoke :)
            // Update the progressBar with the integer supplied to us from the
            // ReportProgress() function.  

            heureIntervalle = DateTime.Now - heureDebut;
            double  toto = heureIntervalle.TotalHours;
            tempsEcoule.Text = heureIntervalle.ToString();
            nbreIteration.Text = e.ProgressPercentage.ToString();
          //  progressBar1.Value = progressBar1.Value + 1;
            labelStatus.Text = "Processing......" + "%";
        }

        // <summary>
        // Time consuming operations go here </br>
        // i.e. Database operations,Reporting
        // </summary>
        // <param name="sender"></param>
        // <param name="e"></param>
        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int indice = 0;              
         //   DateTime heureDebutIteration = new DateTime();
         //   heureDebutIteration = DateTime.Now;
         //   heureDebutIteration = heureDebutIteration.AddHours(3);
            worker.ReportProgress(indice);
            e.Cancel = false;

            while (!e.Cancel)                //heureDebutIteration > DateTime.Now
            {      
                    Thread.Sleep(1000); //100000
                    SendKeys.SendWait("{DOWN}");
                    indice = indice + 1;
                    worker.ReportProgress(indice);
                    if (worker.CancellationPending)
                    {
                        // Set the e.Cancel flag so that the WorkerCompleted event
                        // knows that the process was cancelled.
                        e.Cancel = true;
                        worker.ReportProgress(0);
                        return;
                    }
            }           

            // The sender is the BackgroundWorker object we need it to
            // report progress and check for cancellation.
            //NOTE : Never play with the UI thread here...

            // Periodically report progress to the main thread so that it can
            // update the UI.  In most cases you'll just need to send an
            // integer that will update a ProgressBar                    
                
            // Periodically check if a cancellation request is pending.
            // If the user clicks cancel the line
            // m_AsyncWorker.CancelAsync(); if ran above.  This
            // sets the CancellationPending to true.
            // You must check this flag in here and react to it.
            // We react to it by setting e.Cancel to true and leaving
                
            //Report 100% completion on operation completed
            worker.ReportProgress(100);
        }

        void Timer1_Tick(object Sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
          
        }
    }
}
