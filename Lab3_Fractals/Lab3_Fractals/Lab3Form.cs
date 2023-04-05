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

namespace Lab3_Fractals
{
    public partial class Lab3Form : Form
    {
        public Lab3Form()
        {
            InitializeComponent();
        }

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

        private void DetailSide(Graphics graphics, Pen greenPen, Pen blackPen, float x1, float y1, float x2, float y2, float x3, float y3, int depth)
        {
            Point point1 = new Point((int)x1, (int)y1);
            Point point2 = new Point((int)x2, (int)y2);

            graphics.DrawLine(blackPen, point1, point2);

            float x4 = (2 * x1 + x2) / 3;
            float y4 = (2 * y1 + y2) / 3;
            Point point4 = new Point((int)x4, (int)y4);

            float xC = (2 * (x1 + x2) - x3) / 3;
            float yC = (2 * (y1 + y2) - y3) / 3;
            Point pointC = new Point((int)xC, (int)yC);

            float x5 = (x1 + 2 * x2) / 3;
            float y5 = (y1 + 2 * y2) / 3;
            Point point5 = new Point((int)x5, (int)y5);

            graphics.DrawLine(greenPen, point1, point4);
            graphics.DrawLine(greenPen, point4, pointC);
            graphics.DrawLine(greenPen, pointC, point5);
            graphics.DrawLine(greenPen, point5, point2);
            
            if (depth > 0)
            {
                float x1_1 = (2 * x1 + x3) / 3;
                float y1_1 = (2 * y1 + y3) / 3;

                float x2_1 = (2 * x2 + x3) / 3;
                float y2_1 = (2 * y2 + y3) / 3;

                this.DetailSide(graphics, greenPen, blackPen, x1, y1, x4, y4, x1_1, y1_1, depth - 1);
                this.DetailSide(graphics, greenPen, blackPen, x4, y4, xC, yC, x5, y5, depth - 1);
                this.DetailSide(graphics, greenPen, blackPen, xC, yC, x5, y5, x4, y4, depth - 1);
                this.DetailSide(graphics, greenPen, blackPen, x5, y5, x2, y2, x2_1, y2_1, depth - 1);
            }
            else return;
        }

        private void DrawSnowflake(Graphics graphics, Pen greenPen, Pen blackPen, float x1, float y1, float x2, float y2, float x3, float y3, int depth)
        {
            Point point1 = new Point((int)x1, (int)y1);
            Point point2 = new Point((int)x2, (int)y2);
            Point point3 = new Point((int)x3, (int)y3);

            graphics.DrawLine(greenPen, point1, point2);
            graphics.DrawLine(greenPen, point2, point3);
            graphics.DrawLine(greenPen, point3, point1);

            if (depth > 0)
            {
                this.DetailSide(graphics, greenPen, blackPen, x1, y1, x2, y2, x3, y3, depth - 1);
                this.DetailSide(graphics, greenPen, blackPen, x2, y2, x3, y3, x1, y1, depth - 1);
                this.DetailSide(graphics, greenPen, blackPen, x3, y3, x1, y1, x2, y2, depth - 1);
            }
            else return;
        }

        private void SnowflakeButton_Click(object sender, EventArgs e)
        {
            Graphics graphics = DrawingPanel.CreateGraphics();
            Pen greenPen = new Pen(Color.Green);
            Pen blackPen = new Pen(Color.Black);
            graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, 500, 340));

            float x1 = 112;
            float y1 = 245;
            float x2 = 363;
            float y2 = 245;
            float x3 = 250;
            float y3 = 20;

            this.DrawSnowflake(graphics, greenPen, blackPen, x1, y1, x2, y2, x3, y3, (int)this.DepthChanger.Value);
        }

    }
}
