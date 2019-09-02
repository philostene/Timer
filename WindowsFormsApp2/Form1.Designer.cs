namespace WindowsFormsApp2
{
    partial class TimerApp
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
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.titre_Heure = new System.Windows.Forms.Label();
            this.heure = new System.Windows.Forms.Label();
            this.nbreIteration = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tempsEcoule = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(106, 138);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(85, 47);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Démarrer";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Timer";
            // 
            // titre_Heure
            // 
            this.titre_Heure.AutoSize = true;
            this.titre_Heure.Location = new System.Drawing.Point(41, 209);
            this.titre_Heure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titre_Heure.Name = "titre_Heure";
            this.titre_Heure.Size = new System.Drawing.Size(47, 17);
            this.titre_Heure.TabIndex = 3;
            this.titre_Heure.Text = "Heure";
            // 
            // heure
            // 
            this.heure.AutoSize = true;
            this.heure.Location = new System.Drawing.Point(63, 236);
            this.heure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heure.Name = "heure";
            this.heure.Size = new System.Drawing.Size(47, 17);
            this.heure.TabIndex = 4;
            this.heure.Text = "Heure";
            // 
            // nbreIteration
            // 
            this.nbreIteration.AutoSize = true;
            this.nbreIteration.Location = new System.Drawing.Point(444, 236);
            this.nbreIteration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nbreIteration.Name = "nbreIteration";
            this.nbreIteration.Size = new System.Drawing.Size(113, 17);
            this.nbreIteration.TabIndex = 5;
            this.nbreIteration.Text = "Nombre Itération";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre Itération\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 209);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Temps Ecoulé";
            // 
            // tempsEcoule
            // 
            this.tempsEcoule.AutoSize = true;
            this.tempsEcoule.Location = new System.Drawing.Point(248, 236);
            this.tempsEcoule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempsEcoule.Name = "tempsEcoule";
            this.tempsEcoule.Size = new System.Drawing.Size(97, 17);
            this.tempsEcoule.TabIndex = 8;
            this.tempsEcoule.Text = "Temps ecoulé";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(447, 137);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(92, 48);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Pause";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(103, 288);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(45, 17);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "Statut";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(106, 356);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(433, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // progressBar
            // 
            this.progressBar.AutoSize = true;
            this.progressBar.Location = new System.Drawing.Point(234, 326);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(123, 17);
            this.progressBar.TabIndex = 14;
            this.progressBar.Text = "Barre Progression";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Démarrer";
            // 
            // TimerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(620, 414);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.tempsEcoule);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nbreIteration);
            this.Controls.Add(this.heure);
            this.Controls.Add(this.titre_Heure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimerApp";
            this.Text = "Timer Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TimerApp_FormClosed);
            this.Load += new System.EventHandler(this.TimerApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titre_Heure;
        private System.Windows.Forms.Label heure;
        private System.Windows.Forms.Label nbreIteration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tempsEcoule;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progressBar;
        private System.Windows.Forms.Label label1;
    }
}

