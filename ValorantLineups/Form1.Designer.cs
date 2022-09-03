namespace ValorantLineups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.HavenButtton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.KilljoyButton = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 561);
            this.panel1.TabIndex = 0;
            // 
            // LeftButton
            // 
            this.LeftButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LeftButton.BackColor = System.Drawing.Color.Transparent;
            this.LeftButton.Image = ((System.Drawing.Image)(resources.GetObject("LeftButton.Image")));
            this.LeftButton.Location = new System.Drawing.Point(260, 424);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(110, 110);
            this.LeftButton.TabIndex = 2;
            this.LeftButton.UseVisualStyleBackColor = false;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RightButton.BackColor = System.Drawing.Color.Transparent;
            this.RightButton.Image = ((System.Drawing.Image)(resources.GetObject("RightButton.Image")));
            this.RightButton.Location = new System.Drawing.Point(410, 424);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(110, 110);
            this.RightButton.TabIndex = 2;
            this.RightButton.UseVisualStyleBackColor = false;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RightButton);
            this.tabPage3.Controls.Add(this.LeftButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(776, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.HavenButtton);
            this.tabPage2.Controls.Add(this.BackButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // HavenButtton
            // 
            this.HavenButtton.Font = new System.Drawing.Font("Carlito", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HavenButtton.ForeColor = System.Drawing.SystemColors.Control;
            this.HavenButtton.Image = ((System.Drawing.Image)(resources.GetObject("HavenButtton.Image")));
            this.HavenButtton.Location = new System.Drawing.Point(0, 0);
            this.HavenButtton.Margin = new System.Windows.Forms.Padding(0);
            this.HavenButtton.Name = "HavenButtton";
            this.HavenButtton.Size = new System.Drawing.Size(202, 118);
            this.HavenButtton.TabIndex = 1;
            this.HavenButtton.Text = "HAVEN";
            this.HavenButtton.UseVisualStyleBackColor = true;
            this.HavenButtton.Click += new System.EventHandler(this.HavenButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(638, 395);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(138, 138);
            this.BackButton.TabIndex = 0;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.KilljoyButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // KilljoyButton
            // 
            this.KilljoyButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.KilljoyButton.Image = ((System.Drawing.Image)(resources.GetObject("KilljoyButton.Image")));
            this.KilljoyButton.Location = new System.Drawing.Point(0, 6);
            this.KilljoyButton.Name = "KilljoyButton";
            this.KilljoyButton.Size = new System.Drawing.Size(210, 210);
            this.KilljoyButton.TabIndex = 1;
            this.KilljoyButton.UseVisualStyleBackColor = true;
            this.KilljoyButton.Click += new System.EventHandler(this.KilljoyButton_Click);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.ItemSize = new System.Drawing.Size(10, 20);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(0);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(0, 0);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(784, 561);
            this.TabControl.TabIndex = 3;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Valorant Lineups";
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button RightButton;
        private Button LeftButton;
        private Button HavenButtton;
        private Button BackButton;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button KilljoyButton;
        private TabControl TabControl;
    }
}