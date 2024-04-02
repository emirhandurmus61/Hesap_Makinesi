using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi2
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekrantemizlenecekmi;
        private int _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void rakam1button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) 
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0" ) ekranlabel.Text = "";
            ekranlabel.Text += "1";
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "2";
        }

        private void rakam3button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "3";
        }

        private void rakam4button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "4";
        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "5";
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "6";
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "7";
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "8";
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranlabel.Text = "";
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "9";
        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int ikincisayı = Convert.ToInt32(ekranlabel.Text);
            int sonuc = 0;
            switch (_islem) 
            {
                case '+':
                    sonuc = _ilksayi + ikincisayı;
                    break;
            }
            switch (_islem)
            {
                case '-':
                    sonuc = _ilksayi - ikincisayı;
                    break;
            }
            switch (_islem)
            {
                case '*':
                    sonuc = _ilksayi * ikincisayı;
                    break;
            }
            switch (_islem)
            {
                case '/':
                    sonuc = _ilksayi / ikincisayı;
                    break;
            }
            ekranlabel.Text = Convert.ToString(sonuc);
        }

        private void eksi_button_click_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void çarpı_button_click_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void bolum_button_click_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "0";
        }
    }
}
