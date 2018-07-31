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

namespace MysteriaBot
{
    public partial class Form1 : Form
    {

        [DllImport("User32.dll")]
        private static extern int SetForegroundWindow(IntPtr point);
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        // the keystroke signals. you can look them up at the msdn pages
        private static uint WM_KEYDOWN = 0x100, WM_KEYUP = 0x101;

        public Form1()
        {
            InitializeComponent();
        }

        private void b_run_Click(object sender, EventArgs e)
        {
            Task ncbl = Task.Factory.StartNew(() =>
            {
                Bot.StartWeb();
            });
        }

        private void b_Up_Click(object sender, EventArgs e)
        {

        }
    }
}
