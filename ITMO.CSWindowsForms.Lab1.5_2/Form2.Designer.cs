
namespace ITMO.CSWindowsForms.Lab1._5_2
{
    partial class Form2
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
            this.CmdForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdForm1
            // 
            this.CmdForm1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmdForm1.Location = new System.Drawing.Point(76, 126);
            this.CmdForm1.Name = "CmdForm1";
            this.CmdForm1.Size = new System.Drawing.Size(100, 23);
            this.CmdForm1.TabIndex = 0;
            this.CmdForm1.Text = "greenpeace?";
            this.CmdForm1.UseVisualStyleBackColor = true;
            this.CmdForm1.Click += new System.EventHandler(this.CmdForm1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdForm1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "greenpeace";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdForm1;
    }
}