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

namespace Lab1_Initialization
{
    public partial class Lab1MainForm : System.Windows.Forms.Form
    {
        public Lab1MainForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void FramePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            Graphics surnameGraphics = DrawingPanel.CreateGraphics();
            Pen surnamePen = new Pen(Color.Green);
            surnamePen.Width = 2;

            //  Т
            surnameGraphics.DrawLine(surnamePen, 10, 10, 47, 10);
            surnameGraphics.DrawLine(surnamePen, 29, 10, 29, 60);
            //  A
            surnameGraphics.DrawLine(surnamePen, 60, 60, 60, 10);
            surnameGraphics.DrawLine(surnamePen, 60, 10, 85, 10);
            surnameGraphics.DrawLine(surnamePen, 60, 35, 85, 35);
            surnameGraphics.DrawLine(surnamePen, 85, 60, 85, 10);
            //  P
            surnameGraphics.DrawLine(surnamePen, 97, 60, 97, 10);
            surnameGraphics.DrawLine(surnamePen, 97, 10, 122, 10);
            surnameGraphics.DrawLine(surnamePen, 97, 35, 122, 35);
            surnameGraphics.DrawLine(surnamePen, 122, 10, 122, 35);
            //  A
            surnameGraphics.DrawLine(surnamePen, 135, 60, 135, 10);
            surnameGraphics.DrawLine(surnamePen, 135, 10, 160, 10);
            surnameGraphics.DrawLine(surnamePen, 135, 35, 160, 35);
            surnameGraphics.DrawLine(surnamePen, 160, 60, 160, 10);
            //  C
            surnameGraphics.DrawLine(surnamePen, 172, 60, 172, 10);
            surnameGraphics.DrawLine(surnamePen, 172, 10, 197, 10);
            surnameGraphics.DrawLine(surnamePen, 172, 60, 197, 60);
            //  Ю
            surnameGraphics.DrawLine(surnamePen, 210, 60, 210, 10);
            surnameGraphics.DrawLine(surnamePen, 210, 35, 222, 35);
            surnameGraphics.DrawLine(surnamePen, 222, 60, 222, 10);
            surnameGraphics.DrawLine(surnamePen, 247, 60, 247, 10);
            surnameGraphics.DrawLine(surnamePen, 222, 10, 247, 10);
            surnameGraphics.DrawLine(surnamePen, 222, 60, 247, 60);
            //  K
            surnameGraphics.DrawLine(surnamePen, 260, 60, 260, 10);
            surnameGraphics.DrawLine(surnamePen, 260, 35, 285, 10);
            surnameGraphics.DrawLine(surnamePen, 260, 35, 285, 60);
        }
    }
}
