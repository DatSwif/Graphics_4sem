using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Recursion
{
    public partial class Lab2Form : Form
    {
        public Lab2Form()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void HeadPanel_MouseDown(object sender, MouseEventArgs e)
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

        private void DrawSquare(Graphics graphics, Pen pen, Point point1, Point point2, Point point3, Point point4, int depth)
        {
            if (depth > 0)
            {
                graphics.DrawLine(pen, point1, point2);
                graphics.DrawLine(pen, point2, point3);
                graphics.DrawLine(pen, point3, point4);
                graphics.DrawLine(pen, point4, point1);

                Point point12 = new Point((int)((point1.X + point2.X * 0.08) / 1.08), (int)((point1.Y + point2.Y * 0.08) / 1.08));
                Point point23 = new Point((int)((point2.X + point3.X * 0.08) / 1.08), (int)((point2.Y + point3.Y * 0.08) / 1.08));
                Point point34 = new Point((int)((point3.X + point4.X * 0.08) / 1.08), (int)((point3.Y + point4.Y * 0.08) / 1.08));
                Point point41 = new Point((int)((point4.X + point1.X * 0.08) / 1.08), (int)((point4.Y + point1.Y * 0.08) / 1.08));
                this.DrawSquare(graphics, pen, point12, point23, point34, point41, depth - 1);
            }
            else return;
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            Graphics graphics = DrawingPanel.CreateGraphics();
            Pen pen = new Pen(Color.Green);
            graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, 500, 340));

            Point point1 = new Point(100, 320);
            Point point2 = new Point(400, 320);
            Point point3 = new Point(400, 20);
            Point point4 = new Point(100, 20);

            this.DrawSquare(graphics, pen, point1, point2, point3, point4, (int)DepthChanger.Value);
        }

        private void DrawTriangle(Graphics graphics, SolidBrush greenBrush, SolidBrush blackBrush, Point point1, Point point2, Point point3, int depth)
        {
            if (depth > 0)
            {
                Point[] OuterTriangle = new Point[] { point1, point2, point3 };
                graphics.FillPolygon(greenBrush, OuterTriangle);

                Point point12 = new Point((int)(point1.X + point2.X) / 2, (int)(point1.Y + point2.Y) / 2);
                Point point13 = new Point((int)(point1.X + point3.X) / 2, (int)(point1.Y + point3.Y) / 2);
                Point point23 = new Point((int)(point2.X + point3.X) / 2, (int)(point2.Y + point3.Y) / 2);

                Point[] InnerTriangle = new Point[] { point12, point13, point23 };
                graphics.FillPolygon(blackBrush, InnerTriangle);

                this.DrawTriangle(graphics, greenBrush, blackBrush, point1, point12, point13, depth - 1);
                this.DrawTriangle(graphics, greenBrush, blackBrush, point12, point2, point23, depth - 1);
                this.DrawTriangle(graphics, greenBrush, blackBrush, point13, point23, point3, depth - 1);
            }
            else return;
        }

        private void TriangleButton_Click(object sender, EventArgs e)
        {
            Graphics graphics = DrawingPanel.CreateGraphics();
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            graphics.FillRectangle(blackBrush, new Rectangle(0, 0, 500, 340));

            Point point1 = new Point(77, 320);
            Point point2 = new Point(423, 320);
            Point point3 = new Point(250, 20);

            DrawTriangle(graphics, greenBrush, blackBrush, point1, point2, point3, 6);
        }
    }
}
