using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMICalculator
{
    public partial class Form1 : Form
    {
        const string success = "Ölçüm Sonucunuz";
        const string failed = "Hatalı Giriş";
        const string info = "Bilgilendirme";
        int evalue = 102;
        int kvalue = 88;
        double weight;
        int age;
        string namesurname;
        double boy;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text.Length > 0)
            {
                age = Convert.ToInt32(textBox2.Text);
                if (textBox1.Text.Length > 0)
                {
                    namesurname = Convert.ToString(textBox1.Text);
                }
                if (textBox3.Text.Length > 0)
                {
                    weight = Convert.ToDouble(textBox3.Text);
                }
                if (textBox4.Text.Length > 0)
                {
                    boy = Convert.ToDouble(textBox4.Text);
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir değer girerek tekrar deneyiniz", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            double bmi;
            bmi = weight / (boy * boy);
            label15.Text = Convert.ToString(bmi);

            string result;
            if (bmi < 18.5)
            {
                result = "Zayıf";
            }
            else if (bmi < 25)
            {
                result = "Normal";
            }
            else if (bmi < 30)
            {
                result = "Kilolu";
            }
            else if (bmi > 30)
            {
                result = "Obez";
            }
            else
            {
                result = "Değer Girilmedi";
            }
            label16.Text = Convert.ToString(result);

            if (string.IsNullOrEmpty(namesurname))
            {
                MessageBox.Show("Lütfen adınızı ve soyadınızı girerek işleme başlayınız", failed, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Lütfen yaşınızı girerek işleme devam ediniz.", failed, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (age < 19 && age >= 0)
            {
                MessageBox.Show("Sağlıklı bir hesaplama yapılması için yaşınızın en an 19 olması gerekmektedir", "Hatalı Giriş (Yaş)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (weight > 999 || weight < 0)
            {
                MessageBox.Show("Lütfen geçerli bir değer girerek tekrar deneyiniz", "Hatalı Giriş (Kilo)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Sayın " + namesurname + " sonucunuz başarılı bir şekilde size bildirildi. Sağlıklı günler dileriz.", success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (age <= 24 && age >= 19)
            {
                MessageBox.Show("Yaş aralığınız (19-24) için vücut kitle endeksiniz 19-24 arasında olmalıdır.", info, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (age <= 34 && age >= 25)
            {
                MessageBox.Show("Yaş aralığınız (25-34) için vücut kitle endeksiniz 20-25 arasında olmalıdır.", info, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (age <= 54 && age >= 45)
            {
                MessageBox.Show("Yaş aralığınız (45-54) için vücut kitle endeksiniz 22-27 arasında olmalıdır.", info, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (age <= 64 && age >= 55)
            {
                MessageBox.Show("Yaş aralığınız (55-64) için vücut kitle endeksiniz 23-28 arasında olmalıdır.", info, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (age >= 65)
            {
                MessageBox.Show("Yaş aralığınız (65 yaş ve üzeri) için vücut kitle endeksiniz 24-29 arasında olmalıdır.", info, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label13.Text = "Erkek";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label13.Text = "Kadın";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label14.Text = textBox3.Text;
            if (textBox3.Text.Length >= 999 || textBox2.Text.Length == 0)
            {
                MessageBox.Show("Lütfen geçerli bir değer girerek tekrar deneyiniz", "Hatalı Giriş (Kilo)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z'
                || e.KeyChar == '"' || e.KeyChar == '!' || e.KeyChar == ' ' || e.KeyChar == '#'
                || e.KeyChar == '$' || e.KeyChar == '½' || e.KeyChar == '{' || e.KeyChar == '['
                || e.KeyChar == ']' || e.KeyChar == '}' || e.KeyChar == '<' || e.KeyChar == '>'
                || e.KeyChar == '#' || e.KeyChar == '|' || e.KeyChar == 'é' || e.KeyChar == '!'
                || e.KeyChar == '^' || e.KeyChar == '%' || e.KeyChar == '&' || e.KeyChar == '.'
                || e.KeyChar == '/' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == '='
                || e.KeyChar == '?' || e.KeyChar == '_' || e.KeyChar == 'ş' || e.KeyChar == ';'
                || e.KeyChar == ':' || e.KeyChar == ',' || e.KeyChar == '£' || e.KeyChar == '\\'
                || e.KeyChar == 'ç' || e.KeyChar == 'ö' || e.KeyChar == 'ı' || e.KeyChar == 'ğ'
                || e.KeyChar == 'ü' || e.KeyChar == '+' || e.KeyChar == '*' || e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z'
                || e.KeyChar == '"' || e.KeyChar == '!' || e.KeyChar == ' ' || e.KeyChar == '#'
                || e.KeyChar == '$' || e.KeyChar == '½' || e.KeyChar == '{' || e.KeyChar == '['
                || e.KeyChar == ']' || e.KeyChar == '}' || e.KeyChar == '<' || e.KeyChar == '>'
                || e.KeyChar == '#' || e.KeyChar == '|' || e.KeyChar == 'é' || e.KeyChar == '!'
                || e.KeyChar == '^' || e.KeyChar == '%' || e.KeyChar == '&' || e.KeyChar == '.'
                || e.KeyChar == '/' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == '='
                || e.KeyChar == '?' || e.KeyChar == '_' || e.KeyChar == 'ş' || e.KeyChar == ';'
                || e.KeyChar == ':' || e.KeyChar == ',' || e.KeyChar == '£' || e.KeyChar == '\\'
                || e.KeyChar == 'ç' || e.KeyChar == 'ö' || e.KeyChar == 'ı' || e.KeyChar == 'ğ'
                || e.KeyChar == 'ü' || e.KeyChar == '+' || e.KeyChar == '*' || e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z'
                || e.KeyChar == '"' || e.KeyChar == '!' || e.KeyChar == ' ' || e.KeyChar == '#'
                || e.KeyChar == '$' || e.KeyChar == '½' || e.KeyChar == '{' || e.KeyChar == '['
                || e.KeyChar == ']' || e.KeyChar == '}' || e.KeyChar == '<' || e.KeyChar == '>'
                || e.KeyChar == '#' || e.KeyChar == '|' || e.KeyChar == 'é' || e.KeyChar == '!'
                || e.KeyChar == '^' || e.KeyChar == '%' || e.KeyChar == '&' || e.KeyChar == '.'
                || e.KeyChar == '/' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == '='
                || e.KeyChar == '?' || e.KeyChar == '_' || e.KeyChar == 'ş' || e.KeyChar == ';'
                || e.KeyChar == ':' || e.KeyChar == ',' || e.KeyChar == '£' || e.KeyChar == '\\'
                || e.KeyChar == 'ç' || e.KeyChar == 'ö' || e.KeyChar == 'ı' || e.KeyChar == 'ğ'
                || e.KeyChar == 'ü' || e.KeyChar == '+' || e.KeyChar == '*' || e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z'
              || e.KeyChar == '"' || e.KeyChar == '!' || e.KeyChar == ' ' || e.KeyChar == '#'
              || e.KeyChar == '$' || e.KeyChar == '½' || e.KeyChar == '{' || e.KeyChar == '['
              || e.KeyChar == ']' || e.KeyChar == '}' || e.KeyChar == '<' || e.KeyChar == '>'
              || e.KeyChar == '#' || e.KeyChar == '|' || e.KeyChar == 'é' || e.KeyChar == '!'
              || e.KeyChar == '^' || e.KeyChar == '%' || e.KeyChar == '&' || e.KeyChar == '.'
              || e.KeyChar == '/' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == '='
              || e.KeyChar == '?' || e.KeyChar == '_' || e.KeyChar == 'ş' || e.KeyChar == ';'
              || e.KeyChar == ':' || e.KeyChar == '£' || e.KeyChar == '\\' || e.KeyChar == '-'
              || e.KeyChar == 'ç' || e.KeyChar == 'ö' || e.KeyChar == 'ı' || e.KeyChar == 'ğ'
              || e.KeyChar == 'ü' || e.KeyChar == '+' || e.KeyChar == '*')
            {
                e.Handled = true;
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen boy ölçünüzü metre cinsinden giriniz (Değeriniz arasına lütfen virgül koyunuz.)", info, MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (textBox4.Text.Length >= 500 || textBox2.Text.Length == 0)
            {
                MessageBox.Show("Lütfen geçerli bir değer girerek tekrar deneyiniz", "Hatalı Giriş (Boy Ölçüsü)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9'
             || e.KeyChar == '"' || e.KeyChar == '!' || e.KeyChar == '#'
             || e.KeyChar == '$' || e.KeyChar == '½' || e.KeyChar == '{' || e.KeyChar == '['
             || e.KeyChar == ']' || e.KeyChar == '}' || e.KeyChar == '<' || e.KeyChar == '>'
             || e.KeyChar == '#' || e.KeyChar == '|' || e.KeyChar == 'é' || e.KeyChar == '!'
             || e.KeyChar == '^' || e.KeyChar == '%' || e.KeyChar == '&' || e.KeyChar == '.'
             || e.KeyChar == '/' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == '='
             || e.KeyChar == '?' || e.KeyChar == '_' || e.KeyChar == 'ş' || e.KeyChar == ';'
             || e.KeyChar == ':' || e.KeyChar == '£' || e.KeyChar == '\\' || e.KeyChar == '-'
             || e.KeyChar == '+' || e.KeyChar == '*')
            {
                e.Handled = true;
            }
        }
    }
}
