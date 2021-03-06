﻿using Calculator;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimpleCalculator
{
    /// <summary>
    /// Summary description for CalcUI.
    /// </summary>
    public class CalcUI : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox VersionInfo;
        private System.Windows.Forms.Button KeyExit;
        private System.Windows.Forms.Button KeyDate;
        private System.Windows.Forms.TextBox OutputDisplay;
        private System.Windows.Forms.Button KeyClear;
        private System.Windows.Forms.Button KeyMinus;
        private System.Windows.Forms.Button KeyPlus;
        private System.Windows.Forms.Button KeyEqual;
        private System.Windows.Forms.Button KeyMultiply;
        private System.Windows.Forms.Button KeyDivide;
        private System.Windows.Forms.Button KeyPoint;
        private System.Windows.Forms.Button KeySign;
        private System.Windows.Forms.Button KeyZero;
        private System.Windows.Forms.Button KeyNine;
        private System.Windows.Forms.Button KeyEight;
        private System.Windows.Forms.Button KeySeven;
        private System.Windows.Forms.Button KeySix;
        private System.Windows.Forms.Button KeyFive;
        private System.Windows.Forms.Button KeyFour;
        private System.Windows.Forms.Button KeyThree;
        private System.Windows.Forms.Button KeyTwo;
        private System.Windows.Forms.Button KeyOne;

        // Output Display Constants.
        private const string oneOut = "1";
        private const string twoOut = "2";
        private const string threeOut = "3";
        private const string fourOut = "4";
        private const string fiveOut = "5";
        private const string sixOut = "6";
        private const string sevenOut = "7";
        private const string eightOut = "8";
        private const string nineOut = "9";
        private const string zeroOut = "0";
        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem simpleToolStripMenuItem;
        private ToolStripMenuItem advancedToolStripMenuItem;
        private ToolStripMenuItem fontColorToolStripMenuItem;
        private ToolStripMenuItem backgroudColorToolStripMenuItem;
        private Panel mainPanel;
        private Panel advancedPanel;
        private Button KeyFact;
        private Button KeySq;
        private Button KeyRec;
        private Button KeySqr;
        private Button KeyPow;
        private ColorDialog colorDialog1;
        private Button KeyCbrt;
        private ProgressBar progressBar1;
        private Button KeyQuad;
        private ToolTip toolTip1;
        private IContainer components;

        public CalcUI()
        {
            //
            // Required for Windows Form Designer support
            //

            InitializeComponent();

            //
            // Get version information from the Calculator Module.
            //

            VersionInfo.Text = "";//CalcEngine.GetVersion();
            OutputDisplay.Text = "0";
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.KeyDate = new System.Windows.Forms.Button();
            this.KeyOne = new System.Windows.Forms.Button();
            this.VersionInfo = new System.Windows.Forms.TextBox();
            this.KeySix = new System.Windows.Forms.Button();
            this.KeyFive = new System.Windows.Forms.Button();
            this.KeyEqual = new System.Windows.Forms.Button();
            this.KeyTwo = new System.Windows.Forms.Button();
            this.KeyZero = new System.Windows.Forms.Button();
            this.KeyThree = new System.Windows.Forms.Button();
            this.KeyPlus = new System.Windows.Forms.Button();
            this.KeyExit = new System.Windows.Forms.Button();
            this.KeySign = new System.Windows.Forms.Button();
            this.KeySeven = new System.Windows.Forms.Button();
            this.KeyPoint = new System.Windows.Forms.Button();
            this.KeyNine = new System.Windows.Forms.Button();
            this.OutputDisplay = new System.Windows.Forms.TextBox();
            this.KeyMinus = new System.Windows.Forms.Button();
            this.KeyEight = new System.Windows.Forms.Button();
            this.KeyMultiply = new System.Windows.Forms.Button();
            this.KeyFour = new System.Windows.Forms.Button();
            this.KeyClear = new System.Windows.Forms.Button();
            this.KeyDivide = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroudColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.advancedPanel = new System.Windows.Forms.Panel();
            this.KeyQuad = new System.Windows.Forms.Button();
            this.KeyCbrt = new System.Windows.Forms.Button();
            this.KeyFact = new System.Windows.Forms.Button();
            this.KeySq = new System.Windows.Forms.Button();
            this.KeyRec = new System.Windows.Forms.Button();
            this.KeySqr = new System.Windows.Forms.Button();
            this.KeyPow = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.advancedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyDate
            // 
            this.KeyDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyDate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDate.ForeColor = System.Drawing.Color.Blue;
            this.KeyDate.Location = new System.Drawing.Point(195, 51);
            this.KeyDate.Name = "KeyDate";
            this.KeyDate.Size = new System.Drawing.Size(56, 40);
            this.KeyDate.TabIndex = 19;
            this.KeyDate.TabStop = false;
            this.KeyDate.Text = "Date";
            this.KeyDate.Click += new System.EventHandler(this.KeyDate_Click);
            // 
            // KeyOne
            // 
            this.KeyOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyOne.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyOne.ForeColor = System.Drawing.Color.Blue;
            this.KeyOne.Location = new System.Drawing.Point(3, 99);
            this.KeyOne.Name = "KeyOne";
            this.KeyOne.Size = new System.Drawing.Size(40, 40);
            this.KeyOne.TabIndex = 2;
            this.KeyOne.TabStop = false;
            this.KeyOne.Text = "1";
            this.KeyOne.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // VersionInfo
            // 
            this.VersionInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VersionInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VersionInfo.Cursor = System.Windows.Forms.Cursors.No;
            this.VersionInfo.Font = new System.Drawing.Font("Verdana", 8F);
            this.VersionInfo.Location = new System.Drawing.Point(5, 35);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.ReadOnly = true;
            this.VersionInfo.Size = new System.Drawing.Size(254, 20);
            this.VersionInfo.TabIndex = 0;
            this.VersionInfo.TabStop = false;
            this.VersionInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeySix
            // 
            this.KeySix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeySix.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySix.ForeColor = System.Drawing.Color.Blue;
            this.KeySix.Location = new System.Drawing.Point(99, 51);
            this.KeySix.Name = "KeySix";
            this.KeySix.Size = new System.Drawing.Size(40, 40);
            this.KeySix.TabIndex = 7;
            this.KeySix.TabStop = false;
            this.KeySix.Text = "6";
            this.KeySix.Click += new System.EventHandler(this.KeySix_Click);
            // 
            // KeyFive
            // 
            this.KeyFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyFive.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFive.ForeColor = System.Drawing.Color.Blue;
            this.KeyFive.Location = new System.Drawing.Point(51, 51);
            this.KeyFive.Name = "KeyFive";
            this.KeyFive.Size = new System.Drawing.Size(40, 40);
            this.KeyFive.TabIndex = 6;
            this.KeyFive.TabStop = false;
            this.KeyFive.Text = "5";
            this.KeyFive.Click += new System.EventHandler(this.KeyFive_Click);
            // 
            // KeyEqual
            // 
            this.KeyEqual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyEqual.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEqual.ForeColor = System.Drawing.Color.Red;
            this.KeyEqual.Location = new System.Drawing.Point(195, 147);
            this.KeyEqual.Name = "KeyEqual";
            this.KeyEqual.Size = new System.Drawing.Size(56, 40);
            this.KeyEqual.TabIndex = 18;
            this.KeyEqual.TabStop = false;
            this.KeyEqual.Text = "=";
            this.KeyEqual.Click += new System.EventHandler(this.KeyEqual_Click);
            // 
            // KeyTwo
            // 
            this.KeyTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyTwo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyTwo.ForeColor = System.Drawing.Color.Blue;
            this.KeyTwo.Location = new System.Drawing.Point(51, 99);
            this.KeyTwo.Name = "KeyTwo";
            this.KeyTwo.Size = new System.Drawing.Size(40, 40);
            this.KeyTwo.TabIndex = 3;
            this.KeyTwo.TabStop = false;
            this.KeyTwo.Text = "2";
            this.KeyTwo.Click += new System.EventHandler(this.KeyTwo_Click);
            // 
            // KeyZero
            // 
            this.KeyZero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyZero.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyZero.ForeColor = System.Drawing.Color.Blue;
            this.KeyZero.Location = new System.Drawing.Point(3, 147);
            this.KeyZero.Name = "KeyZero";
            this.KeyZero.Size = new System.Drawing.Size(40, 40);
            this.KeyZero.TabIndex = 11;
            this.KeyZero.TabStop = false;
            this.KeyZero.Text = "0";
            this.KeyZero.Click += new System.EventHandler(this.KeyZero_Click);
            // 
            // KeyThree
            // 
            this.KeyThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyThree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyThree.ForeColor = System.Drawing.Color.Blue;
            this.KeyThree.Location = new System.Drawing.Point(99, 99);
            this.KeyThree.Name = "KeyThree";
            this.KeyThree.Size = new System.Drawing.Size(40, 40);
            this.KeyThree.TabIndex = 4;
            this.KeyThree.TabStop = false;
            this.KeyThree.Text = "3";
            this.KeyThree.Click += new System.EventHandler(this.KeyThree_Click);
            // 
            // KeyPlus
            // 
            this.KeyPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyPlus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPlus.ForeColor = System.Drawing.Color.Red;
            this.KeyPlus.Location = new System.Drawing.Point(147, 147);
            this.KeyPlus.Name = "KeyPlus";
            this.KeyPlus.Size = new System.Drawing.Size(40, 40);
            this.KeyPlus.TabIndex = 12;
            this.KeyPlus.TabStop = false;
            this.KeyPlus.Text = "+";
            this.toolTip1.SetToolTip(this.KeyPlus, "Сложение");
            this.KeyPlus.Click += new System.EventHandler(this.KeyPlus_Click);
            // 
            // KeyExit
            // 
            this.KeyExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyExit.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyExit.ForeColor = System.Drawing.Color.Red;
            this.KeyExit.Location = new System.Drawing.Point(195, 99);
            this.KeyExit.Name = "KeyExit";
            this.KeyExit.Size = new System.Drawing.Size(56, 40);
            this.KeyExit.TabIndex = 21;
            this.KeyExit.TabStop = false;
            this.KeyExit.Text = "Exit";
            this.KeyExit.Click += new System.EventHandler(this.KeyExit_Click);
            // 
            // KeySign
            // 
            this.KeySign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeySign.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.KeySign.ForeColor = System.Drawing.Color.Blue;
            this.KeySign.Location = new System.Drawing.Point(99, 147);
            this.KeySign.Name = "KeySign";
            this.KeySign.Size = new System.Drawing.Size(40, 40);
            this.KeySign.TabIndex = 16;
            this.KeySign.TabStop = false;
            this.KeySign.Text = "+/-";
            this.KeySign.Click += new System.EventHandler(this.KeySign_Click);
            // 
            // KeySeven
            // 
            this.KeySeven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeySeven.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySeven.ForeColor = System.Drawing.Color.Blue;
            this.KeySeven.Location = new System.Drawing.Point(3, 3);
            this.KeySeven.Name = "KeySeven";
            this.KeySeven.Size = new System.Drawing.Size(40, 40);
            this.KeySeven.TabIndex = 8;
            this.KeySeven.TabStop = false;
            this.KeySeven.Text = "7";
            this.KeySeven.Click += new System.EventHandler(this.KeySeven_Click);
            // 
            // KeyPoint
            // 
            this.KeyPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyPoint.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPoint.ForeColor = System.Drawing.Color.Blue;
            this.KeyPoint.Location = new System.Drawing.Point(51, 147);
            this.KeyPoint.Name = "KeyPoint";
            this.KeyPoint.Size = new System.Drawing.Size(40, 40);
            this.KeyPoint.TabIndex = 17;
            this.KeyPoint.TabStop = false;
            this.KeyPoint.Text = ".";
            this.KeyPoint.Click += new System.EventHandler(this.KeyPoint_Click);
            // 
            // KeyNine
            // 
            this.KeyNine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyNine.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyNine.ForeColor = System.Drawing.Color.Blue;
            this.KeyNine.Location = new System.Drawing.Point(99, 3);
            this.KeyNine.Name = "KeyNine";
            this.KeyNine.Size = new System.Drawing.Size(40, 40);
            this.KeyNine.TabIndex = 10;
            this.KeyNine.TabStop = false;
            this.KeyNine.Text = "9";
            this.KeyNine.Click += new System.EventHandler(this.KeyNine_Click);
            // 
            // OutputDisplay
            // 
            this.OutputDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OutputDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OutputDisplay.Cursor = System.Windows.Forms.Cursors.No;
            this.OutputDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.OutputDisplay.Location = new System.Drawing.Point(5, 61);
            this.OutputDisplay.Name = "OutputDisplay";
            this.OutputDisplay.ReadOnly = true;
            this.OutputDisplay.Size = new System.Drawing.Size(254, 26);
            this.OutputDisplay.TabIndex = 1;
            this.OutputDisplay.TabStop = false;
            this.OutputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OutputDisplay.TextChanged += new System.EventHandler(this.OutputDisplay_TextChanged);
            // 
            // KeyMinus
            // 
            this.KeyMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyMinus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMinus.ForeColor = System.Drawing.Color.Red;
            this.KeyMinus.Location = new System.Drawing.Point(147, 99);
            this.KeyMinus.Name = "KeyMinus";
            this.KeyMinus.Size = new System.Drawing.Size(40, 40);
            this.KeyMinus.TabIndex = 13;
            this.KeyMinus.TabStop = false;
            this.KeyMinus.Text = "-";
            this.toolTip1.SetToolTip(this.KeyMinus, "Вычитание");
            this.KeyMinus.Click += new System.EventHandler(this.KeyMinus_Click);
            // 
            // KeyEight
            // 
            this.KeyEight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyEight.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEight.ForeColor = System.Drawing.Color.Blue;
            this.KeyEight.Location = new System.Drawing.Point(51, 3);
            this.KeyEight.Name = "KeyEight";
            this.KeyEight.Size = new System.Drawing.Size(40, 40);
            this.KeyEight.TabIndex = 9;
            this.KeyEight.TabStop = false;
            this.KeyEight.Text = "8";
            this.KeyEight.Click += new System.EventHandler(this.KeyEight_Click);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyMultiply.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMultiply.ForeColor = System.Drawing.Color.Red;
            this.KeyMultiply.Location = new System.Drawing.Point(147, 51);
            this.KeyMultiply.Name = "KeyMultiply";
            this.KeyMultiply.Size = new System.Drawing.Size(40, 40);
            this.KeyMultiply.TabIndex = 14;
            this.KeyMultiply.TabStop = false;
            this.KeyMultiply.Text = "*";
            this.toolTip1.SetToolTip(this.KeyMultiply, "Умножение");
            this.KeyMultiply.Click += new System.EventHandler(this.KeyMultiply_Click);
            // 
            // KeyFour
            // 
            this.KeyFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyFour.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFour.ForeColor = System.Drawing.Color.Blue;
            this.KeyFour.Location = new System.Drawing.Point(3, 51);
            this.KeyFour.Name = "KeyFour";
            this.KeyFour.Size = new System.Drawing.Size(40, 40);
            this.KeyFour.TabIndex = 5;
            this.KeyFour.TabStop = false;
            this.KeyFour.Text = "4";
            this.KeyFour.Click += new System.EventHandler(this.KeyFour_Click);
            // 
            // KeyClear
            // 
            this.KeyClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyClear.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyClear.ForeColor = System.Drawing.Color.Red;
            this.KeyClear.Location = new System.Drawing.Point(195, 3);
            this.KeyClear.Name = "KeyClear";
            this.KeyClear.Size = new System.Drawing.Size(56, 40);
            this.KeyClear.TabIndex = 20;
            this.KeyClear.TabStop = false;
            this.KeyClear.Text = "C";
            this.KeyClear.Click += new System.EventHandler(this.KeyClear_Click);
            // 
            // KeyDivide
            // 
            this.KeyDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyDivide.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDivide.ForeColor = System.Drawing.Color.Red;
            this.KeyDivide.Location = new System.Drawing.Point(147, 3);
            this.KeyDivide.Name = "KeyDivide";
            this.KeyDivide.Size = new System.Drawing.Size(40, 40);
            this.KeyDivide.TabIndex = 15;
            this.KeyDivide.TabStop = false;
            this.KeyDivide.Text = "/";
            this.toolTip1.SetToolTip(this.KeyDivide, "Деление");
            this.KeyDivide.Click += new System.EventHandler(this.KeyDivide_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(265, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleToolStripMenuItem,
            this.advancedToolStripMenuItem,
            this.fontColorToolStripMenuItem,
            this.backgroudColorToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.viewToolStripMenuItem.Text = "&Вид";
            // 
            // simpleToolStripMenuItem
            // 
            this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
            this.simpleToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.simpleToolStripMenuItem.Text = "О&бычный";
            this.simpleToolStripMenuItem.Click += new System.EventHandler(this.SimpleToolStripMenuItem_Click);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.advancedToolStripMenuItem.Text = "&Алгебраический";
            this.advancedToolStripMenuItem.Click += new System.EventHandler(this.AdvancedToolStripMenuItem_Click);
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.fontColorToolStripMenuItem.Text = "&Цвет шрифта";
            this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.FontColorToolStripMenuItem_Click);
            // 
            // backgroudColorToolStripMenuItem
            // 
            this.backgroudColorToolStripMenuItem.Name = "backgroudColorToolStripMenuItem";
            this.backgroudColorToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.backgroudColorToolStripMenuItem.Text = "Цвет ф&она";
            this.backgroudColorToolStripMenuItem.Click += new System.EventHandler(this.BackgroudColorToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mainPanel.Controls.Add(this.KeySeven);
            this.mainPanel.Controls.Add(this.KeyOne);
            this.mainPanel.Controls.Add(this.KeyExit);
            this.mainPanel.Controls.Add(this.KeyTwo);
            this.mainPanel.Controls.Add(this.KeyClear);
            this.mainPanel.Controls.Add(this.KeyThree);
            this.mainPanel.Controls.Add(this.KeyDate);
            this.mainPanel.Controls.Add(this.KeyFour);
            this.mainPanel.Controls.Add(this.KeyEqual);
            this.mainPanel.Controls.Add(this.KeyFive);
            this.mainPanel.Controls.Add(this.KeyPoint);
            this.mainPanel.Controls.Add(this.KeySix);
            this.mainPanel.Controls.Add(this.KeySign);
            this.mainPanel.Controls.Add(this.KeyDivide);
            this.mainPanel.Controls.Add(this.KeyEight);
            this.mainPanel.Controls.Add(this.KeyMultiply);
            this.mainPanel.Controls.Add(this.KeyNine);
            this.mainPanel.Controls.Add(this.KeyMinus);
            this.mainPanel.Controls.Add(this.KeyZero);
            this.mainPanel.Controls.Add(this.KeyPlus);
            this.mainPanel.Location = new System.Drawing.Point(5, 96);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(254, 190);
            this.mainPanel.TabIndex = 23;
            // 
            // advancedPanel
            // 
            this.advancedPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.advancedPanel.Controls.Add(this.KeyQuad);
            this.advancedPanel.Controls.Add(this.KeyCbrt);
            this.advancedPanel.Controls.Add(this.KeyFact);
            this.advancedPanel.Controls.Add(this.KeySq);
            this.advancedPanel.Controls.Add(this.KeyRec);
            this.advancedPanel.Controls.Add(this.KeySqr);
            this.advancedPanel.Controls.Add(this.KeyPow);
            this.advancedPanel.Location = new System.Drawing.Point(5, 96);
            this.advancedPanel.Name = "advancedPanel";
            this.advancedPanel.Size = new System.Drawing.Size(254, 91);
            this.advancedPanel.TabIndex = 24;
            this.advancedPanel.Visible = false;
            // 
            // KeyQuad
            // 
            this.KeyQuad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyQuad.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyQuad.ForeColor = System.Drawing.Color.SeaGreen;
            this.KeyQuad.Location = new System.Drawing.Point(195, 5);
            this.KeyQuad.Name = "KeyQuad";
            this.KeyQuad.Size = new System.Drawing.Size(56, 83);
            this.KeyQuad.TabIndex = 22;
            this.KeyQuad.TabStop = false;
            this.KeyQuad.Text = "Quad Eq";
            this.toolTip1.SetToolTip(this.KeyQuad, "Квадратное уравнение");
            this.KeyQuad.Click += new System.EventHandler(this.KeyQuad_Click);
            // 
            // KeyCbrt
            // 
            this.KeyCbrt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyCbrt.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyCbrt.ForeColor = System.Drawing.Color.DarkMagenta;
            this.KeyCbrt.Location = new System.Drawing.Point(3, 48);
            this.KeyCbrt.Name = "KeyCbrt";
            this.KeyCbrt.Size = new System.Drawing.Size(40, 40);
            this.KeyCbrt.TabIndex = 21;
            this.KeyCbrt.TabStop = false;
            this.KeyCbrt.Text = "Cbr";
            this.toolTip1.SetToolTip(this.KeyCbrt, "Кубический корень");
            this.KeyCbrt.Click += new System.EventHandler(this.KeyCbrt_Click);
            // 
            // KeyFact
            // 
            this.KeyFact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyFact.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFact.ForeColor = System.Drawing.Color.DarkGreen;
            this.KeyFact.Location = new System.Drawing.Point(99, 5);
            this.KeyFact.Name = "KeyFact";
            this.KeyFact.Size = new System.Drawing.Size(88, 40);
            this.KeyFact.TabIndex = 20;
            this.KeyFact.TabStop = false;
            this.KeyFact.Text = "Fact";
            this.toolTip1.SetToolTip(this.KeyFact, "Факториал");
            this.KeyFact.Click += new System.EventHandler(this.KeyFact_ClickAsync);
            // 
            // KeySq
            // 
            this.KeySq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeySq.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySq.ForeColor = System.Drawing.Color.DarkMagenta;
            this.KeySq.Location = new System.Drawing.Point(99, 48);
            this.KeySq.Name = "KeySq";
            this.KeySq.Size = new System.Drawing.Size(40, 40);
            this.KeySq.TabIndex = 12;
            this.KeySq.TabStop = false;
            this.KeySq.Text = "x^2";
            this.toolTip1.SetToolTip(this.KeySq, "Квадрат числа");
            this.KeySq.Click += new System.EventHandler(this.KeySq_Click);
            // 
            // KeyRec
            // 
            this.KeyRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyRec.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyRec.ForeColor = System.Drawing.Color.DarkMagenta;
            this.KeyRec.Location = new System.Drawing.Point(51, 48);
            this.KeyRec.Name = "KeyRec";
            this.KeyRec.Size = new System.Drawing.Size(40, 40);
            this.KeyRec.TabIndex = 11;
            this.KeyRec.TabStop = false;
            this.KeyRec.Text = "1/x";
            this.toolTip1.SetToolTip(this.KeyRec, "Обратное число");
            this.KeyRec.Click += new System.EventHandler(this.KeyRec_Click);
            // 
            // KeySqr
            // 
            this.KeySqr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeySqr.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySqr.ForeColor = System.Drawing.Color.DarkMagenta;
            this.KeySqr.Location = new System.Drawing.Point(3, 5);
            this.KeySqr.Name = "KeySqr";
            this.KeySqr.Size = new System.Drawing.Size(88, 40);
            this.KeySqr.TabIndex = 10;
            this.KeySqr.TabStop = false;
            this.KeySqr.Text = "Sqrt";
            this.toolTip1.SetToolTip(this.KeySqr, "Квадратный корень");
            this.KeySqr.Click += new System.EventHandler(this.KeySqr_Click);
            // 
            // KeyPow
            // 
            this.KeyPow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyPow.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPow.ForeColor = System.Drawing.Color.DarkMagenta;
            this.KeyPow.Location = new System.Drawing.Point(147, 48);
            this.KeyPow.Name = "KeyPow";
            this.KeyPow.Size = new System.Drawing.Size(40, 40);
            this.KeyPow.TabIndex = 9;
            this.KeyPow.TabStop = false;
            this.KeyPow.Text = "Pow";
            this.toolTip1.SetToolTip(this.KeyPow, "Возведение в степень");
            this.KeyPow.Click += new System.EventHandler(this.KeyPow_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 56);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(254, 5);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 22;
            // 
            // CalcUI
            // 
            this.AcceptButton = this.KeyEqual;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(265, 290);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.advancedPanel);
            this.Controls.Add(this.OutputDisplay);
            this.Controls.Add(this.VersionInfo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CalcUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.advancedPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        protected void KeyPlus_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eAdd);
        }

        protected void KeyMinus_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSubtract);
        }

        protected void KeyMultiply_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply);
        }

        protected void KeyDivide_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDivide);
        }

        private void KeyPow_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.ePow);
        }
        private void KeyQuad_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcReset();
            InputDialog inp = new InputDialog();
            if (inp.ShowDialog() != DialogResult.OK)
                return;
            VersionInfo.Text = QuadEq.Gg(inp.A, inp.B, inp.C);
        }

        //
        // Other non-numeric key click methods.
        //

        protected void KeySign_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSign();
        }

        protected void KeyPoint_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcDecimal();
        }

        protected void KeyDate_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.GetDate();
            CalcEngine.CalcReset();
        }

        protected void KeyClear_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcReset();
            OutputDisplay.Text = "0";
            VersionInfo.Text = "";
        }

        private void KeySqr_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSqrt();
            CalcEngine.CalcReset();
        }

        private void KeySq_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSq();
            CalcEngine.CalcReset();
        }

        private void KeyRec_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcRec();
            CalcEngine.CalcReset();
        }

        private void KeyCbrt_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcCbrt();
            CalcEngine.CalcReset();
        }

        //
        // Perform the calculation.
        //

        protected void KeyEqual_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcEqual();
            CalcEngine.CalcReset();
        }

        //
        // Numeric key click methods.
        //

        protected void KeyNine_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(nineOut);
        }

        protected void KeyEight_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(eightOut);
        }

        protected void KeySeven_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sevenOut);
        }

        protected void KeySix_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sixOut);
        }

        protected void KeyFive_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fiveOut);
        }

        protected void KeyFour_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fourOut);
        }

        protected void KeyThree_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(threeOut);
        }

        protected void KeyTwo_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(twoOut);
        }

        protected void KeyOne_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(oneOut);
        }

        protected void KeyZero_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(zeroOut);
        }

        //
        // End the program.
        //

        protected void KeyExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            Application.Run(new CalcUI());
        }

        private void AdvancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Height = 375 + 45;
            this.advancedPanel.Visible = true;
        }

        private void SimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.advancedPanel.Visible = false;
            this.Height = 329;
        }

        private void FontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                OutputDisplay.ForeColor = colorDialog1.Color;
            }
        }

        private void BackgroudColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        ///
        /// Background Factorial
        /// 



        private async void KeyFact_ClickAsync(object sender, EventArgs e)
        {
            VersionInfo.Text = "Значение факториала: " + await CalcEngine.CalcFactAsync();
            CalcEngine.CalcReset();

            //progressBar1.Value = 0;
            //BackgroundWorker worker = new BackgroundWorker();
            //worker.WorkerReportsProgress = true;
            //worker.DoWork += Worker_DoWork;
            //worker.ProgressChanged += Worker_ProgressChanged;
            //worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            //worker.RunWorkerAsync();
        }

        //void Worker_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    e.Result = CalcEngine.CalcFact();
        //    CalcEngine.CalcReset();
        //    int max = 100;
        //    for (int i = 0; i <= max; i++)
        //    {
        //        int progressPercentage = Convert.ToInt32(((double)i / max) * 100);
        //        (sender as BackgroundWorker).ReportProgress(progressPercentage, i);
        //        System.Threading.Thread.Sleep(1);
        //    }
        //}

        //void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    VersionInfo.Text = $"Завершено: {e.ProgressPercentage}%";
        //    progressBar1.Value = e.ProgressPercentage;
        //}

        //void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    if (e.Result.ToString() != "0")
        //        VersionInfo.Text = $"Значение факториала: {e.Result}";
        //    else
        //        VersionInfo.Text = $"Факториал вне допустимых значений";
        //}

        private void OutputDisplay_TextChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            VersionInfo.Text = "";
        }

    }
}
