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

namespace Lab4_Movement
{
    public partial class Lab4Form : Form
    {
        bool[] events; //Dictionary<string, bool>
        GameBoard gameBoard;
        int mouseX;
        int mouseY;

        public Lab4Form()
        {
            InitializeComponent();
            this.gameBoard = new GameBoard();
            this.events = new bool[] // Dictionary<string, bool>()
            {
                false, // 0 { "Space", false },
                false, // 1 { "Del", false },
                false, // 2 { "LMB", false },
                false, // 3 { "RMB", false },
                false, // 4 { "W", false },
                false, // 5 { "A", false },
                false, // 6 { "S", false },
                false, // 7 { "D", false },
                false, // 8 { "T", false },
                false, // 9 { "1", false },
                false, // 10 { "2", false },
                false, // 11 { "3", false },
                false, // 12 { "4", false },
                false, // 13 { "5", false },
                false, // 14 { "6", false },
                false, // 15 { "7", false },
                false, // 16 { "8", false },
                false  // 17 { "9", false }
            };
            this.mouseX = 0;
            this.mouseY = 0;
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

        private void Lab4Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                this.events[4/*"W"*/] = true;
            }
            if (e.KeyCode == Keys.A)
            {
                this.events[5/*"A"*/] = true;
            }
            if (e.KeyCode == Keys.S)
            {
                this.events[6/*"S"*/] = true;
            }
            if (e.KeyCode == Keys.D)
            {
                this.events[7/*"D"*/] = true;
            }
        }

        private void Lab4Form_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.events[0/*"Space"*/] = true;
            }
            if (e.KeyCode == Keys.Delete)
            {
                this.events[1/*"Del"*/] = true;
            }
            if (e.KeyCode == Keys.D1)
            {
                this.events[9/*"1"*/] = true;
            }
            if (e.KeyCode == Keys.D2)
            {
                this.events[10/*"2"*/] = true;
            }
            if (e.KeyCode == Keys.D3)
            {
                this.events[11/*"3"*/] = true;
            }
            if (e.KeyCode == Keys.D4)
            {
                this.events[12/*"4"*/] = true;
            }
            if (e.KeyCode == Keys.D5)
            {
                this.events[13/*"5"*/] = true;
            }
            if (e.KeyCode == Keys.D6)
            {
                this.events[14/*"6"*/] = true;
            }
            if (e.KeyCode == Keys.D7)
            {
                this.events[15/*"7"*/] = true;
            }
            if (e.KeyCode == Keys.D8)
            {
                this.events[16/*"8"*/] = true;
            }
            if (e.KeyCode == Keys.D9)
            {
                this.events[17/*"9"*/] = true;
            }
            if (e.KeyCode == Keys.T)
            {
                this.events[8/*"T"*/] = true;
            }
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.events[2/*"LMB"*/] = true;
            }
        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.events[3/*"RMB"*/] = true;
            }
            if (e.Button == MouseButtons.Left)
            {
                this.events[2/*"RMB"*/] = false;
            }
        }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            this.mouseX = e.X;
            this.mouseY = e.Y;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            this.DrawingPanel.Refresh();
            this.gameBoard.update(DrawingPanel, this.events, this.mouseX, this.mouseY);
            for (int i = 0; i < 2; i++)
            {
                events[i] = false;
            }
            for (int i = 3; i < events.Count(); i++)
            {
                events[i] = false;
            }
        }
    }
}
