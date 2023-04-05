
namespace Lab5_Matrix
{
    partial class Lab5From
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab5From));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.SignatureLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.MatrixCell9 = new System.Windows.Forms.TextBox();
            this.MatrixCell8 = new System.Windows.Forms.TextBox();
            this.MatrixCell7 = new System.Windows.Forms.TextBox();
            this.MatrixCell6 = new System.Windows.Forms.TextBox();
            this.MatrixCell5 = new System.Windows.Forms.TextBox();
            this.MatrixCell4 = new System.Windows.Forms.TextBox();
            this.MatrixCell3 = new System.Windows.Forms.TextBox();
            this.MatrixCell2 = new System.Windows.Forms.TextBox();
            this.MatrixCell1 = new System.Windows.Forms.TextBox();
            this.MatrixBrackets = new System.Windows.Forms.PictureBox();
            this.MatrixGroupBox = new System.Windows.Forms.GroupBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.ControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.AddToMatrixButton = new System.Windows.Forms.Button();
            this.ChangeMatrixButton = new System.Windows.Forms.Button();
            this.MoveRadioButton = new System.Windows.Forms.RadioButton();
            this.StretchYField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StretchXField = new System.Windows.Forms.TextBox();
            this.RotateField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RotateRadioButton = new System.Windows.Forms.RadioButton();
            this.StretchRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.MoveYField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MoveXField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixBrackets)).BeginInit();
            this.MatrixGroupBox.SuspendLayout();
            this.ControlsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.HeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderPanel.Controls.Add(this.SignatureLabel);
            this.HeaderPanel.Controls.Add(this.TitleLabel);
            this.HeaderPanel.Controls.Add(this.IconBox);
            this.HeaderPanel.Controls.Add(this.MinimizeButton);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Location = new System.Drawing.Point(-1, -1);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(800, 29);
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            // 
            // SignatureLabel
            // 
            this.SignatureLabel.AutoSize = true;
            this.SignatureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.SignatureLabel.Location = new System.Drawing.Point(479, 7);
            this.SignatureLabel.Name = "SignatureLabel";
            this.SignatureLabel.Size = new System.Drawing.Size(241, 13);
            this.SignatureLabel.TabIndex = 6;
            this.SignatureLabel.Text = "Виконав студент групи ІП-12 Євгеній Тарасюк";
            this.SignatureLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TitleLabel.Location = new System.Drawing.Point(34, 8);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(31, 13);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Lab5";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            // 
            // IconBox
            // 
            this.IconBox.Image = ((System.Drawing.Image)(resources.GetObject("IconBox.Image")));
            this.IconBox.Location = new System.Drawing.Point(1, 1);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(27, 29);
            this.IconBox.TabIndex = 4;
            this.IconBox.TabStop = false;
            this.IconBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.Location = new System.Drawing.Point(726, -1);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(38, 29);
            this.MinimizeButton.TabIndex = 0;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(762, -1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(38, 29);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.TabStop = false;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BackColor = System.Drawing.Color.Black;
            this.DrawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingPanel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.DrawingPanel.Location = new System.Drawing.Point(10, 38);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(600, 400);
            this.DrawingPanel.TabIndex = 7;
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackgroundPanel.Controls.Add(this.MatrixCell9);
            this.BackgroundPanel.Controls.Add(this.MatrixCell8);
            this.BackgroundPanel.Controls.Add(this.MatrixCell7);
            this.BackgroundPanel.Controls.Add(this.MatrixCell6);
            this.BackgroundPanel.Controls.Add(this.MatrixCell5);
            this.BackgroundPanel.Controls.Add(this.MatrixCell4);
            this.BackgroundPanel.Controls.Add(this.MatrixCell3);
            this.BackgroundPanel.Controls.Add(this.MatrixCell2);
            this.BackgroundPanel.Controls.Add(this.MatrixCell1);
            this.BackgroundPanel.Controls.Add(this.DrawingPanel);
            this.BackgroundPanel.Controls.Add(this.HeaderPanel);
            this.BackgroundPanel.Controls.Add(this.MatrixBrackets);
            this.BackgroundPanel.Controls.Add(this.MatrixGroupBox);
            this.BackgroundPanel.Controls.Add(this.ControlsGroupBox);
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(800, 450);
            this.BackgroundPanel.TabIndex = 8;
            // 
            // MatrixCell9
            // 
            this.MatrixCell9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MatrixCell9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatrixCell9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MatrixCell9.Location = new System.Drawing.Point(730, 376);
            this.MatrixCell9.MaxLength = 6;
            this.MatrixCell9.Name = "MatrixCell9";
            this.MatrixCell9.ReadOnly = true;
            this.MatrixCell9.Size = new System.Drawing.Size(40, 20);
            this.MatrixCell9.TabIndex = 17;
            this.MatrixCell9.TabStop = false;
            this.MatrixCell9.Text = "1";
            this.MatrixCell9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MatrixCell8
            // 
            this.MatrixCell8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MatrixCell8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatrixCell8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MatrixCell8.Location = new System.Drawing.Point(685, 376);
            this.MatrixCell8.MaxLength = 6;
            this.MatrixCell8.Name = "MatrixCell8";
            this.MatrixCell8.Size = new System.Drawing.Size(40, 20);
            this.MatrixCell8.TabIndex = 16;
            this.MatrixCell8.TabStop = false;
            this.MatrixCell8.Text = "0";
            this.MatrixCell8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MatrixCell8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixCell8_KeyPress);
            // 
            // MatrixCell7
            // 
            this.MatrixCell7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MatrixCell7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatrixCell7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MatrixCell7.Location = new System.Drawing.Point(640, 376);
            this.MatrixCell7.MaxLength = 6;
            this.MatrixCell7.Name = "MatrixCell7";
            this.MatrixCell7.Size = new System.Drawing.Size(40, 20);
            this.MatrixCell7.TabIndex = 15;
            this.MatrixCell7.TabStop = false;
            this.MatrixCell7.Text = "0";
            this.MatrixCell7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MatrixCell7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixCell7_KeyPress);
            // 
            // MatrixCell6
            // 
            this.MatrixCell6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MatrixCell6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatrixCell6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MatrixCell6.Location = new System.Drawing.Point(730, 350);
            this.MatrixCell6.MaxLength = 6;
            this.MatrixCell6.Name = "MatrixCell6";
            this.MatrixCell6.ReadOnly = true;
            this.MatrixCell6.Size = new System.Drawing.Size(40, 20);
            this.MatrixCell6.TabIndex = 14;
            this.MatrixCell6.TabStop = false;
            this.MatrixCell6.Text = "0";
            this.MatrixCell6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MatrixCell5
            // 
            this.MatrixCell5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MatrixCell5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatrixCell5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MatrixCell5.Location = new System.Drawing.Point(685, 350);
            this.MatrixCell5.MaxLength = 6;
            this.MatrixCell5.Name = "MatrixCell5";
            this.MatrixCell5.Size = new System.Drawing.Size(40, 20);
            this.MatrixCell5.TabIndex = 13;
            this.MatrixCell5.TabStop = false;
            this.MatrixCell5.Text = "1";
            this.MatrixCell5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MatrixCell5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixCell5_KeyPress);
            // 
            // MatrixCell4
            // 
            this.MatrixCell4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MatrixCell4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatrixCell4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MatrixCell4.Location = new System.Drawing.Point(640, 350);
            this.MatrixCell4.MaxLength = 6;
            this.MatrixCell4.Name = "MatrixCell4";
            this.MatrixCell4.Size = new System.Drawing.Size(40, 20);
            this.MatrixCell4.TabIndex = 12;
            this.MatrixCell4.TabStop = false;
            this.MatrixCell4.Text = "0";
            this.MatrixCell4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MatrixCell4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixCell4_KeyPress);
            // 
            // MatrixCell3
            // 
            this.MatrixCell3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MatrixCell3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatrixCell3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MatrixCell3.Location = new System.Drawing.Point(730, 324);
            this.MatrixCell3.MaxLength = 6;
            this.MatrixCell3.Name = "MatrixCell3";
            this.MatrixCell3.ReadOnly = true;
            this.MatrixCell3.Size = new System.Drawing.Size(40, 20);
            this.MatrixCell3.TabIndex = 11;
            this.MatrixCell3.TabStop = false;
            this.MatrixCell3.Text = "0";
            this.MatrixCell3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MatrixCell2
            // 
            this.MatrixCell2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MatrixCell2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatrixCell2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MatrixCell2.Location = new System.Drawing.Point(685, 324);
            this.MatrixCell2.MaxLength = 6;
            this.MatrixCell2.Name = "MatrixCell2";
            this.MatrixCell2.Size = new System.Drawing.Size(40, 20);
            this.MatrixCell2.TabIndex = 10;
            this.MatrixCell2.TabStop = false;
            this.MatrixCell2.Text = "0";
            this.MatrixCell2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MatrixCell2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixCell2_KeyPress);
            // 
            // MatrixCell1
            // 
            this.MatrixCell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MatrixCell1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatrixCell1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MatrixCell1.Location = new System.Drawing.Point(640, 324);
            this.MatrixCell1.MaxLength = 6;
            this.MatrixCell1.Name = "MatrixCell1";
            this.MatrixCell1.Size = new System.Drawing.Size(40, 20);
            this.MatrixCell1.TabIndex = 9;
            this.MatrixCell1.TabStop = false;
            this.MatrixCell1.Text = "1";
            this.MatrixCell1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MatrixCell1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixCell1_KeyPress);
            // 
            // MatrixBrackets
            // 
            this.MatrixBrackets.Image = ((System.Drawing.Image)(resources.GetObject("MatrixBrackets.Image")));
            this.MatrixBrackets.Location = new System.Drawing.Point(631, 318);
            this.MatrixBrackets.Name = "MatrixBrackets";
            this.MatrixBrackets.Size = new System.Drawing.Size(148, 84);
            this.MatrixBrackets.TabIndex = 19;
            this.MatrixBrackets.TabStop = false;
            // 
            // MatrixGroupBox
            // 
            this.MatrixGroupBox.Controls.Add(this.ApplyButton);
            this.MatrixGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatrixGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MatrixGroupBox.Location = new System.Drawing.Point(616, 302);
            this.MatrixGroupBox.Name = "MatrixGroupBox";
            this.MatrixGroupBox.Size = new System.Drawing.Size(179, 135);
            this.MatrixGroupBox.TabIndex = 38;
            this.MatrixGroupBox.TabStop = false;
            this.MatrixGroupBox.Text = "Матриця";
            // 
            // ApplyButton
            // 
            this.ApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ApplyButton.Location = new System.Drawing.Point(9, 104);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(160, 25);
            this.ApplyButton.TabIndex = 8;
            this.ApplyButton.TabStop = false;
            this.ApplyButton.Text = "Трансформація";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ControlsGroupBox
            // 
            this.ControlsGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ControlsGroupBox.Controls.Add(this.AddToMatrixButton);
            this.ControlsGroupBox.Controls.Add(this.ChangeMatrixButton);
            this.ControlsGroupBox.Controls.Add(this.MoveRadioButton);
            this.ControlsGroupBox.Controls.Add(this.StretchYField);
            this.ControlsGroupBox.Controls.Add(this.label1);
            this.ControlsGroupBox.Controls.Add(this.StretchXField);
            this.ControlsGroupBox.Controls.Add(this.RotateField);
            this.ControlsGroupBox.Controls.Add(this.label6);
            this.ControlsGroupBox.Controls.Add(this.label2);
            this.ControlsGroupBox.Controls.Add(this.label7);
            this.ControlsGroupBox.Controls.Add(this.RotateRadioButton);
            this.ControlsGroupBox.Controls.Add(this.StretchRadioButton);
            this.ControlsGroupBox.Controls.Add(this.label3);
            this.ControlsGroupBox.Controls.Add(this.MoveYField);
            this.ControlsGroupBox.Controls.Add(this.label4);
            this.ControlsGroupBox.Controls.Add(this.MoveXField);
            this.ControlsGroupBox.Controls.Add(this.label5);
            this.ControlsGroupBox.Controls.Add(this.RefreshButton);
            this.ControlsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ControlsGroupBox.Location = new System.Drawing.Point(616, 34);
            this.ControlsGroupBox.Name = "ControlsGroupBox";
            this.ControlsGroupBox.Size = new System.Drawing.Size(179, 266);
            this.ControlsGroupBox.TabIndex = 0;
            this.ControlsGroupBox.TabStop = false;
            this.ControlsGroupBox.Text = "Керування";
            // 
            // AddToMatrixButton
            // 
            this.AddToMatrixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToMatrixButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.AddToMatrixButton.Location = new System.Drawing.Point(9, 233);
            this.AddToMatrixButton.Name = "AddToMatrixButton";
            this.AddToMatrixButton.Size = new System.Drawing.Size(160, 25);
            this.AddToMatrixButton.TabIndex = 37;
            this.AddToMatrixButton.TabStop = false;
            this.AddToMatrixButton.Text = "Додати до матриці";
            this.AddToMatrixButton.UseVisualStyleBackColor = true;
            this.AddToMatrixButton.Click += new System.EventHandler(this.AddToMatrixButton_Click);
            // 
            // ChangeMatrixButton
            // 
            this.ChangeMatrixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeMatrixButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ChangeMatrixButton.Location = new System.Drawing.Point(9, 202);
            this.ChangeMatrixButton.Name = "ChangeMatrixButton";
            this.ChangeMatrixButton.Size = new System.Drawing.Size(160, 25);
            this.ChangeMatrixButton.TabIndex = 30;
            this.ChangeMatrixButton.TabStop = false;
            this.ChangeMatrixButton.Text = "Змінити матрицю";
            this.ChangeMatrixButton.UseVisualStyleBackColor = true;
            this.ChangeMatrixButton.Click += new System.EventHandler(this.ChangeMatrixButton_Click);
            // 
            // MoveRadioButton
            // 
            this.MoveRadioButton.AutoSize = true;
            this.MoveRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MoveRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MoveRadioButton.Location = new System.Drawing.Point(9, 109);
            this.MoveRadioButton.Name = "MoveRadioButton";
            this.MoveRadioButton.Size = new System.Drawing.Size(114, 21);
            this.MoveRadioButton.TabIndex = 24;
            this.MoveRadioButton.Text = "Переміщення";
            this.MoveRadioButton.UseVisualStyleBackColor = true;
            // 
            // StretchYField
            // 
            this.StretchYField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.StretchYField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StretchYField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.StretchYField.Location = new System.Drawing.Point(126, 176);
            this.StretchYField.MaxLength = 6;
            this.StretchYField.Name = "StretchYField";
            this.StretchYField.Size = new System.Drawing.Size(40, 20);
            this.StretchYField.TabIndex = 36;
            this.StretchYField.TabStop = false;
            this.StretchYField.Text = "1";
            this.StretchYField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StretchYField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StretchYField_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "На";
            // 
            // StretchXField
            // 
            this.StretchXField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.StretchXField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StretchXField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.StretchXField.Location = new System.Drawing.Point(50, 176);
            this.StretchXField.MaxLength = 6;
            this.StretchXField.Name = "StretchXField";
            this.StretchXField.Size = new System.Drawing.Size(40, 20);
            this.StretchXField.TabIndex = 35;
            this.StretchXField.TabStop = false;
            this.StretchXField.Text = "1";
            this.StretchXField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StretchXField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StretchXField_KeyPress);
            // 
            // RotateField
            // 
            this.RotateField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.RotateField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RotateField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.RotateField.Location = new System.Drawing.Point(36, 70);
            this.RotateField.MaxLength = 6;
            this.RotateField.Name = "RotateField";
            this.RotateField.Size = new System.Drawing.Size(40, 20);
            this.RotateField.TabIndex = 22;
            this.RotateField.TabStop = false;
            this.RotateField.Text = "0";
            this.RotateField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RotateField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RotateField_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label6.Location = new System.Drawing.Point(88, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = ", за Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(82, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "градусів";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label7.Location = new System.Drawing.Point(16, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "За X:";
            // 
            // RotateRadioButton
            // 
            this.RotateRadioButton.AutoSize = true;
            this.RotateRadioButton.Checked = true;
            this.RotateRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RotateRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RotateRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RotateRadioButton.Location = new System.Drawing.Point(9, 46);
            this.RotateRadioButton.Name = "RotateRadioButton";
            this.RotateRadioButton.Size = new System.Drawing.Size(81, 21);
            this.RotateRadioButton.TabIndex = 23;
            this.RotateRadioButton.Text = "Поворот";
            this.RotateRadioButton.UseVisualStyleBackColor = true;
            // 
            // StretchRadioButton
            // 
            this.StretchRadioButton.AutoSize = true;
            this.StretchRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StretchRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StretchRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StretchRadioButton.Location = new System.Drawing.Point(9, 154);
            this.StretchRadioButton.Name = "StretchRadioButton";
            this.StretchRadioButton.Size = new System.Drawing.Size(109, 21);
            this.StretchRadioButton.TabIndex = 25;
            this.StretchRadioButton.Text = "Розтягнення";
            this.StretchRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(16, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "проти годинникової стрілки";
            // 
            // MoveYField
            // 
            this.MoveYField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MoveYField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoveYField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MoveYField.Location = new System.Drawing.Point(126, 131);
            this.MoveYField.MaxLength = 6;
            this.MoveYField.Name = "MoveYField";
            this.MoveYField.Size = new System.Drawing.Size(40, 20);
            this.MoveYField.TabIndex = 32;
            this.MoveYField.TabStop = false;
            this.MoveYField.Text = "0";
            this.MoveYField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoveYField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MoveYField_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(16, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "За X:";
            // 
            // MoveXField
            // 
            this.MoveXField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MoveXField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoveXField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MoveXField.Location = new System.Drawing.Point(50, 131);
            this.MoveXField.MaxLength = 6;
            this.MoveXField.Name = "MoveXField";
            this.MoveXField.Size = new System.Drawing.Size(40, 20);
            this.MoveXField.TabIndex = 31;
            this.MoveXField.TabStop = false;
            this.MoveXField.Text = "0";
            this.MoveXField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoveXField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MoveXField_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label5.Location = new System.Drawing.Point(88, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = ", за Y:";
            // 
            // RefreshButton
            // 
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.RefreshButton.Location = new System.Drawing.Point(9, 19);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(160, 25);
            this.RefreshButton.TabIndex = 7;
            this.RefreshButton.TabStop = false;
            this.RefreshButton.Text = "Початковий стан";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Lab5From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lab5From";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixBrackets)).EndInit();
            this.MatrixGroupBox.ResumeLayout(false);
            this.ControlsGroupBox.ResumeLayout(false);
            this.ControlsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.Label SignatureLabel;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TextBox MatrixCell9;
        private System.Windows.Forms.TextBox MatrixCell8;
        private System.Windows.Forms.TextBox MatrixCell7;
        private System.Windows.Forms.TextBox MatrixCell6;
        private System.Windows.Forms.TextBox MatrixCell5;
        private System.Windows.Forms.TextBox MatrixCell4;
        private System.Windows.Forms.TextBox MatrixCell3;
        private System.Windows.Forms.TextBox MatrixCell2;
        private System.Windows.Forms.TextBox MatrixCell1;
        private System.Windows.Forms.PictureBox MatrixBrackets;
        private System.Windows.Forms.GroupBox MatrixGroupBox;
        private System.Windows.Forms.GroupBox ControlsGroupBox;
        private System.Windows.Forms.Button AddToMatrixButton;
        private System.Windows.Forms.Button ChangeMatrixButton;
        private System.Windows.Forms.RadioButton MoveRadioButton;
        private System.Windows.Forms.TextBox StretchYField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StretchXField;
        private System.Windows.Forms.TextBox RotateField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RotateRadioButton;
        private System.Windows.Forms.RadioButton StretchRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MoveYField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MoveXField;
        private System.Windows.Forms.Label label5;
    }
}

