
namespace ImageEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.circleButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 397);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.LocateCoordinates);
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(681, 415);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(107, 23);
            this.circleButton.TabIndex = 1;
            this.circleButton.Text = "Draw Circles";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dotButton
            // 
            this.dotButton.Location = new System.Drawing.Point(12, 415);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(75, 23);
            this.dotButton.TabIndex = 2;
            this.dotButton.Text = "Draw Dots";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(360, 415);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button clearButton;
    }
}

