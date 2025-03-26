namespace TimerForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.StartB = new System.Windows.Forms.Button();
            this.RestartB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PauseB = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Font = new System.Drawing.Font("Pixel Sport", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLbl.ForeColor = System.Drawing.Color.White;
            this.TimeLbl.Location = new System.Drawing.Point(80, 137);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(354, 141);
            this.TimeLbl.TabIndex = 0;
            this.TimeLbl.Text = "00:00:00";
            // 
            // StartB
            // 
            this.StartB.BackColor = System.Drawing.Color.White;
            this.StartB.Font = new System.Drawing.Font("Gome Pixel Rounded", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(109)))), ((int)(((byte)(107)))));
            this.StartB.Location = new System.Drawing.Point(171, 305);
            this.StartB.Name = "StartB";
            this.StartB.Size = new System.Drawing.Size(171, 70);
            this.StartB.TabIndex = 1;
            this.StartB.Text = "START";
            this.StartB.UseVisualStyleBackColor = false;
            this.StartB.Click += new System.EventHandler(this.StartB_Click);
            // 
            // RestartB
            // 
            this.RestartB.BackColor = System.Drawing.Color.White;
            this.RestartB.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.RestartB.FlatAppearance.BorderSize = 3;
            this.RestartB.Font = new System.Drawing.Font("Gome Pixel Rounded", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(109)))), ((int)(((byte)(107)))));
            this.RestartB.Location = new System.Drawing.Point(326, 392);
            this.RestartB.Name = "RestartB";
            this.RestartB.Size = new System.Drawing.Size(180, 69);
            this.RestartB.TabIndex = 2;
            this.RestartB.Text = "RESTART";
            this.RestartB.UseVisualStyleBackColor = false;
            this.RestartB.Click += new System.EventHandler(this.RestartB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gome Pixel Rounded", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(137, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Session";
            // 
            // PauseB
            // 
            this.PauseB.BackColor = System.Drawing.Color.White;
            this.PauseB.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.PauseB.FlatAppearance.BorderSize = 3;
            this.PauseB.Font = new System.Drawing.Font("Gome Pixel Rounded", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(109)))), ((int)(((byte)(107)))));
            this.PauseB.Location = new System.Drawing.Point(12, 392);
            this.PauseB.Name = "PauseB";
            this.PauseB.Size = new System.Drawing.Size(171, 69);
            this.PauseB.TabIndex = 4;
            this.PauseB.Text = "PAUSE";
            this.PauseB.UseVisualStyleBackColor = false;
            this.PauseB.Click += new System.EventHandler(this.PauseB_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(109)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(515, 519);
            this.Controls.Add(this.PauseB);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RestartB);
            this.Controls.Add(this.StartB);
            this.Name = "Form1";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Button StartB;
        private System.Windows.Forms.Button RestartB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PauseB;
        private System.Windows.Forms.Timer timer1;
    }
}

