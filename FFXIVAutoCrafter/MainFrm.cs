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

namespace Auto_Key_Presser
{
    public partial class MainFrm : Form
    {
        private MainFrm mainFrm;
        private AboutFrm aboutFrm;
        int amount = 0;
        int current_ammount = 0;
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private KeyHandler ghk;

        private float Interval = 10000;
        private int Offset = 0;

        private Random r = new Random();

        public MainFrm()
        {
            InitializeComponent();
            ghk = new KeyHandler(Constants.CTRL, Keys.O, this);
            ghk.Register();
            MaxProgressLbl.Text = (Interval / 1000).ToString() + "s";
        }
        public void DoLeftMouseClick()
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)X, (uint)Y, 0, 0);
        }

        public void DoRightMouseClick()
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)X, (uint)Y, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(Interval);
            IntervalProgressBar.Maximum = Convert.ToInt32(Interval) / 100;
            IntervalProgressBar.Minimum = 0;
            if (Offset > 0)
            {
                Offset = r.Next(0, Convert.ToInt32(OffsetTxtBox.Text));
                timer1.Interval = Convert.ToInt32(Interval) + Offset;
                MaxProgressLbl.Text = ((Interval + Offset) / 1000).ToString() + "s";
                IntervalProgressBar.Maximum = (Convert.ToInt32(Interval + Offset) / 100);
            }
            timer1.Start();
            timer2.Start();
            button1.Enabled = false;
            button2.Enabled = true;
            IntervalPanel.Enabled = false;
            PressTypePanel.Enabled = false;
            amount = Int32.Parse(amount1.Text) + Int32.Parse(amount2.Text) + Int32.Parse(amount3.Text) + Int32.Parse(amount4.Text) + Int32.Parse(amount5.Text);
            label9.Text = "To do: " + amount.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = "Done: " + current_ammount.ToString();
            if (current_ammount <= Int32.Parse(amount1.Text) + Int32.Parse(amount2.Text) + Int32.Parse(amount3.Text) + Int32.Parse(amount4.Text) + Int32.Parse(amount5.Text) && current_ammount > Int32.Parse(amount1.Text) + Int32.Parse(amount2.Text) + Int32.Parse(amount3.Text) + Int32.Parse(amount4.Text))
            {
                SendKeys.Send(KeyTxtBox5.Text);
                current_ammount++;
            }
            if (current_ammount <= Int32.Parse(amount1.Text) + Int32.Parse(amount2.Text) + Int32.Parse(amount3.Text) + Int32.Parse(amount4.Text) && current_ammount > Int32.Parse(amount1.Text) + Int32.Parse(amount2.Text) + Int32.Parse(amount3.Text))
            {
                SendKeys.Send(KeyTxtBox4.Text);
                current_ammount++;
            }
            if (current_ammount <= Int32.Parse(amount1.Text) + Int32.Parse(amount2.Text) + Int32.Parse(amount3.Text) && current_ammount > Int32.Parse(amount1.Text) + Int32.Parse(amount2.Text))
            {
                SendKeys.Send(KeyTxtBox3.Text);
                current_ammount++;
            }
            if (current_ammount <= Int32.Parse(amount1.Text) + Int32.Parse(amount2.Text) && current_ammount > Int32.Parse(amount1.Text))
            {
                SendKeys.Send(KeyTxtBox2.Text);
                current_ammount++;
            }
            if (current_ammount <= Int32.Parse(amount1.Text) && current_ammount > 0)
            {
                SendKeys.Send(KeyTxtBox.Text);
                current_ammount++;
            }
            if (current_ammount < 1)
            {
                DoLeftMouseClick();   
                current_ammount++;
            }
            
            if (current_ammount >= amount)
            {
                current_ammount = 0;
            }

            IntervalProgressBar.Value = 0;

            if (Offset > 0)
            {
                Offset = r.Next(0, Convert.ToInt32(OffsetTxtBox.Text));
                timer1.Interval = Convert.ToInt32(Interval) + Offset;
                MaxProgressLbl.Text = ((Interval + Offset) / 1000).ToString() + "s";
                IntervalProgressBar.Maximum = (Convert.ToInt32(Interval + Offset) / 100);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            current_ammount = 0;
            IntervalProgressBar.Value = 0;
            button1.Enabled = true;
            button2.Enabled = false;
            IntervalPanel.Enabled = true;
            PressTypePanel.Enabled = true;
        }

        private void IntervalSaveBtn_Click(object sender, EventArgs e)
        {
            Interval = Convert.ToInt32(IntervalTxtBox.Text);
            Offset = r.Next(0, Convert.ToInt32(OffsetTxtBox.Text));
            MaxProgressLbl.Text = ((Interval + Offset) / 1000).ToString() + "s";
        }

        private void KeyRdBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LeftMouseRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (LeftMouseRdBtn.Checked == true)
            {
                KeyTxtBox.Enabled = true;
            }
            else
            {
                KeyTxtBox.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            IntervalProgressBar.Increment(10);
            
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            KeyTxtBox.Text = "{ENTER}";
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void HandleHotkey()
        {
            if (button1.Enabled)
            {
                button1_Click(this, null);
            }
            else
            {
                button2_Click(this, null);
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AboutFrm aboutForm = new AboutFrm();

            aboutForm.Show();
        }

        private void KeyTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void INPUTS_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void amount1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void about_Click(object sender, EventArgs e)
        {
            aboutFrm = new AboutFrm();
            aboutFrm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
