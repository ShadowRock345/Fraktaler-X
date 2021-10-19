
namespace Fraktaler_X
{
    partial class Fraktal_Auswählen
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Auswählen = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Mandelbrot"});
            this.listBox1.Location = new System.Drawing.Point(1, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(798, 407);
            this.listBox1.TabIndex = 0;
            this.listBox1.Tag = "fraktale";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Auswählen
            // 
            this.Auswählen.Location = new System.Drawing.Point(352, 415);
            this.Auswählen.Name = "Auswählen";
            this.Auswählen.Size = new System.Drawing.Size(75, 23);
            this.Auswählen.TabIndex = 1;
            this.Auswählen.Tag = "select";
            this.Auswählen.Text = "Auswählen";
            this.Auswählen.UseVisualStyleBackColor = true;
            this.Auswählen.Click += new System.EventHandler(this.Auswählen_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Fraktal_Auswählen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Auswählen);
            this.Controls.Add(this.listBox1);
            this.Name = "Fraktal_Auswählen";
            this.Text = "Fraktal_Auswählen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Auswählen;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}