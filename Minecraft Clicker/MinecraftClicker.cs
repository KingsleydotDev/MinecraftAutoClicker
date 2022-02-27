using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace Minecraft_Clicker
{

    public partial class MinecraftClicker : Form
    {

        private bool active;
        private bool mousedownCPS;
        private bool mousedownCPS2;
        private bool iswindowjavanow;
        private bool InventoryOpen;


        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);


        //private bool LeftClick;
        private bool ClickSounds;

        public MinecraftClicker()
        {
            InitializeComponent();
        }


        private void MinecraftClicker_Load(object sender, EventArgs e)
        {

        }



        #region  enable sounds?

        private void clickSounds_Click(object sender, EventArgs e)
        {

            if (clickSounds.Text.Contains("disable"))
            {
                ClickSounds = false;
                clickSounds.Text = "enable";
            }
            else if (clickSounds.Text.Contains("enable"))
            {

                ClickSounds = true;
                clickSounds.Text = "disable";
            }
        }

        #endregion


        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("disable"))
            {
                btnToggle.Text = "enable";
                FluxTimer.Stop();
                SendClick.Stop();
                iswindowjava.Stop();
                active = false;

            }
            else if (btnToggle.Text.Contains("enable"))
            {
                btnToggle.Text = "disable";
                FluxTimer.Start();
                SendClick.Start();
                iswindowjava.Start();
                active = true;
            }
        }
        private void btnToggle_TextChanged(object sender, EventArgs e)
        {

        }
        int min;
        int max;
        IntPtr hWnd;
        public string getActiveWindowName()
        {
            try
            {
                var activateHandle = GetForegroundWindow();

                Process[] processes = Process.GetProcesses();
                foreach (Process clsProcess in processes)
                {
                    if (activateHandle == clsProcess.MainWindowHandle)
                    {
                        string processName = clsProcess.ProcessName;
                        return processName;
                    }
                }
            }
            catch { }
            return null;
        }
        private void bindBtn_Click(object sender, EventArgs e)
        {
            bindBtn.Text = "...";
        }
        KeysConverter Key = new KeysConverter();
        private void Binding_Tick(object sender, EventArgs e)
        {
            if (bindBtn.Text != "none" && bindBtn.Text != "...")
            {
                Keys binding = (Keys)Key.ConvertFromString(bindBtn.Text.Replace("...", ""));
                if (GetAsyncKeyState(binding) < 0)
                {

                    while (GetAsyncKeyState(binding) < 0)
                    {
                        Thread.Sleep(200);
                    }
                    if (btnToggle.Text.Contains("enable"))
                    {
                        btnToggle.Text = "disable";
                    }
                    else if (btnToggle.Text.Contains("disable"))
                    {
                        btnToggle.Text = "enable";
                    }
                    return;
                }
            }
        }
        private void bindBtn_KeyDown(object sender, KeyEventArgs e)
        {
            {
                string keydata = e.KeyData.ToString();
                if (!keydata.Contains("Alt"))
                {
                    if (GetAsyncKeyState(Keys.Escape) < 0)
                    {
                        bindBtn.Text = "none";
                    }
                    else
                    {
                        bindBtn.Text = keydata;
                    }
                }
            }
        }
        private void CPSTrackbar_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            CPSValue.Text = (CPSTrackbar.Value.ToString() + " CPS");
        }

        private Point offset;
        bool mousedown;

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RGBtoggle_Click(object sender, EventArgs e)
        {

            if (RGBtoggle.Text.Contains("disable"))
            {
                RGBtoggle.Text = "enable";
                btnToggle.ForeColor = Color.White;
                label3.ForeColor = Color.FromArgb(154, 197, 39);
                CPSTrackbar.ThumbColor = Color.FromArgb(154, 197, 39);
                CPSTrackbar.ElapsedColor = Color.FromArgb(154, 197, 39);
                bindBtn.ForeColor = Color.White;
                CPSValue.ForeColor = Color.FromArgb(154, 197, 39);
                RGBtoggle.ForeColor = Color.White;
                clickSounds.ForeColor = Color.White;
                CPSValue2.ForeColor = Color.FromArgb(154, 197, 39);
                CPSTrackbar2.ElapsedColor = Color.FromArgb(154, 197, 39);
                CPSTrackbar2.ThumbColor = Color.FromArgb(154, 197, 39);
                label9.ForeColor = Color.White;
                label7.ForeColor = Color.FromArgb(154, 197, 39);
                btnToggle2.ForeColor = Color.White;


                RGB.Stop();
            }
            else if (RGBtoggle.Text.Contains("enable"))
            {
                RGBtoggle.Text = "disable";
                RGB.Start();
            }
        }

        int r = 255, g = 0, b = 0;

        private void RGB_Tick(object sender, EventArgs e)
        {
            btnToggle.ForeColor = Color.FromArgb(r, g, b);
            label3.ForeColor = Color.FromArgb(r, g, b);
            CPSTrackbar.ThumbColor = Color.FromArgb(r, g, b);
            CPSTrackbar.ElapsedColor = Color.FromArgb(r, g, b);
            bindBtn.ForeColor = Color.FromArgb(r, g, b);
            CPSValue.ForeColor = Color.FromArgb(r, g, b);
            RGBtoggle.ForeColor = Color.FromArgb(r, g, b);
            clickSounds.ForeColor = Color.FromArgb(r, g, b);
            label7.ForeColor = Color.FromArgb(r, g, b);
            CPSTrackbar2.ElapsedColor = Color.FromArgb(r, g, b);
            CPSTrackbar2.ThumbColor = Color.FromArgb(r, g, b);
            btnToggle2.ForeColor = Color.FromArgb(r, g, b);
            label7.ForeColor = Color.FromArgb(r, g, b);
            label9.ForeColor = Color.FromArgb(r, g, b);
            CPSValue2.ForeColor = Color.FromArgb(r, g, b);
            if (r > 0 && b == 0)
            {
                r--;
                g++;
            }
            if (g > 0 && r == 0)
            {
                g--;
                b++;

            }
            if (b > 0 && g == 0)
            {
                b--;
                r++;
            }

        }

        public void hitsound()
        {
            if (ClickSounds == true)
            {
                try
                {
                    var soundsRoot = Application.StartupPath;
                    string[] filePaths = Directory.GetFiles(soundsRoot, "*.wav");
                    Random rnd = new Random(Guid.NewGuid().GetHashCode());
                    int choices = rnd.Next(filePaths.Length);
                    SoundPlayer player = new SoundPlayer(filePaths[choices]);
                    player.Play();
                }
                catch { }
            }
        }





        private int TweakedCPS;
        private int TweakedCPS2;

        public void FluxTimer_Tick(object sender, EventArgs e)
        {
            min = CPSTrackbar.Value - 5;
            max = CPSTrackbar.Value + 5;
            Random randflux = new Random();
            double flux = randflux.Next(min, max);
            textBox1.Invoke((MethodInvoker)(() => textBox1.Text = flux.ToString()));
            TweakedCPS = int.Parse(textBox1.Text);
        }

        private void SendClick_Tick(object sender, EventArgs e)
        {
            if (mousedownCPS == true && iswindowjavanow == true && active == true/* && InventoryOpen == true*/)
            {
                SendClick.Interval = (1000 / TweakedCPS);
                Random rnd = new Random();
                int number = rnd.Next(19, 33);
                PostMessage(hWnd, 0x0201, 0, 0);
                Thread.Sleep(number);
                PostMessage(hWnd, 0x0202, 0, 0);
                hitsound();
            }
        }


        [StructLayout(LayoutKind.Sequential)]
        struct CURSORINFO
        {
            public Int32 cbSize;
            public Int32 flags;
            public IntPtr hCursor;
        }

        [DllImport("user32.dll")] static extern bool GetCursorInfo(out CURSORINFO pci);
        const Int32 CURSOR_SHOWING = 0x00000001;

        private void inventorycheck_Tick(object sender, EventArgs e)
        {
            CURSORINFO pci = new CURSORINFO();
            pci.flags = System.Runtime.InteropServices.Marshal.SizeOf(typeof(CURSORINFO));
            GetCursorInfo(out pci);

            if (pci.flags == CURSOR_SHOWING)
            {
                InventoryOpen = true;
            }

            else if (pci.flags != CURSOR_SHOWING)
            {
                InventoryOpen = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (btnToggle2.Text.Contains("disable"))
            {
                btnToggle2.Text = "enable";
                FluxTimer2.Stop();
                SendClick2.Stop();
                iswindowjava.Stop();
                active = false;

            }
            else if (btnToggle2.Text.Contains("enable"))
            {
                btnToggle2.Text = "disable";
                FluxTimer2.Start();
                SendClick2.Start();
                iswindowjava.Start();
                active = true;
            }

        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            CPSValue2.Text = (CPSTrackbar2.Value.ToString() + " CPS");
        }

        private void FluxTimer2_Tick(object sender, EventArgs e)
        {
            //int TweakedCPS;
            min = CPSTrackbar2.Value - 5;
            max = CPSTrackbar2.Value + 5;
            Random randflux = new Random();
            double flux = randflux.Next(min, max);
            textBox1.Invoke((MethodInvoker)(() => textBox2.Text = flux.ToString()));
            TweakedCPS2 = int.Parse(textBox2.Text);
        }

        private void SendClick2_Tick(object sender, EventArgs e)
        {
            if (mousedownCPS2 == true && iswindowjavanow == true && active == true/* && InventoryOpen == true*/)
            {
                SendClick2.Interval = (1000 / TweakedCPS2);
                Random rnd = new Random();
                int number = rnd.Next(19, 33);
                PostMessage(hWnd, 0x0204, 0, 0);
                Thread.Sleep(number);
                PostMessage(hWnd, 0x0205, 0, 0);
                hitsound();
            }
        }

        private void IsMouseDown2_Tick(object sender, EventArgs e)
        {
            mousedownCPS2 = false;
            if (MouseButtons == MouseButtons.Right)
            {
                mousedownCPS2 = true;
            }
        }

        private void IsMouseDown_Tick(object sender, EventArgs e)
        {
            mousedownCPS = false;
            if (MouseButtons == MouseButtons.Left)
            {
                mousedownCPS = true;
            }
        }

        private void iswindowjava_Tick(object sender, EventArgs e)
        {
            iswindowjavanow = false;
            Process[] processes = Process.GetProcessesByName("javaw");
            foreach (Process process in processes)
            {
                hWnd = FindWindow(null, process.MainWindowTitle);
            }
            string currentwindow = getActiveWindowName();
            if (currentwindow == null)
            {
                return;
            }
            if (currentwindow.Contains("javaw"))
            {
                iswindowjavanow = true;
            }

        }
    }
}