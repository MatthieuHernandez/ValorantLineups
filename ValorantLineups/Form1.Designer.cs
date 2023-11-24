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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            LeftButton = new PictureBox();
            RightButton = new PictureBox();
            tabPage3 = new TabPage();
            PictureBox = new PictureBox();
            tabPage2 = new TabPage();
            SplitButton = new Button();
            FractureButton = new Button();
            AscentButton = new Button();
            BackButton = new PictureBox();
            HavenButtton = new Button();
            tabPage1 = new TabPage();
            OmenButton = new Button();
            KilljoyButton = new Button();
            TabControl = new TabControl();
            lineupList = new ImageList(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)LeftButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RightButton).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackButton).BeginInit();
            tabPage1.SuspendLayout();
            TabControl.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 561);
            panel1.TabIndex = 0;
            // 
            // LeftButton
            // 
            LeftButton.Anchor = AnchorStyles.Bottom;
            LeftButton.BackColor = Color.Transparent;
            LeftButton.Image = (Image)resources.GetObject("LeftButton.Image");
            LeftButton.Location = new Point(260, 424);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(100, 100);
            LeftButton.TabIndex = 2;
            LeftButton.TabStop = false;
            LeftButton.Click += LeftButton_Click;
            // 
            // RightButton
            // 
            RightButton.Anchor = AnchorStyles.Bottom;
            RightButton.BackColor = Color.Transparent;
            RightButton.Image = (Image)resources.GetObject("RightButton.Image");
            RightButton.Location = new Point(410, 424);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(100, 100);
            RightButton.TabIndex = 2;
            RightButton.TabStop = false;
            RightButton.Click += RightButton_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(RightButton);
            tabPage3.Controls.Add(LeftButton);
            tabPage3.Controls.Add(PictureBox);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(776, 533);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            // 
            // PictureBox
            // 
            PictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PictureBox.BackColor = Color.Black;
            PictureBox.Location = new Point(0, 0);
            PictureBox.Margin = new Padding(0);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(1920, 1080);
            PictureBox.TabIndex = 3;
            PictureBox.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ControlDark;
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(SplitButton);
            tabPage2.Controls.Add(FractureButton);
            tabPage2.Controls.Add(AscentButton);
            tabPage2.Controls.Add(BackButton);
            tabPage2.Controls.Add(HavenButtton);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(776, 533);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // SplitButton
            // 
            SplitButton.Font = new Font("Carlito", 28F, FontStyle.Bold, GraphicsUnit.Point);
            SplitButton.ForeColor = SystemColors.Control;
            SplitButton.Image = (Image)resources.GetObject("SplitButton.Image");
            SplitButton.Location = new Point(4, 124);
            SplitButton.Margin = new Padding(0);
            SplitButton.Name = "SplitButton";
            SplitButton.Size = new Size(202, 118);
            SplitButton.TabIndex = 4;
            SplitButton.Text = "SPLIT";
            SplitButton.UseVisualStyleBackColor = true;
            SplitButton.Click += SplitButton_Click;
            // 
            // FractureButton
            // 
            FractureButton.Font = new Font("Carlito", 28F, FontStyle.Bold, GraphicsUnit.Point);
            FractureButton.ForeColor = SystemColors.Control;
            FractureButton.Image = (Image)resources.GetObject("FractureButton.Image");
            FractureButton.Location = new Point(410, 4);
            FractureButton.Margin = new Padding(0);
            FractureButton.Name = "FractureButton";
            FractureButton.Size = new Size(202, 118);
            FractureButton.TabIndex = 3;
            FractureButton.Text = "FRACTURE";
            FractureButton.UseVisualStyleBackColor = true;
            FractureButton.Click += FractureButton_Click;
            // 
            // AscentButton
            // 
            AscentButton.Font = new Font("Carlito", 28F, FontStyle.Bold, GraphicsUnit.Point);
            AscentButton.ForeColor = SystemColors.Control;
            AscentButton.Image = (Image)resources.GetObject("AscentButton.Image");
            AscentButton.Location = new Point(208, 4);
            AscentButton.Margin = new Padding(0);
            AscentButton.Name = "AscentButton";
            AscentButton.Size = new Size(202, 118);
            AscentButton.TabIndex = 2;
            AscentButton.Text = "ASCENT";
            AscentButton.UseVisualStyleBackColor = true;
            AscentButton.Click += AscentButton_Click;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BackButton.BackColor = Color.Transparent;
            BackButton.Image = (Image)resources.GetObject("BackButton.Image");
            BackButton.Location = new Point(641, 398);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(138, 138);
            BackButton.TabIndex = 0;
            BackButton.TabStop = false;
            BackButton.Click += BackButton_Click;
            // 
            // HavenButtton
            // 
            HavenButtton.Font = new Font("Carlito", 28F, FontStyle.Bold, GraphicsUnit.Point);
            HavenButtton.ForeColor = SystemColors.Control;
            HavenButtton.Image = (Image)resources.GetObject("HavenButtton.Image");
            HavenButtton.Location = new Point(4, 4);
            HavenButtton.Margin = new Padding(0);
            HavenButtton.Name = "HavenButtton";
            HavenButtton.Size = new Size(202, 118);
            HavenButtton.TabIndex = 1;
            HavenButtton.Text = "HAVEN";
            HavenButtton.UseVisualStyleBackColor = true;
            HavenButtton.Click += HavenButton_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ControlDark;
            tabPage1.Controls.Add(OmenButton);
            tabPage1.Controls.Add(KilljoyButton);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(776, 533);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // OmenButton
            // 
            OmenButton.AccessibleRole = AccessibleRole.None;
            OmenButton.Image = (Image)resources.GetObject("OmenButton.Image");
            OmenButton.Location = new Point(220, 4);
            OmenButton.Name = "OmenButton";
            OmenButton.Size = new Size(210, 210);
            OmenButton.TabIndex = 2;
            OmenButton.UseVisualStyleBackColor = true;
            OmenButton.Click += OmenButton_Click;
            // 
            // KilljoyButton
            // 
            KilljoyButton.AccessibleRole = AccessibleRole.None;
            KilljoyButton.Image = (Image)resources.GetObject("KilljoyButton.Image");
            KilljoyButton.Location = new Point(4, 4);
            KilljoyButton.Name = "KilljoyButton";
            KilljoyButton.Size = new Size(210, 210);
            KilljoyButton.TabIndex = 1;
            KilljoyButton.UseVisualStyleBackColor = true;
            KilljoyButton.Click += KilljoyButton_Click;
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(tabPage1);
            TabControl.Controls.Add(tabPage2);
            TabControl.Controls.Add(tabPage3);
            TabControl.ItemSize = new Size(10, 20);
            TabControl.Location = new Point(0, 0);
            TabControl.Margin = new Padding(0);
            TabControl.Name = "TabControl";
            TabControl.Padding = new Point(0, 0);
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(784, 561);
            TabControl.TabIndex = 3;
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // lineupList
            // 
            lineupList.ColorDepth = ColorDepth.Depth32Bit;
            lineupList.ImageSize = new Size(256, 256);
            lineupList.TransparentColor = Color.Transparent;
            // 
            // button1
            // 
            button1.Font = new Font("Carlito", 28F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(208, 124);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(202, 118);
            button1.TabIndex = 5;
            button1.Text = "BIND";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BindButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(TabControl);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Valorant Lineups";
            ((System.ComponentModel.ISupportInitialize)LeftButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)RightButton).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BackButton).EndInit();
            tabPage1.ResumeLayout(false);
            TabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox RightButton;
        private PictureBox LeftButton;
        private PictureBox BackButton;
        private Button HavenButtton;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button KilljoyButton;
        private TabControl TabControl;
        private PictureBox PictureBox;
        private ImageList lineupList;
        private Button AscentButton;
        private Button FractureButton;
        private Button OmenButton;
        private Button SplitButton;
        private Button button1;
    }
}