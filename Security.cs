using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap.Net
{
    public partial class Security : Form
    {
        public Security()
        {
            InitializeComponent();
        }

        private void BT1_Click(object sender, EventArgs e)
        {
            if(TBCode.Text.Length < 4)
            {
                TBCode.Text += ((Button)sender).Text;
            }
        }

        //private void BT2_Click(object sender, EventArgs e)
        //{
        //    TBCode.PasswordChar = '*';
        //    TBCode.Text += BT2.Text;
        //}

        //private void BT3_Click(object sender, EventArgs e)
        //{
        //    TBCode.PasswordChar = '*';
        //    TBCode.Text += BT3.Text;
        //}

        //private void BT4_Click(object sender, EventArgs e)
        //{
        //    TBCode.PasswordChar = '*';
        //    TBCode.Text += BT4.Text;
        //}

        //private void BT5_Click(object sender, EventArgs e)
        //{
        //    TBCode.PasswordChar = '*';
        //    TBCode.Text += BT5.Text;
        //}

        //private void BT6_Click(object sender, EventArgs e)
        //{
        //    TBCode.PasswordChar = '*';
        //    TBCode.Text += BT6.Text;
        //}

        //private void BT7_Click(object sender, EventArgs e)
        //{
        //    TBCode.PasswordChar = '*';
        //    TBCode.Text += BT7.Text;
        //}

        //private void BT8_Click(object sender, EventArgs e)
        //{
        //    TBCode.PasswordChar = '*';
        //    TBCode.Text += BT8.Text;
        //}

        //private void BT9_Click(object sender, EventArgs e)
        //{
        //    TBCode.PasswordChar = '*';
        //    TBCode.Text += BT9.Text;
        //}

        //private void BT0_Click(object sender, EventArgs e)
        //{
        //    TBCode.PasswordChar = '*';
        //    TBCode.Text += BT0.Text;
        //}

        private void BTBackspace_Click(object sender, EventArgs e)
        {
            if(TBCode.Text.Length == 0)
            {
                return;
            }
            else
            {
                TBCode.Text = TBCode.Text.Remove(TBCode.Text.Length - 1);
            }
        }

        private void BTEnter_Click(object sender, EventArgs e)
        {
            string t;
            if (TBCode.Text == "1806")
            {
                string path = "E:\\.Net\\BaiTap.Net\\102190037.txt";
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);
                fs.Position = fs.Length;
                StreamWriter sw = new StreamWriter(fs);
                t = " ❉  " + DateTime.Now.ToString() + "                    " + "Access Granted";
                sw.WriteLine(" ❉  " + DateTime.Now.ToString() + "                    " + "Access Granted");
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            else if(TBCode.Text.Length == 1)
            {
                string path = "E:\\.Net\\BaiTap.Net\\102190037.txt";
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);
                fs.Position = fs.Length;
                StreamWriter sw = new StreamWriter(fs);
                t = " ✥  " + DateTime.Now.ToString() + "                    " + "Restricted Access";
                sw.WriteLine(" ✥  " + DateTime.Now.ToString() + "                    " + "Restricted Access");
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            else
            {
                string path = "E:\\.Net\\BaiTap.Net\\102190037.txt";
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);
                fs.Position = fs.Length;
                StreamWriter sw = new StreamWriter(fs);
                t = " ✤  " + DateTime.Now.ToString() + "                    " + "Access Denied";
                sw.WriteLine(" ✤  " + DateTime.Now.ToString() + "                    " + "Access Denied");
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            LB1.Items.Add(t);
            TBCode.Clear();
        }

        private void TBCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            } 
            if(e.KeyChar == (Char)Keys.Enter) // hoặc e.KeyChar == (Char)13 == Convert.ToInt32(e.KeyChar)
            {
                string t;
                if (TBCode.Text == "1806")
                {
                    string path = "E:\\.Net\\BaiTap.Net\\102190037.txt";
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);
                    fs.Position = fs.Length;
                    StreamWriter sw = new StreamWriter(fs);
                    t = " ❉  " + DateTime.Now.ToString() + "                    " + "Access Granted";
                    sw.WriteLine(" ❉  " + DateTime.Now.ToString() + "                    " + "Access Granted");
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
                else if (TBCode.Text.Length == 1)
                {
                    string path = "E:\\.Net\\BaiTap.Net\\102190037.txt";
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);
                    fs.Position = fs.Length;
                    StreamWriter sw = new StreamWriter(fs);
                    t = " ✥  " + DateTime.Now.ToString() + "                    " + "Restricted Access";
                    sw.WriteLine(" ✥  " + DateTime.Now.ToString() + "                    " + "Restricted Access");
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
                else
                {
                    string path = "E:\\.Net\\BaiTap.Net\\102190037.txt";
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);
                    fs.Position = fs.Length;
                    StreamWriter sw = new StreamWriter(fs);
                    t = " ✤  " + DateTime.Now.ToString() + "                    " + "Access Denied";
                    sw.WriteLine(" ✤  " + DateTime.Now.ToString() + "                    " + "Access Denied");
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
                LB1.Items.Add(t);
                TBCode.Clear();
            }    
        }

        private void Security_Load(object sender, EventArgs e)
        {
            string path = "E:\\.Net\\BaiTap.Net\\102190037.txt";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string t;
            while((t = sr.ReadLine()) != null)
            {
                LB1.Items.Add(t);
            }   
            sr.Close();
            fs.Close();
        }

    }
}
