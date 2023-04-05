
namespace Lab1_Initialization
{
    partial class Lab1MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab1MainForm));
            this.LabNumberLabel = new System.Windows.Forms.Label();
            this.FramePanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.DrawButton = new System.Windows.Forms.Button();
            this.NameRow2 = new System.Windows.Forms.Label();
            this.NameRow1 = new System.Windows.Forms.Label();
            this.FramePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabNumberLabel
            // 
            this.LabNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.LabNumberLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.LabNumberLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LabNumberLabel.Location = new System.Drawing.Point(102, 55);
            this.LabNumberLabel.Name = "LabNumberLabel";
            this.LabNumberLabel.Size = new System.Drawing.Size(400, 39);
            this.LabNumberLabel.TabIndex = 0;
            this.LabNumberLabel.Text = "Лабораторна робота №1";
            this.LabNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FramePanel
            // 
            this.FramePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.FramePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FramePanel.Controls.Add(this.pictureBox);
            this.FramePanel.Controls.Add(this.Title);
            this.FramePanel.Controls.Add(this.MinimizeButton);
            this.FramePanel.Controls.Add(this.CloseButton);
            this.FramePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FramePanel.Location = new System.Drawing.Point(0, 0);
            this.FramePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FramePanel.Name = "FramePanel";
            this.FramePanel.Size = new System.Drawing.Size(600, 35);
            this.FramePanel.TabIndex = 1;
            this.FramePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FramePanel_MouseDown);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(3, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(36, 32);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Title.Location = new System.Drawing.Point(44, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(40, 17);
            this.Title.TabIndex = 3;
            this.Title.Text = "Lab1";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.Location = new System.Drawing.Point(500, -1);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(51, 36);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.Location = new System.Drawing.Point(549, -1);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(51, 36);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.TabStop = false;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.CausesValidation = false;
            this.MainPanel.Controls.Add(this.DrawingPanel);
            this.MainPanel.Controls.Add(this.DrawButton);
            this.MainPanel.Controls.Add(this.NameRow2);
            this.MainPanel.Controls.Add(this.NameRow1);
            this.MainPanel.Controls.Add(this.LabNumberLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(600, 400);
            this.MainPanel.TabIndex = 2;
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DrawingPanel.Location = new System.Drawing.Point(103, 214);
            this.DrawingPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(393, 86);
            this.DrawingPanel.TabIndex = 4;
            // 
            // DrawButton
            // 
            this.DrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawButton.ForeColor = System.Drawing.Color.DarkGray;
            this.DrawButton.Location = new System.Drawing.Point(15, 350);
            this.DrawButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(188, 34);
            this.DrawButton.TabIndex = 3;
            this.DrawButton.Text = "Намалювати прізвище";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // NameRow2
            // 
            this.NameRow2.AutoSize = true;
            this.NameRow2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameRow2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NameRow2.Location = new System.Drawing.Point(100, 148);
            this.NameRow2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameRow2.Name = "NameRow2";
            this.NameRow2.Size = new System.Drawing.Size(374, 34);
            this.NameRow2.TabIndex = 2;
            this.NameRow2.Text = "Тарасюк Євгеній Сергійович";
            // 
            // NameRow1
            // 
            this.NameRow1.AutoSize = true;
            this.NameRow1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameRow1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.NameRow1.Location = new System.Drawing.Point(169, 124);
            this.NameRow1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameRow1.Name = "NameRow1";
            this.NameRow1.Size = new System.Drawing.Size(256, 23);
            this.NameRow1.TabIndex = 1;
            this.NameRow1.Text = "Виконав студент групи ІП-12";
            // 
            // Lab1MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.FramePanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lab1MainForm";
            this.Text = "Lab1MainForm";
            this.FramePanel.ResumeLayout(false);
            this.FramePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabNumberLabel;
        private System.Windows.Forms.Panel FramePanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label NameRow1;
        private System.Windows.Forms.Label NameRow2;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Panel DrawingPanel;
    }
}

