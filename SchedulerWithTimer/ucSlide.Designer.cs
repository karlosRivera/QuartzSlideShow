namespace SchedulerWithTimer
{
    partial class ucSlide
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picSlide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // picSlide
            // 
            this.picSlide.BackColor = System.Drawing.Color.White;
            this.picSlide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSlide.Location = new System.Drawing.Point(0, 0);
            this.picSlide.Name = "picSlide";
            this.picSlide.Size = new System.Drawing.Size(301, 222);
            this.picSlide.TabIndex = 0;
            this.picSlide.TabStop = false;
            // 
            // ucSlide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picSlide);
            this.Name = "ucSlide";
            this.Size = new System.Drawing.Size(301, 222);
            ((System.ComponentModel.ISupportInitialize)(this.picSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSlide;
    }
}
