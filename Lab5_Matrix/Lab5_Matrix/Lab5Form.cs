using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Lab5_Matrix
{
    public partial class Lab5From : Form
    {
        #region Initialization

        private System.Drawing.Graphics g;
        private Pen pen;
        private Brush brush;

        private bool valueChanged;
        private Matrix mainMatrix;
        private Matrix rotateMatrix;
        private Matrix moveMatrix;
        private Matrix stretchMatrix;
        private GraphicsPath squarePath;

        private Point[] squarePoints;
        private byte[] pointTypes;

        public Lab5From()
        {
            InitializeComponent();

            g = DrawingPanel.CreateGraphics();
            pen = new Pen(Color.White);
            brush = new SolidBrush(Color.Black);

            valueChanged = false;
            mainMatrix = new Matrix(1, 0, 0, 1, 0, 0);
            rotateMatrix = new Matrix(1, 0, 0, 1, 0, 0);
            moveMatrix = new Matrix(1, 0, 0, 1, 0, 0);
            stretchMatrix = new Matrix(1, 0, 0, 1, 0, 0);

            int DrawingPanelCenterX = DrawingPanel.Width / 2;
            int DrawingPanelCenterY = DrawingPanel.Height / 2;
            DrawingPanel.AutoScrollPosition = new Point(-DrawingPanelCenterX, -DrawingPanelCenterY);

            squarePoints = new Point[]
            {
                new Point(50, 50),
                new Point(100, 50),
                new Point(100, 100),
                new Point(50, 100),
                new Point(50, 50)
            };
            pointTypes = new byte[]
            {
                1,
                1,
                1,
                1,
                1
            };
            squarePath = new GraphicsPath(squarePoints, pointTypes);
        }
        #endregion

        #region Default header panel settings

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Input handling
        
        private void FloatCell_KeyPress(object sender, KeyPressEventArgs e, Control newControl)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1) ||
                (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0) ||
                (e.KeyChar == '-' && (sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                newControl.Focus();
                valueChanged = true;
            }
            else
            {
                valueChanged = false;
            }
        }

        private float convertToFloat(string input, float defaultValue)
        {
            float result;
            if (Single.TryParse(input, NumberStyles.AllowDecimalPoint |
                                       NumberStyles.AllowLeadingSign, 
                                       CultureInfo.InvariantCulture, out result))
            {
                return result;
            }
            else
            {
                return defaultValue;
            }
        }

        private void RotateField_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatCell_KeyPress(sender, e, AddToMatrixButton);
            if (valueChanged)
            {
                float degrees = convertToFloat(RotateField.Text, 0);
                RotateField.Text = degrees.ToString("G", CultureInfo.InvariantCulture);

                var bounds = squarePath.GetBounds();
                float centerX = bounds.Location.X + bounds.Width / 2;
                float centerY = bounds.Location.Y + bounds.Height / 2;
                PointF center = new PointF(centerX, centerY);

                rotateMatrix = new Matrix(1, 0, 0, 1, 0, 0);
                rotateMatrix.RotateAt(degrees, center);

                RotateRadioButton.Checked = true;
            }
        }

        private void MoveXField_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatCell_KeyPress(sender, e, MoveYField);
            if (valueChanged)
            {
                moveMatrix = new Matrix(1, 0, 0, 1, 0, 0);
                float offsetX = convertToFloat(MoveXField.Text, 0);
                MoveXField.Text = offsetX.ToString("G", CultureInfo.InvariantCulture);
                float offsetY = convertToFloat(MoveYField.Text, 0);
                MoveYField.Text = offsetY.ToString("G", CultureInfo.InvariantCulture);
                moveMatrix.Translate(offsetX, offsetY);

                MoveRadioButton.Checked = true;
            }
        }

        private void MoveYField_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatCell_KeyPress(sender, e, AddToMatrixButton);
            if (valueChanged)
            {
                moveMatrix = new Matrix(1, 0, 0, 1, 0, 0);
                float offsetX = convertToFloat(MoveXField.Text, 0);
                MoveXField.Text = offsetX.ToString("G", CultureInfo.InvariantCulture);
                float offsetY = convertToFloat(MoveYField.Text, 0);
                MoveYField.Text = offsetY.ToString("G", CultureInfo.InvariantCulture);
                moveMatrix.Translate(offsetX, offsetY);

                MoveRadioButton.Checked = true;
            }
        }

        private void StretchXField_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatCell_KeyPress(sender, e, StretchYField);
            if (valueChanged)
            {
                stretchMatrix = new Matrix(1, 0, 0, 1, 0, 0);
                float stretchX = convertToFloat(StretchXField.Text, 1);
                StretchXField.Text = stretchX.ToString("G", CultureInfo.InvariantCulture);
                float stretchY = convertToFloat(StretchYField.Text, 1);
                StretchYField.Text = stretchY.ToString("G", CultureInfo.InvariantCulture);
                stretchMatrix.Scale(stretchX, stretchY);

                StretchRadioButton.Checked = true;
            }
        }

        private void StretchYField_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatCell_KeyPress(sender, e, AddToMatrixButton);
            if (valueChanged)
            {
                stretchMatrix = new Matrix(1, 0, 0, 1, 0, 0);
                float stretchX = convertToFloat(StretchXField.Text, 1);
                StretchXField.Text = stretchX.ToString("G", CultureInfo.InvariantCulture);
                float stretchY = convertToFloat(StretchYField.Text, 1);
                StretchYField.Text = stretchY.ToString("G", CultureInfo.InvariantCulture);
                stretchMatrix.Scale(stretchX, stretchY);

                StretchRadioButton.Checked = true;
            }
        }

        private void updateMainMatrix()
        {
            float m11 = convertToFloat(MatrixCell1.Text, 1);
            float m12 = convertToFloat(MatrixCell2.Text, 0);
            float m21 = convertToFloat(MatrixCell4.Text, 0);
            float m22 = convertToFloat(MatrixCell5.Text, 1);
            float dx = convertToFloat(MatrixCell7.Text, 0);
            float dy = convertToFloat(MatrixCell8.Text, 0);
            mainMatrix = new Matrix(m11, m12, m21, m22, dx, dy);

            MatrixCell1.Text = mainMatrix.Elements[0].ToString("G", CultureInfo.InvariantCulture);
            MatrixCell2.Text = mainMatrix.Elements[1].ToString("G", CultureInfo.InvariantCulture);
            MatrixCell4.Text = mainMatrix.Elements[2].ToString("G", CultureInfo.InvariantCulture);
            MatrixCell5.Text = mainMatrix.Elements[3].ToString("G", CultureInfo.InvariantCulture);
            MatrixCell7.Text = mainMatrix.Elements[4].ToString("G", CultureInfo.InvariantCulture);
            MatrixCell8.Text = mainMatrix.Elements[5].ToString("G", CultureInfo.InvariantCulture);
        }

        private void MatrixCell1_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatCell_KeyPress(sender, e, MatrixCell2);
            if (valueChanged)
            {
                updateMainMatrix();
            }
        }

        private void MatrixCell2_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatCell_KeyPress(sender, e, MatrixCell4);
            if (valueChanged)
            {
                updateMainMatrix();
            }
        }

        private void MatrixCell4_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatCell_KeyPress(sender, e, MatrixCell5);
            if (valueChanged)
            {
                updateMainMatrix();
            }
        }

        private void MatrixCell5_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatCell_KeyPress(sender, e, MatrixCell7);
            if (valueChanged)
            {
                updateMainMatrix();
            }
        }

        private void MatrixCell7_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatCell_KeyPress(sender, e, MatrixCell8);
            if (valueChanged)
            {
                updateMainMatrix();
            }
        }

        private void MatrixCell8_KeyPress(object sender, KeyPressEventArgs e)
        {
            FloatCell_KeyPress(sender, e, ApplyButton);
            if (valueChanged)
            {
                updateMainMatrix();
            }
        }

        #endregion

        #region Pressing buttons

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            mainMatrix = new Matrix(1, 0, 0, 1, 0, 0);
            rotateMatrix = new Matrix(1, 0, 0, 1, 0, 0);
            moveMatrix = new Matrix(1, 0, 0, 1, 0, 0);
            stretchMatrix = new Matrix(1, 0, 0, 1, 0, 0);

            RotateField.Text = "0";
            MoveXField.Text = "0";
            MoveYField.Text = "0";
            StretchXField.Text = "1";
            StretchYField.Text = "1";

            MatrixCell1.Text = "1";
            MatrixCell2.Text = "0";
            MatrixCell4.Text = "0";
            MatrixCell5.Text = "1";
            MatrixCell7.Text = "0";
            MatrixCell8.Text = "0";

            refreshDrawingPanel();
        }

        private void ChangeMatrixButton_Click(object sender, EventArgs e)
        {
            if (RotateRadioButton.Checked)
            {
                mainMatrix = rotateMatrix.Clone();
            }
            else if(MoveRadioButton.Checked)
            {
                mainMatrix = moveMatrix.Clone();
            }
            else if (StretchRadioButton.Checked)
            {
                mainMatrix = stretchMatrix.Clone();
            }

            string tempText = mainMatrix.Elements[0].ToString("G", CultureInfo.InvariantCulture);
            MatrixCell1.Text = tempText.Substring(0, Math.Min(6, tempText.Length));
            tempText = mainMatrix.Elements[1].ToString("G", CultureInfo.InvariantCulture);
            MatrixCell2.Text = tempText.Substring(0, Math.Min(6, tempText.Length));
            tempText = mainMatrix.Elements[2].ToString("G", CultureInfo.InvariantCulture);
            MatrixCell4.Text = tempText.Substring(0, Math.Min(6, tempText.Length));
            tempText = mainMatrix.Elements[3].ToString("G", CultureInfo.InvariantCulture);
            MatrixCell5.Text = tempText.Substring(0, Math.Min(6, tempText.Length));
            tempText = mainMatrix.Elements[4].ToString("G", CultureInfo.InvariantCulture);
            MatrixCell7.Text = tempText.Substring(0, Math.Min(6, tempText.Length));
            tempText = mainMatrix.Elements[5].ToString("G", CultureInfo.InvariantCulture);
            MatrixCell8.Text = tempText.Substring(0, Math.Min(6, tempText.Length));
        }

        private void AddToMatrixButton_Click(object sender, EventArgs e)
        {
            if (RotateRadioButton.Checked)
            {
                mainMatrix.Multiply(rotateMatrix);
            }
            else if (MoveRadioButton.Checked)
            {
                mainMatrix.Multiply(moveMatrix);
            }
            else if (StretchRadioButton.Checked)
            {
                mainMatrix.Multiply(stretchMatrix);
            }

            string tempText = mainMatrix.Elements[0].ToString("G", CultureInfo.InvariantCulture);
            MatrixCell1.Text = tempText.Substring(0, Math.Min(6, tempText.Length));
            tempText = mainMatrix.Elements[1].ToString("G", CultureInfo.InvariantCulture);
            MatrixCell2.Text = tempText.Substring(0, Math.Min(6, tempText.Length));
            tempText = mainMatrix.Elements[2].ToString("G", CultureInfo.InvariantCulture);
            MatrixCell4.Text = tempText.Substring(0, Math.Min(6, tempText.Length));
            tempText = mainMatrix.Elements[3].ToString("G", CultureInfo.InvariantCulture);
            MatrixCell5.Text = tempText.Substring(0, Math.Min(6, tempText.Length));
            tempText = mainMatrix.Elements[4].ToString("G", CultureInfo.InvariantCulture);
            MatrixCell7.Text = tempText.Substring(0, Math.Min(6, tempText.Length));
            tempText = mainMatrix.Elements[5].ToString("G", CultureInfo.InvariantCulture);
            MatrixCell8.Text = tempText.Substring(0, Math.Min(6, tempText.Length));
        }

        private bool checkLocation(GraphicsPath testPath)
        {
            foreach (PointF point in testPath.PathPoints)
            {
                if ((point.X >  300) ||
                    (point.X < -300) ||
                    (point.Y >  200) ||
                    (point.Y < -200))
                {
                    return false;
                }
            }
            return true;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            GraphicsPath testPath = new GraphicsPath();
            testPath.AddPath(squarePath, true);
            testPath.Transform(mainMatrix);
            bool plausible = checkLocation(testPath);
            if (plausible)
            {
                squarePath.Transform(mainMatrix);
                pen.Color = Color.White;
                DrawingPanel.Refresh();
                createAxesAndGrid();
                renderSquare();
            }
            else
            {
                pen.Color = Color.Red;
                DrawingPanel.Refresh();
                createAxesAndGrid();
                renderSquare();
            }
        }

        #endregion

        #region Rendering objects

        private void renderSquare()
        {
            PointF[] pathPoints = squarePath.PathPoints;
            PointF[] shownPoints = new PointF[pathPoints.Length];

            for (int i = 0; i < pathPoints.Length; i++)
            {
                float shownX = 300 + pathPoints[i].X;
                float shownY = 200 - pathPoints[i].Y;
                shownPoints[i] = new PointF(shownX, shownY);
            }
            GraphicsPath realPath = new GraphicsPath(shownPoints, pointTypes);
            g.DrawPath(pen, realPath);
        }

        private void createAxesAndGrid()
        {
            int gridSize = 50;
            Color gridColor = Color.FromArgb(50, 50, 50);
            Color axisColor = Color.FromArgb(150, 150, 150);

            int centerX = DrawingPanel.Width / 2;
            int centerY = DrawingPanel.Height / 2;

            // Draw the X and Y axes
            Pen axisPen = new Pen(axisColor, 2);
            g.DrawLine(axisPen, 0, centerY, DrawingPanel.Width, centerY);
            g.DrawLine(axisPen, centerX, 0, centerX, DrawingPanel.Height);

            // Draw the grid lines
            Pen gridPen = new Pen(gridColor, 1);
            for (int x = centerX % gridSize; x < DrawingPanel.Width; x += gridSize)
            {
                g.DrawLine(gridPen, x, 0, x, DrawingPanel.Height);
                if (x != centerX)
                {
                    string text = (x - centerX) / gridSize * 50 + "";
                    SizeF textSize = g.MeasureString(text, Font);
                    RectangleF rect = new RectangleF(new PointF(x - 12, centerY + 2), textSize);
                    Brush brush = new SolidBrush(Color.Black);
                    g.FillRectangle(brush, rect);
                    Brush textBrush = new SolidBrush(Color.White);

                    g.DrawString(text, Font, Brushes.Gray, x - 12, centerY + 2);
                }
            }
            for (int y = centerY % gridSize; y < DrawingPanel.Height; y += gridSize)
            {
                g.DrawLine(gridPen, 0, y, DrawingPanel.Width, y);
                if (y != centerY)
                {
                    string text = -(y - centerY) / gridSize * 50 + "";
                    SizeF textSize = g.MeasureString(text, Font);
                    RectangleF rect = new RectangleF(new PointF(centerX - 12, y), textSize);
                    Brush brush = new SolidBrush(Color.Black);
                    g.FillRectangle(brush, rect);
                    Brush textBrush = new SolidBrush(Color.White);

                    g.DrawString(text, Font, Brushes.Gray, centerX - 12, y);
                }
            }
        }

        private void refreshDrawingPanel()
        {
            DrawingPanel.Refresh();
            createAxesAndGrid();
            squarePath = new GraphicsPath(squarePoints, pointTypes);
            pen.Color = Color.White;
            renderSquare();
        }

        #endregion
    }
}
