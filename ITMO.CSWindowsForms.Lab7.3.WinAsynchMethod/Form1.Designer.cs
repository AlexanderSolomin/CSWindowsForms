
namespace ITMO.CSWindowsForms.Lab6._3.WinAsynchMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRun = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txbA = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            resources.ApplyResources(this.btnRun, "btnRun");
            this.helpProvider1.SetHelpKeyword(this.btnRun, resources.GetString("btnRun.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.btnRun, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("btnRun.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.btnRun, resources.GetString("btnRun.HelpString"));
            this.btnRun.Name = "btnRun";
            this.helpProvider1.SetShowHelp(this.btnRun, ((bool)(resources.GetObject("btnRun.ShowHelp"))));
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnWork
            // 
            resources.ApplyResources(this.btnWork, "btnWork");
            this.helpProvider1.SetHelpKeyword(this.btnWork, resources.GetString("btnWork.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.btnWork, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("btnWork.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.btnWork, resources.GetString("btnWork.HelpString"));
            this.btnWork.Name = "btnWork";
            this.helpProvider1.SetShowHelp(this.btnWork, ((bool)(resources.GetObject("btnWork.ShowHelp"))));
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // lblA
            // 
            resources.ApplyResources(this.lblA, "lblA");
            this.helpProvider1.SetHelpKeyword(this.lblA, resources.GetString("lblA.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.lblA, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("lblA.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.lblA, resources.GetString("lblA.HelpString"));
            this.lblA.Name = "lblA";
            this.helpProvider1.SetShowHelp(this.lblA, ((bool)(resources.GetObject("lblA.ShowHelp"))));
            // 
            // lblB
            // 
            resources.ApplyResources(this.lblB, "lblB");
            this.helpProvider1.SetHelpKeyword(this.lblB, resources.GetString("lblB.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.lblB, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("lblB.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.lblB, resources.GetString("lblB.HelpString"));
            this.lblB.Name = "lblB";
            this.helpProvider1.SetShowHelp(this.lblB, ((bool)(resources.GetObject("lblB.ShowHelp"))));
            // 
            // txbA
            // 
            resources.ApplyResources(this.txbA, "txbA");
            this.helpProvider1.SetHelpKeyword(this.txbA, resources.GetString("txbA.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.txbA, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txbA.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.txbA, resources.GetString("txbA.HelpString"));
            this.txbA.Name = "txbA";
            this.helpProvider1.SetShowHelp(this.txbA, ((bool)(resources.GetObject("txbA.ShowHelp"))));
            // 
            // txbB
            // 
            resources.ApplyResources(this.txbB, "txbB");
            this.helpProvider1.SetHelpKeyword(this.txbB, resources.GetString("txbB.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.txbB, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("txbB.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.txbB, resources.GetString("txbB.HelpString"));
            this.txbB.Name = "txbB";
            this.helpProvider1.SetShowHelp(this.txbB, ((bool)(resources.GetObject("txbB.ShowHelp"))));
            // 
            // lblResult
            // 
            resources.ApplyResources(this.lblResult, "lblResult");
            this.helpProvider1.SetHelpKeyword(this.lblResult, resources.GetString("lblResult.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.lblResult, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("lblResult.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.lblResult, resources.GetString("lblResult.HelpString"));
            this.lblResult.Name = "lblResult";
            this.helpProvider1.SetShowHelp(this.lblResult, ((bool)(resources.GetObject("lblResult.ShowHelp"))));
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.helpProvider1.SetHelpKeyword(this.button1, resources.GetString("button1.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this.button1, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("button1.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this.button1, resources.GetString("button1.HelpString"));
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, ((bool)(resources.GetObject("button1.ShowHelp"))));
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // helpProvider1
            // 
            resources.ApplyResources(this.helpProvider1, "helpProvider1");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.txbA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, resources.GetString("$this.HelpKeyword"));
            this.helpProvider1.SetHelpNavigator(this, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("$this.HelpNavigator"))));
            this.helpProvider1.SetHelpString(this, resources.GetString("$this.HelpString"));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.helpProvider1.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txbA;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

