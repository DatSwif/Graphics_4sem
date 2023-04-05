
namespace Lab2_Recursion
{
    partial class Lab2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab2Form));
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.SignatureLabel = new System.Windows.Forms.Label();
            this.TriangleButton = new System.Windows.Forms.Button();
            this.SquareButton = new System.Windows.Forms.Button();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.HeadIcon = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DepthChanger = new System.Windows.Forms.NumericUpDown();
            this.BackgroundPanel.SuspendLayout();
            this.HeadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeadIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthChanger)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackgroundPanel.Controls.Add(this.DepthChanger);
            this.BackgroundPanel.Controls.Add(this.SignatureLabel);
            this.BackgroundPanel.Controls.Add(this.TriangleButton);
            this.BackgroundPanel.Controls.Add(this.SquareButton);
            this.BackgroundPanel.Controls.Add(this.DrawingPanel);
            this.BackgroundPanel.ForeColor = System.Drawing.Color.DarkGray;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(866, 553);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // SignatureLabel
            // 
            this.SignatureLabel.AutoSize = true;
            this.SignatureLabel.Location = new System.Drawing.Point(13, 38);
            this.SignatureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignatureLabel.Name = "SignatureLabel";
            this.SignatureLabel.Size = new System.Drawing.Size(270, 17);
            this.SignatureLabel.TabIndex = 3;
            this.SignatureLabel.Text = "Виконав студент ІП-12 Євгеній Тарасюк";
            // 
            // TriangleButton
            // 
            this.TriangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TriangleButton.Location = new System.Drawing.Point(464, 510);
            this.TriangleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(185, 28);
            this.TriangleButton.TabIndex = 2;
            this.TriangleButton.Text = "Трик. Серпинського";
            this.TriangleButton.UseVisualStyleBackColor = true;
            this.TriangleButton.Click += new System.EventHandler(this.TriangleButton_Click);
            // 
            // SquareButton
            // 
            this.SquareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SquareButton.Location = new System.Drawing.Point(216, 510);
            this.SquareButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(185, 28);
            this.SquareButton.TabIndex = 1;
            this.SquareButton.Text = "Рекурсивний квадрат";
            this.SquareButton.UseVisualStyleBackColor = true;
            this.SquareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BackColor = System.Drawing.Color.Black;
            this.DrawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingPanel.Location = new System.Drawing.Point(100, 68);
            this.DrawingPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(666, 418);
            this.DrawingPanel.TabIndex = 0;
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.HeadPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeadPanel.Controls.Add(this.TitleLabel);
            this.HeadPanel.Controls.Add(this.HeadIcon);
            this.HeadPanel.Controls.Add(this.MinimizeButton);
            this.HeadPanel.Controls.Add(this.CloseButton);
            this.HeadPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(866, 35);
            this.HeadPanel.TabIndex = 0;
            this.HeadPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadPanel_MouseDown);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleLabel.Location = new System.Drawing.Point(47, 10);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(40, 17);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Lab2";
            // 
            // HeadIcon
            // 
            this.HeadIcon.Image = ((System.Drawing.Image)(resources.GetObject("HeadIcon.Image")));
            this.HeadIcon.Location = new System.Drawing.Point(-1, -1);
            this.HeadIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HeadIcon.Name = "HeadIcon";
            this.HeadIcon.Size = new System.Drawing.Size(40, 36);
            this.HeadIcon.TabIndex = 0;
            this.HeadIcon.TabStop = false;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.Gray;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.Location = new System.Drawing.Point(765, -1);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(51, 36);
            this.MinimizeButton.TabIndex = 0;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.UseMnemonic = false;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.Gray;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(815, -1);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(51, 36);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.TabStop = false;
            this.CloseButton.UseMnemonic = false;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DepthChanger
            // 
            this.DepthChanger.Location = new System.Drawing.Point(685, 510);
            this.DepthChanger.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.DepthChanger.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DepthChanger.Name = "DepthChanger";
            this.DepthChanger.Size = new System.Drawing.Size(120, 22);
            this.DepthChanger.TabIndex = 4;
            this.DepthChanger.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lab2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(867, 554);
            this.Controls.Add(this.HeadPanel);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Lab2Form";
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeadIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthChanger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox HeadIcon;
        private System.Windows.Forms.Label SignatureLabel;
        private System.Windows.Forms.Button TriangleButton;
        private System.Windows.Forms.Button SquareButton;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.NumericUpDown DepthChanger;
    }
}

