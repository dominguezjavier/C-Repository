namespace Create_Digital_Clock_Showing_Date
{
    partial class clock
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
            this.hourMinuteLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.weekDayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hourMinuteLabel
            // 
            this.hourMinuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourMinuteLabel.ForeColor = System.Drawing.Color.White;
            this.hourMinuteLabel.Location = new System.Drawing.Point(247, 59);
            this.hourMinuteLabel.Name = "hourMinuteLabel";
            this.hourMinuteLabel.Size = new System.Drawing.Size(250, 75);
            this.hourMinuteLabel.TabIndex = 0;
            this.hourMinuteLabel.Text = "11 : 05";
            // 
            // secondsLabel
            // 
            this.secondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.ForeColor = System.Drawing.Color.White;
            this.secondsLabel.Location = new System.Drawing.Point(503, 59);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(108, 75);
            this.secondsLabel.TabIndex = 1;
            this.secondsLabel.Text = "47";
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(247, 165);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(622, 75);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "November 13 2019";
            // 
            // weekDayLabel
            // 
            this.weekDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekDayLabel.ForeColor = System.Drawing.Color.White;
            this.weekDayLabel.Location = new System.Drawing.Point(247, 265);
            this.weekDayLabel.Name = "weekDayLabel";
            this.weekDayLabel.Size = new System.Drawing.Size(622, 75);
            this.weekDayLabel.TabIndex = 3;
            this.weekDayLabel.Text = "Wedenesday";
            // 
            // clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(926, 522);
            this.Controls.Add(this.weekDayLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.hourMinuteLabel);
            this.MaximizeBox = false;
            this.Name = "clock";
            this.Text = "Digital Clock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hourMinuteLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label weekDayLabel;
    }
}

