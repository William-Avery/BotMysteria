namespace MysteriaBot
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
            this.b_run = new System.Windows.Forms.Button();
            this.b_Up = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_run
            // 
            this.b_run.Location = new System.Drawing.Point(48, 65);
            this.b_run.Name = "b_run";
            this.b_run.Size = new System.Drawing.Size(75, 23);
            this.b_run.TabIndex = 0;
            this.b_run.Text = "Run";
            this.b_run.UseVisualStyleBackColor = true;
            this.b_run.Click += new System.EventHandler(this.b_run_Click);
            // 
            // b_Up
            // 
            this.b_Up.Location = new System.Drawing.Point(111, 149);
            this.b_Up.Name = "b_Up";
            this.b_Up.Size = new System.Drawing.Size(75, 23);
            this.b_Up.TabIndex = 1;
            this.b_Up.Text = "Up";
            this.b_Up.UseVisualStyleBackColor = true;
            this.b_Up.Click += new System.EventHandler(this.b_Up_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 287);
            this.Controls.Add(this.b_Up);
            this.Controls.Add(this.b_run);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_run;
        private System.Windows.Forms.Button b_Up;
    }
}

