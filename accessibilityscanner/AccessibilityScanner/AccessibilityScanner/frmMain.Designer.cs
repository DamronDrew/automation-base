using System;
using System.Windows.Forms;

namespace AccessibilityScanner
{
    partial class frmMain
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
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.wbrMain = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblElementType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblElementID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClasses = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblXpath = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flpAttributes = new System.Windows.Forms.FlowLayoutPanel();
            this.hoverTimer = new System.Windows.Forms.Timer(this.components);
            this.lblHoverTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcMain
            // 
            this.spcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spcMain.Location = new System.Drawing.Point(0, 0);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.panel2);
            this.spcMain.Panel1.Controls.Add(this.panel1);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.lblHoverTime);
            this.spcMain.Panel2.Controls.Add(this.groupBox2);
            this.spcMain.Panel2.Controls.Add(this.groupBox1);
            this.spcMain.Size = new System.Drawing.Size(1482, 753);
            this.spcMain.SplitterDistance = 724;
            this.spcMain.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(4, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 710);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.wbrMain);
            this.panel3.Location = new System.Drawing.Point(8, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(707, 694);
            this.panel3.TabIndex = 0;
            // 
            // wbrMain
            // 
            this.wbrMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbrMain.Location = new System.Drawing.Point(0, 0);
            this.wbrMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrMain.Name = "wbrMain";
            this.wbrMain.Size = new System.Drawing.Size(707, 694);
            this.wbrMain.TabIndex = 0;
            this.wbrMain.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbrMain_DocumentCompleted);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.txtURL);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 41);
            this.panel1.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.BackColor = System.Drawing.SystemColors.Window;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGo.Location = new System.Drawing.Point(634, 10);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(73, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(1, 9);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(627, 22);
            this.txtURL.TabIndex = 0;
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyDown);
            // 
            // lblElementType
            // 
            this.lblElementType.AutoSize = true;
            this.lblElementType.Location = new System.Drawing.Point(133, 58);
            this.lblElementType.Name = "lblElementType";
            this.lblElementType.Size = new System.Drawing.Size(105, 17);
            this.lblElementType.TabIndex = 3;
            this.lblElementType.Text = "lblElementType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Element Type:";
            // 
            // lblElementID
            // 
            this.lblElementID.AutoSize = true;
            this.lblElementID.Location = new System.Drawing.Point(133, 36);
            this.lblElementID.Name = "lblElementID";
            this.lblElementID.Size = new System.Drawing.Size(86, 17);
            this.lblElementID.TabIndex = 1;
            this.lblElementID.Text = "lblElementID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ElementID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Element Classes:";
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Location = new System.Drawing.Point(133, 79);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(71, 17);
            this.lblClasses.TabIndex = 5;
            this.lblClasses.Text = "lblClasses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "XPath:";
            // 
            // lblXpath
            // 
            this.lblXpath.AutoSize = true;
            this.lblXpath.Location = new System.Drawing.Point(133, 101);
            this.lblXpath.Name = "lblXpath";
            this.lblXpath.Size = new System.Drawing.Size(59, 17);
            this.lblXpath.TabIndex = 7;
            this.lblXpath.Text = "lblXpath";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblXpath);
            this.groupBox1.Controls.Add(this.lblElementID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblClasses);
            this.groupBox1.Controls.Add(this.lblElementType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(5, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flpAttributes);
            this.groupBox2.Location = new System.Drawing.Point(5, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 190);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attributes";
            // 
            // flpAttributes
            // 
            this.flpAttributes.AutoScroll = true;
            this.flpAttributes.Location = new System.Drawing.Point(7, 23);
            this.flpAttributes.Name = "flpAttributes";
            this.flpAttributes.Size = new System.Drawing.Size(390, 161);
            this.flpAttributes.TabIndex = 0;
            // 
            // hoverTimer
            // 
            this.hoverTimer.Interval = 1000;
            this.hoverTimer.Tick += new System.EventHandler(this.hoverTimer_Tick);
            // 
            // lblHoverTime
            // 
            this.lblHoverTime.AutoSize = true;
            this.lblHoverTime.Location = new System.Drawing.Point(19, 413);
            this.lblHoverTime.Name = "lblHoverTime";
            this.lblHoverTime.Size = new System.Drawing.Size(91, 17);
            this.lblHoverTime.TabIndex = 10;
            this.lblHoverTime.Text = "lblHoverTime";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.spcMain);
            this.Name = "frmMain";
            this.Text = "Accessibility Scanner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            this.spcMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.WebBrowser wbrMain;
        private Label lblElementID;
        private Label label1;
        private Label lblElementType;
        private Label label3;
        private Label lblClasses;
        private Label label2;
        private Label lblXpath;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private FlowLayoutPanel flpAttributes;
        private Timer hoverTimer;
        private Label lblHoverTime;
    }
}   