using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("WELCOME TO MARMARAY");
            button1.Visible = false;
            button1.Enabled = false;
            axWindowsMediaPlayer1.URL = "C:\\Users\\PC\\OneDrive\\Belgeler\\Ses Kayıtları\\Kayıt (8).mp3";
            timer2.Enabled = true;
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer2.Visible = false;
            axWindowsMediaPlayer3.Visible = false;
            axWindowsMediaPlayer4.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;

        }

        int sn = 0;
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
            timer2.Enabled = true;
            label3.Text = comboBox1.Text;
            label4.Text = comboBox2.Text;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            pictureBox2.BackColor = Color.Transparent;
            timer3.Enabled = true;
            timer3.Start();


            if (comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                axWindowsMediaPlayer2.URL = "C:\\Users\\PC\\OneDrive\\Belgeler\\Ses Kayıtları\\Kayıt (6).mp3";
                label7.Text = "You Can Change The Metro-Line M4                     ";
            }

            if (comboBox2.Text == "ÜSKÜDAR")
            {
                axWindowsMediaPlayer2.URL = "C:\\Users\\PC\\OneDrive\\Belgeler\\Ses Kayıtları\\Kayıt (7).mp3";
                label7.Text = "You Can Change The Metro-Line M5                     ";

            }

            if (comboBox2.Text == "GEBZE")
            {
                axWindowsMediaPlayer2.URL = "C:\\Users\\PC\\Downloads\\prj_7253510_bacb3955a7547cfc4f8975246ab49740_1695117569.mp3";
                label7.Text = "You Can Change The High Speed Train                   ";
            }

            if (comboBox2.Text == "PENDİK")
            {
                axWindowsMediaPlayer2.URL = "C:\\Users\\PC\\Downloads\\prj_7253925_bacb3955a7547cfc4f8975246ab49740_1695118476.mp3";
                label7.Text = "You Can Change The High Speed Train and Ada Express                ";
            }

            if (comboBox2.Text == "BOSTANCI")
            {
                axWindowsMediaPlayer2.URL = "C:\\Users\\PC\\Downloads\\prj_7253925_bacb3955a7547cfc4f8975246ab49740_1695118476.mp3";
                label7.Text = "You Can Change The High Speed Train and Ada Express                ";
            }

            if (comboBox2.Text == "SİRKECİ")
            {
                axWindowsMediaPlayer2.URL = "C:\\Users\\PC\\Downloads\\prj_7254055_bacb3955a7547cfc4f8975246ab49740_1695118780.mp3";
                label7.Text = "You Can Change The Tramvay Line T1                    ";
            }

            if (comboBox2.Text == "YENİKAPI")
            {
                axWindowsMediaPlayer2.URL = "C:\\Users\\PC\\Downloads\\prj_7254130_bacb3955a7547cfc4f8975246ab49740_1695118952.mp3";
                label7.Text = "You Can Change The Metro-Line M1 and M2                  ";
            }

            if (comboBox2.Text == "BAKIRKÖY")
            {
                axWindowsMediaPlayer2.URL = "C:\\Users\\PC\\Downloads\\prj_7254183_bacb3955a7547cfc4f8975246ab49740_1695119121.mp3";
                label7.Text = "You Can Change The Metro-Line M3 and High Speed Train                     ";
            }

            if (comboBox2.Text == "ATAKÖY")
            {
                axWindowsMediaPlayer2.URL = "C:\\Users\\PC\\Downloads\\prj_7254263_bacb3955a7547cfc4f8975246ab49740_1695119276.mp3";
                label7.Text = "You Can The Metro-Line M9                                  ";
            }

            if (comboBox2.Text == "HALKALI")
            {
                axWindowsMediaPlayer2.URL = "C:\\Users\\PC\\Downloads\\prj_7254322_bacb3955a7547cfc4f8975246ab49740_1695119434.mp3";
                label7.Text = "You Can The Metro-Line M1 and High Speed Train                              ";
            }





            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "DARICA")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";

            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";

            }



            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "OSMANGAZİ")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";

            }


            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";

            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "GEBZE TEK. UNİ.")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";

            }


            if (comboBox1.Text == "GEBZE TEK. UNİ." && comboBox2.Text == "GEBZE")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";

            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "ÇAYIROVA")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";

            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";

            }

            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "TUZLA")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";

            }


            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }



            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";

            }


            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";

            }


            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";

            }


            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";

            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";

            }


            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "KAYNARCA")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";

            }


            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }

            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "31 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";

            }


            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "31 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }

            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";

            }


            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";

            }


            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }

            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";

            }


            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }

            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";

            }


            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";

            }


            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";

            }


            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";

            }


            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";

            }


            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";

            }


            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";

            }


            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }



            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";

            }


            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";

            }


            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";

            }


            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }

            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";

            }


            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";

            }


            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";

            }


            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }

            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "73 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";

            }


            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "73 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "77 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";

            }


            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "77 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";
            }

            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "79 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "30 DURAK";

            }


            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "79 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "30 DURAK";
            }



            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "82 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "31 DURAK";

            }


            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "82 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "31 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "84 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "32 DURAK";

            }


            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "84 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "32 DURAK";
            }



            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "87 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "33 DURAK";

            }


            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "87 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "33 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "90 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "34 DURAK";

            }


            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "90 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "34 DURAK";
            }

            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "92 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "35 DURAK";

            }


            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "92 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "35 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "100 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "36 DURAK";

            }


            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "100 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "36 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "103 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "37 DURAK";

            }


            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "103 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "37 DURAK";
            }



            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "106 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "38 DURAK";

            }


            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "106 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "38 DURAK";
            }



            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "107 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "39 DURAK";

            }


            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "107 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "39 DURAK";
            }

            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "108 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "40 DURAK";

            }


            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "108 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "40 DURAK";
            }

            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "110 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "41 DURAK";

            }


            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "110 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "41 DURAK";
            }


            if (comboBox1.Text == "GEBZE" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "111 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "42 DURAK";

            }


            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "GEBZE")
            {
                label5.Text = "111 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "42 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "OSMANGAZİ")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";

            }


            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "DARICA")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }



            if (comboBox1.Text == "DARICA" && comboBox2.Text == "GEBZE TEK. UNİ.")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";

            }


            if (comboBox1.Text == "GEBZE TEK. UNİ." && comboBox2.Text == "DARICA")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }



            if (comboBox1.Text == "DARICA" && comboBox2.Text == "ÇAYIROVA")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";

            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "DARICA")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }





            if (comboBox1.Text == "DARICA" && comboBox2.Text == "TUZLA")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";

            }


            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "DARICA")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";

            }


            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "DARICA")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";

            }


            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "DARICA")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";

            }


            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "DARICA")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }

            if (comboBox1.Text == "DARICA" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";

            }


            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "DARICA")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }



            if (comboBox1.Text == "DARICA" && comboBox2.Text == "KAYNARCA")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";

            }


            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "DARICA")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "28 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";

            }


            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "DARICA")
            {
                label5.Text = "28 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";

            }


            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "DARICA")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }

            if (comboBox1.Text == "DARICA" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";

            }


            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "DARICA")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";

            }


            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "DARICA")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }

            if (comboBox1.Text == "DARICA" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";

            }


            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "DARICA")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }




            if (comboBox1.Text == "DARICA" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";

            }


            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "DARICA")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }




            if (comboBox1.Text == "DARICA" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";

            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "DARICA")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }




            if (comboBox1.Text == "DARICA" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";

            }


            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "DARICA")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }




            if (comboBox1.Text == "DARICA" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";

            }


            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "DARICA")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }



            if (comboBox1.Text == "DARICA" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";

            }


            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "DARICA")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }



            if (comboBox1.Text == "DARICA" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";


            }

            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "DARICA")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";


            }

            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "DARICA")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }



            if (comboBox1.Text == "DARICA" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";


            }

            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "DARICA")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";


            }

            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "DARICA")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";


            }

            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "DARICA")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";


            }

            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "DARICA")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }



            if (comboBox1.Text == "DARICA" && comboBox2.Text == " AYRILIK ÇEŞMESİ")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";


            }

            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "DARICA")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "70 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";


            }

            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "DARICA")
            {
                label5.Text = "70 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";


            }

            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "DARICA")
            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "77 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";


            }

            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "DARICA")
            {
                label5.Text = "77 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";
            }



            if (comboBox1.Text == "DARICA" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "79 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "30 DURAK";


            }

            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "DARICA")
            {
                label5.Text = "79 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "30 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "81 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "31 DURAK";


            }

            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "DARICA")

            {

                label5.Text = "81 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "31 DURAK";
            }

            if (comboBox1.Text == "DARICA" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "84 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "32 DURAK";


            }

            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "DARICA")

            {

                label5.Text = "84 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "32 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "87 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "33 DURAK";


            }

            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "DARICA")

            {

                label6.Text = "29.99 TL";
                label5.Text = "87 DAKİKA";
                label8.Text = "33 DURAK";
            }



            if (comboBox1.Text == "DARICA" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "90 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "34 DURAK";


            }

            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "DARICA")

            {

                label5.Text = "90 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "34 DURAK";
            }



            if (comboBox1.Text == "DARICA" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "98 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "35 DURAK";


            }

            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "DARICA")

            {

                label5.Text = "98 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "35 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "100 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "36 DURAK";


            }

            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "DARICA")

            {

                label5.Text = "100 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "36 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "103 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "37 DURAK";


            }

            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "DARICA")

            {

                label5.Text = "103 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "37 DURAK";
            }




            if (comboBox1.Text == "DARICA" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "104 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "38 DURAK";


            }

            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "DARICA")

            {

                label5.Text = "104 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "38 DURAK";
            }





            if (comboBox1.Text == "DARICA" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "106 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "39 DURAK";


            }

            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "DARICA")

            {

                label5.Text = "106 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "39 DURAK";
            }


            if (comboBox1.Text == "DARICA" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "107 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "40 DURAK";


            }

            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "DARICA")

            {

                label5.Text = "107 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "40 DURAK";
            }




            if (comboBox1.Text == "DARICA" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "108 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "41 DURAK";


            }

            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "DARICA")

            {

                label5.Text = "108 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "41 DURAK";
            }


            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "GEBZE TEK. UNİ.")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";


            }

            if (comboBox1.Text == "GEBZE TEK. UNİ." && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }



            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "ÇAYIROVA")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";


            }

            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }



            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "TUZLA")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";


            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }




            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";


            }

            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }


            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";


            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }





            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";


            }

            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }



            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";


            }

            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }



            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "KAYNARCA")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";


            }

            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }




            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "25 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";


            }

            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "25 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }




            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";


            }

            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }




            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";


            }

            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }


            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";


            }

            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }



            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";


            }



            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }




            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";


            }



            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }




            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";


            }

            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }





            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";


            }

            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }



            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";


            }

            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }






            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";

            }

            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }



            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";

            }

            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }



            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";

            }

            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }



            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";

            }

            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }




            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";

            }

            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }




            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";

            }

            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }



            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";

            }

            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }



            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";

            }

            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }




            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "68 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";

            }

            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "68 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }




            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";

            }

            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "71 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }






            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";

            }

            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "74 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }




            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "77 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";

            }

            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "77 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";
            }



            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "79 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "30 DURAK";

            }

            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "79 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "30 DURAK";
            }


            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "82 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "31 DURAK";

            }

            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "82 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "31 DURAK";
            }



            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "84 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "32 DURAK";

            }

            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "84 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "32 DURAK";
            }





            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "87 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "33 DURAK";

            }

            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "87 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "33 DURAK";
            }




            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "95 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "34 DURAK";

            }

            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "95 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "34 DURAK";
            }



            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "98 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "35 DURAK";

            }

            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "98 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "35 DURAK";
            }





            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "100 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "36 DURAK";

            }

            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "100 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "36 DURAK";
            }




            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "101 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "37 DURAK";

            }

            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "101 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "37 DURAK";
            }



            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "103 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "38 DURAK";

            }

            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "103 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "38 DURAK";
            }



            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "105 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "39 DURAK";

            }

            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "105 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "39 DURAK";
            }



            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "103 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "38 DURAK";

            }

            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "103 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "38 DURAK";
            }


            if (comboBox1.Text == "OSMANGAZİ" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "106 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "40 DURAK";

            }

            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "OSMANGAZİ")

            {

                label5.Text = "106 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "40 DURAK";
            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "ÇAYIROVA")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";

            }

            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "FATİH")

            {

                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "TUZLA")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";

            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "FATİH")

            {

                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }



            if (comboBox1.Text == "FATİH" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";

            }

            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "FATİH")

            {

                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }



            if (comboBox1.Text == "FATİH" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";

            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "FATİH")

            {

                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";

            }

            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "FATİH")

            {

                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }



            if (comboBox1.Text == "FATİH" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";

            }

            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "FATİH")

            {

                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }




            if (comboBox1.Text == "FATİH" && comboBox2.Text == "KAYNARCA")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";

            }

            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "FATİH")

            {

                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }



            if (comboBox1.Text == "FATİH" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "23 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "8 DURAK";

            }

            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "FATİH")

            {
                label5.Text = "23 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "8 DURAK";

            }




            if (comboBox1.Text == "FATİH" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "9 DURAK";

            }

            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "FATİH")

            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "9 DURAK";

            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "KARTAL")

            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "10 DURAK";

            }

            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "FATİH")

            {

                label5.Text = "26 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "10 DURAK";

            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "BAŞAK")

            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "11 DURAK";

            }

            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "FATİH")

            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "11 DURAK";

            }



            if (comboBox1.Text == "FATİH" && comboBox2.Text == "ATALAR")

            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "12 DURAK";

            }



            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "FATİH")

            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "12 DURAK";

            }



            if (comboBox1.Text == "FATİH" && comboBox2.Text == "CEVİZLİ")

            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "13 DURAK";

            }


            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "FATİH")

            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "13 DURAK";

            }



            if (comboBox1.Text == "FATİH" && comboBox2.Text == "MALTEPE")

            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "14 DURAK";

            }


            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "FATİH")

            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "14 DURAK";

            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "SÜREYYAPLAJI")

            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "15 DURAK";

            }


            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "FATİH")

            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "15 DURAK";

            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "İDEALTEPE")

            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "16 DURAK";

            }

            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "FATİH")

            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "16 DURAK";

            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "KÜÇÜKYALI")

            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "17 DURAK";

            }


            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "FATİH")

            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "17 DURAK";

            }



            if (comboBox1.Text == "FATİH" && comboBox2.Text == "BOSTANCI")

            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "18 DURAK";

            }

            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "FATİH")

            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "18 DURAK";

            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "SUADİYE")

            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "19 DURAK";

            }

            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "FATİH")

            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "19 DURAK";

            }

            if (comboBox1.Text == "FATİH" && comboBox2.Text == "ERENKÖY")

            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "20 DURAK";

            }

            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "FATİH")

            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "20 DURAK";

            }

            if (comboBox1.Text == "FATİH" && comboBox2.Text == "GÖZTEPE")

            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "21 DURAK";

            }


            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "FATİH")

            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "21 DURAK";

            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "FENERYOLU")

            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "22 DURAK";

            }

            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "FATİH")

            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "22 DURAK";

            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")

            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "23 DURAK";

            }

            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "FATİH")

            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "23 DURAK";

            }

            if (comboBox1.Text == "FATİH" && comboBox2.Text == "AYRILIK ÇEŞMESİ")

            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "24 DURAK";

            }


            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "FATİH")

            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "24 DURAK";

            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "ÜSKÜDAR")

            {
                label5.Text = "65 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "25 DURAK";

            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "FATİH")

            {
                label5.Text = "65 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "25 DURAK";

            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "SİRKECİ")

            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "26 DURAK";


            }

            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "FATİH")

            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "26 DURAK";

            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "YENİKAPI")

            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "27 DURAK";


            }


            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "FATİH")

            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "27 DURAK";


            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "KAZLIÇEŞME")

            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "28 DURAK";


            }

            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "FATİH")

            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "28 DURAK";


            }



            if (comboBox1.Text == "FATİH" && comboBox2.Text == "ZEYTİNBURNU")

            {
                label5.Text = "77 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "29 DURAK";
            }



            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "FATİH")

            {
                label5.Text = "77 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "29 DURAK";


            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "YENİMAHALLE")

            {
                label5.Text = "79 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "30 DURAK";
            }


            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "FATİH")

            {
                label5.Text = "79 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "30 DURAK";
            }

            if (comboBox1.Text == "FATİH" && comboBox2.Text == "BAKIRKÖY")

            {
                label5.Text = "82 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "31 DURAK";
            }


            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "FATİH")

            {
                label5.Text = "82 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "31 DURAK";
            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "ATAKÖY")

            {
                label5.Text = "84 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "32 DURAK";
            }

            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "FATİH")

            {
                label5.Text = "84 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "32 DURAK";
            }

            if (comboBox1.Text == "FATİH" && comboBox2.Text == "YEŞİLYURT")

            {
                label5.Text = "92 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "33 DURAK";
            }

            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "FATİH")

            {
                label5.Text = "92 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "33 DURAK";
            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "YEŞİLKÖY")

            {
                label5.Text = "95 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "34 DURAK";
            }


            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "FATİH")

            {
                label5.Text = "95 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "34 DURAK";
            }

            if (comboBox1.Text == "FATİH" && comboBox2.Text == "AKVARYUM")

            {
                label5.Text = "98 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "35 DURAK";
            }



            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "FATİH")

            {
                label5.Text = "98 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "35 DURAK";
            }



            if (comboBox1.Text == "FATİH" && comboBox2.Text == "FLORYA")

            {
                label5.Text = "99 DAKİKA";
                label6.Text = "33.2";
                label8.Text = "36 DURAK";
            }

            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "FATİH")

            {
                label5.Text = "99 DAKİKA";
                label6.Text = "33.2";
                label8.Text = "36 DURAK";
            }




            if (comboBox1.Text == "FATİH" && comboBox2.Text == "KÜÇÜKÇEKMECE")

            {
                label5.Text = "100 DAKİKA";
                label6.Text = "33.2";
                label8.Text = "37 DURAK";
            }



            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "FATİH")

            {
                label5.Text = "100 DAKİKA";
                label6.Text = "33.2";
                label8.Text = "37 DURAK";
            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "MUSTAFA KEMAL")

            {
                label5.Text = "102 DAKİKA";
                label6.Text = "33.2";
                label8.Text = "38 DURAK";
            }



            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "FATİH")

            {
                label5.Text = "102 DAKİKA";
                label6.Text = "33.2";
                label8.Text = "38 DURAK";
            }


            if (comboBox1.Text == "FATİH" && comboBox2.Text == "HALKALI")

            {
                label5.Text = "103 DAKİKA";
                label6.Text = "33.2";
                label8.Text = "39 DURAK";
            }

            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "FATİH")

            {
                label5.Text = "103 DAKİKA";
                label6.Text = "33.2";
                label8.Text = "39 DURAK";
            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15";
                label8.Text = "1 DURAK";
            }


            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15";
                label8.Text = "1 DURAK";
            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15";
                label8.Text = "2 DURAK";
            }



            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15";
                label8.Text = "2 DURAK";
            }



            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "AYDINTEPE")

            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15";
                label8.Text = "3 DURAK";
            }


            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15";
                label8.Text = "3 DURAK";
            }



            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "GÜZELYALI")

            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15";
                label8.Text = "4 DURAK";
            }

            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15";
                label8.Text = "4 DURAK";
            }

            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "TERSANE")

            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15";
                label8.Text = "5 DURAK";
            }


            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15";
                label8.Text = "5 DURAK";
            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15";
                label8.Text = "6 DURAK";
            }

            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "PENDİK")

            {
                label5.Text = "20 DAKİKA";
                label6.Text = "15";
                label8.Text = "7 DURAK";
            }


            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "20 DAKİKA";
                label6.Text = "15";
                label8.Text = "7 DURAK";
            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "YUNUS")

            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "8 DURAK";
            }

            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "8 DURAK";

            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "KARTAL")

            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "9 DURAK";
            }

            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "9 DURAK";
            }




            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "BAŞAK")

            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "10 DURAK";
            }



            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "10 DURAK";
            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "ATALAR")

            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "11 DURAK";
            }


            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "11 DURAK";
            }

            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "CEVİZLİ")

            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "12 DURAK";
            }


            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "12 DURAK";
            }

            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "MALTEPE")

            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "13 DURAK";
            }


            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "13 DURAK";
            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "SÜREYYAPLAJI")

            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "14 DURAK";
            }

            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "14 DURAK";
            }

            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "İDEALTEPE")

            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "15 DURAK";
            }

            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "15 DURAK";
            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "KÜÇÜKYALI")

            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "16 DURAK";
            }

            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "16 DURAK";
            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "BOSTANCI")

            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "17 DURAK";
            }



            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "ÇAYIROVA")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "17 DURAK";
            }

            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "SUADİYE")

            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "18 DURAK";
            }

            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "ERENKÖY")

            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "19 DURAK";
            }

            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "19 DURAK";
            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "GÖZTEPE")

            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "20 DURAK";
            }

            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "20 DURAK";

            }

            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "FENERYOLU")

            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "21 DURAK";
            }



            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "21 DURAK";
            }

            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")

            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "22 DURAK";
            }


            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "22 DURAK";
            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "AYRILIK ÇEŞMESİ")

            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "23 DURAK";
            }


            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "23 DURAK";
            }

            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "ÜSKÜDAR")

            {
                label5.Text = "62 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "62 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "24 DURAK";
            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "SİRKECİ")

            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "25 DURAK";
            }


            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "25 DURAK";
            }



            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "YENİKAPI")

            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "26 DURAK";
            }



            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "26 DURAK";
            }



            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "KAZLIÇEŞME")

            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "27 DURAK";
            }


            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "ÇAYIROVA")

            {
                label6.Text = "25.68";
                label5.Text = "69 DAKİKA";
                label8.Text = "27 DURAK";
            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "ZEYTİNBURNU")

            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "28 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "28 DURAK";
            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "YENİMAHALLE")

            {
                label5.Text = "77 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "29 DURAK";
            }


            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "77 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "29 DURAK";
            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "BAKIRKÖY")

            {
                label5.Text = "79 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "30 DURAK";
            }


            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "79 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "30 DURAK";
            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "ATAKÖY")

            {
                label5.Text = "82 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "31 DURAK";
            }

            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "82 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "31 DURAK";
            }

            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "YEŞİLYURT")

            {
                label5.Text = "90 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "32 DURAK";
            }



            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "90 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "32 DURAK";
            }
            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "YEŞİLKÖY")

            {
                label5.Text = "92 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "33 DURAK";
            }


            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "92 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "33 DURAK";
            }


            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "AKVARYUM")

            {
                label5.Text = "95 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "34 DURAK";
            }


            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "95 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "34 DURAK";
            }



            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "FLORYA")

            {
                label5.Text = "96 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "35 DURAK";
            }

            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "96 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "35 DURAK";
            }

            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "KÜÇÜKÇEKMECE")

            {
                label5.Text = "98 DAKİKA";
                label6.Text = "33.2";
                label8.Text = "36 DURAK";
            }



            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "98 DAKİKA";
                label6.Text = "33.2";
                label8.Text = "36 DURAK";
            }

            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "MUSTAFA KEMAL")

            {
                label5.Text = "99 DAKİKA";
                label6.Text = "33.2";
                label8.Text = "37 DURAK";
            }


            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "99 DAKİKA";
                label6.Text = "33.2";
                label8.Text = "37 DURAK";
            }

            if (comboBox1.Text == "ÇAYIROVA" && comboBox2.Text == "HALKALI")

            {
                label5.Text = "100 DAKİKA";
                label6.Text = "33.2";
                label8.Text = "38 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "ÇAYIROVA")

            {
                label5.Text = "100 DAKİKA";
                label6.Text = "33.2";
                label8.Text = "38 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15";
                label8.Text = "1 DURAK";
            }

            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15";
                label8.Text = "1 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "AYDINTEPE")

            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15";
                label8.Text = "2 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "GÜZELYALI")

            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15";
                label8.Text = "3 DURAK";
            }

            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15";
                label8.Text = "3 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "TERSANE")

            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15";
                label8.Text = "4 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15";
                label8.Text = "5 DURAK";
            }


            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "PENDİK")

            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15";
                label8.Text = "6 DURAK";
            }

            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15";
                label8.Text = "6 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "YUNUS")

            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "KARTAL")

            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "8 DURAK";
            }

            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "8 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "BAŞAK")

            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "9 DURAK";
            }


            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "ATALAR")

            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "10 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "CEVİZLİ")

            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "11 DURAK";
            }


            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "MALTEPE")

            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "12 DURAK";
            }

            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "12 DURAK";
            }


            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "SÜREYYAPLAJI")

            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "13 DURAK";
            }

            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "13 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "İDEALTEPE")

            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "14 DURAK";
            }


            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "KÜÇÜKYALI")

            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "15 DURAK";
            }

            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "15 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "BOSTANCI")

            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "16 DURAK";
            }

            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "16 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "SUADİYE")

            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "17 DURAK";
            }


            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "17 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "ERENKÖY")

            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "18 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "GÖZTEPE")

            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "19 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "FENERYOLU")

            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "20 DURAK";
            }


            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "20 DURAK";
            }


            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")

            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "21 DURAK";
            }


            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "AYRILIK ÇEŞMESİ")

            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "22 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "ÜSKÜDAR")

            {
                label5.Text = "60 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "23 DURAK";
            }

            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "60 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "SİRKECİ")

            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "24 DURAK";
            }

            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "24 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "YENİKAPI")

            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "25 DURAK";
            }

            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "25 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "KAZLIÇEŞME")

            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "26 DURAK";
            }

            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "26 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "ZEYTİNBURNU")

            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "27 DURAK";
            }

            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "27 DURAK";
            }
            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "YENİMAHALLE")

            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "28 DURAK";
            }

            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68";
                label8.Text = "28 DURAK";
            }
            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "BAKIRKÖY")

            {
                label5.Text = "77 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "29 DURAK";
            }

            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "77 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "29 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "ATAKÖY")

            {
                label5.Text = "79 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "30 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "79 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "30 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "YEŞİLYURT")

            {
                label5.Text = "87 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "31 DURAK";
            }

            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "87 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "31 DURAK";
            }


            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "YEŞİLKÖY")

            {
                label5.Text = "90 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "32 DURAK";
            }

            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "90 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "32 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "AKVARYUM")

            {
                label5.Text = "92 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "33 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "92 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "33 DURAK";
            }
            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "FLORYA")

            {
                label5.Text = "94 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "34 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "94 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "34 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "KÜÇÜKÇEKMECE")

            {
                label5.Text = "95 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "35 DURAK";
            }

            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "95 DAKİKA";
                label6.Text = "29.99";
                label8.Text = "35 DURAK";
            }

            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "MUSTAFA KEMAL")

            {
                label5.Text = "97 DAKİKA";
                label6.Text = "33.2";
                label8.Text = "36 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "97 DAKİKA";
                label6.Text = "33.2";
                label8.Text = "36 DURAK";
            }


            if (comboBox1.Text == "TUZLA" && comboBox2.Text == "HALKALI")

            {
                label5.Text = "98 DAKİKA";
                label6.Text = "33.2";
                label8.Text = "37 DURAK";
            }

            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "TUZLA")

            {
                label5.Text = "98 DAKİKA";
                label6.Text = "33.2";
                label8.Text = "37 DURAK";
            }


            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "AYDINTEPE")

            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15";
                label8.Text = "1 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "GÜZELYALI")

            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15";
                label8.Text = "2 DURAK";
            }

            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15";
                label8.Text = "2 DURAK";
            }

            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "TERSANE")

            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15";
                label8.Text = "3 DURAK";
            }

            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15";
                label8.Text = "4 DURAK";
            }

            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15";
                label8.Text = "4 DURAK";
            }

            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "PENDİK")

            {
                label5.Text = "15 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }

            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "15 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "YUNUS")

            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }

            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }

            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "KARTAL")

            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }

            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "BAŞAK")

            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }

            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "ATALAR")

            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "CEVİZLİ")

            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }

            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "MALTEPE")

            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }

            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "SÜREYYAPLAJI")

            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }

            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "İDEALTEPE")

            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";

            }

            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "KÜÇÜKYALI")

            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }

            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "BOSTANCI")

            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }


            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }

            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "SUADİYE")

            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }

            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "ERENKÖY")

            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }


            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "İÇMELER")

            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }


            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }

            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }

            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "57 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "57 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }

            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }


            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }


            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }


            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }

            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }

            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }

            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "77 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "77 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";
            }

            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "84 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "30 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "84 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "30 DURAK";
            }

            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "87 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "31 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "87 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "31 DURAK";
            }


            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "90 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "32 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "90 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "32 DURAK";
            }
            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "91 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "33 DURAK";
            }

            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "91 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "33 DURAK";
            }
            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "92 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "34 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "92 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "34 DURAK";
            }

            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "94 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "35 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "94 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "35 DURAK";
            }

            if (comboBox1.Text == "İÇMELER" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "95 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "36 DURAK";
            }

            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "İÇMELER")
            {
                label5.Text = "95 DAKİKA";
                label6.Text = "33.2 TL";
                label8.Text = "36 DURAK";
            }


            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }

            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "KAYNARCA")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }

            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "12 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }

            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "12 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }

            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }

            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }

            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }

            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }

            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }

            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }

            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }

            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }

            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }

            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "AYDINTEPE")

            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }


            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "54 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "54 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }

            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }


            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }

            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }

            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }

            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }

            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }


            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }

            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }
            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "82 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";
            }

            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "82 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "84 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "30 DURAK";
            }

            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "84 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "30 DURAK";
            }
            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "87 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "31 DURAK";
            }

            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "87 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "31 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "88 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "32 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "88 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "32 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "90 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "33 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "90 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "33 DURAK";
            }

            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "91 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "34 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "91 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "34 DURAK";

            }
            if (comboBox1.Text == "AYDINTEPE" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "92 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "35 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "AYDINTEPE")
            {
                label5.Text = "92 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "35 DURAK";
            }



            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "KAYNARCA")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "9 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "9 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }

            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }

            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }


            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }

            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }

            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }

            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }

            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }

            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "52 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "52 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }

            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }

            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }

            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }

            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "79 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }

            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "79 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "82 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "82 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "84 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "30 DURAK";
            }

            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "84 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "30 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "86 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "31 DURAK";
            }

            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "GÜZELYALI")

            {
                label5.Text = "86 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "31 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "87 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "32 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "87 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "32 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "89 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "33 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "89 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "33 DURAK";
            }
            if (comboBox1.Text == "GÜZELYALI" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "90 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "32 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "GÜZELYALI")
            {
                label5.Text = "90 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "32 DURAK";
            }

            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "KAYNARCA")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "7 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "7 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }

            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "49 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "49 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }

            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }

            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }

            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }

            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "77 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "77 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "79 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "79 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "82 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "82 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "83 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "30 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "83 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "30 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "85 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "31 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "85 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "31 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "86 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "32 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "86 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "32 DURAK";
            }
            if (comboBox1.Text == "TERSANE" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "87 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "33 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "TERSANE")
            {
                label5.Text = "87 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "33 DURAK";
            }

            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "4 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "KAYNARCA")
            {
                label5.Text = "4 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "KAYNARCA")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "KAYNARCA")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "BAŞAK")

            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "ATALAR")

            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "CEVİZLİ")

            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "CEVİZLİ")

            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "MALTEPE")

            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "SÜREYYAPLAJI")

            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "İDEALTEPE")

            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "KÜÇÜKYALI")

            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "BOSTANCI")

            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "SUADİYE")

            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "ERENKÖY")

            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "GÖZTEPE")

            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "FENERYOLU")

            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")

            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "AYRILIK ÇEŞMESİ")

            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "ÜSKÜDAR")

            {
                label5.Text = "46 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "46 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "SİRKECİ")

            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "YENİKAPI")

            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "KAZLIÇEŞME")

            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "ZEYTİNBURNU")

            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "YENİMAHALLE")

            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "BAKIRKÖY")

            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "ATAKÖY")

            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "YEŞİLYURT")

            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "YEŞİLKÖY")

            {
                label5.Text = "77 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "77 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "AKVARYUM")

            {
                label5.Text = "79 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "79 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "FLORYA")

            {
                label5.Text = "80 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "80 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "KÜÇÜKÇEKMECE")

            {
                label5.Text = "82 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "30 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "82 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "30 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "MUSTAFA KEMAL")

            {
                label5.Text = "84 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "31 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "84 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "31 DURAK";
            }
            if (comboBox1.Text == "KAYNARCA" && comboBox2.Text == "HALKALI")

            {
                label5.Text = "85 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "32 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "KAYNARCA")

            {
                label5.Text = "85 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "32 DURAK";
            }

            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "YUNUS")

            {
                label5.Text = "1 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }

            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "PENDİK")

            {
                label5.Text = "1 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "KARTAL")

            {
                label5.Text = "4 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "PENDİK")

            {
                label5.Text = "4 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "6 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "6 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "9 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "9 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "12 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "12 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "14 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "14 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }

            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "17 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "17 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "20 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "20 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }

            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "22 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "22 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }

            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "25 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }

            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "25 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "27 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "27 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }

            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "30 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "30 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "33 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "33 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }

            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "35 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "35 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "38 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }

            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "38 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }

            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "41 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "41 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }

            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "46 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "46 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "49 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "49 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "51 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "51 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "54 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "54 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "57 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "57 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "59 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "59 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "62 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "62 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "70 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "70 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "72 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "72 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "75 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "75 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "76 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "76 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "78 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "78 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "79 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "30 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "79 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "30 DURAK";
            }
            if (comboBox1.Text == "PENDİK" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "80 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "31 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "PENDİK")
            {
                label5.Text = "80 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "31 DURAK";
            }


            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "41 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "41 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "75 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "75 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "77 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "77 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "78 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "78 DAKİKA";
                label6.Text = "29.99 TL";
                label8.Text = "29 DURAK";
            }
            if (comboBox1.Text == "YUNUS" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "77 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "YUNUS")
            {
                label5.Text = "77 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }


            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "39 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "39 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "72 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "72 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "76 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "76 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }
            if (comboBox1.Text == "KARTAL" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "77 DAKİKA";
                label6.Text = "29.99TL";
                label8.Text = "29 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "KARTAL")
            {
                label5.Text = "77 DAKİKA";
                label6.Text = "29.99TL";
                label8.Text = "29 DURAK";
            }

            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }

            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "36 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "36 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "70DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "70DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "73 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "73 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }
            if (comboBox1.Text == "BAŞAK" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "BAŞAK")
            {
                label5.Text = "74 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "28 DURAK";
            }


            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "33 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "33 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }

            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "67 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "67 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "70 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "70 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "26 DURAK";
            }
            if (comboBox1.Text == "ATALAR" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "ATALAR")
            {
                label5.Text = "71 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "27 DURAK";
            }

            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "31 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "31 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "65 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "65 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "68 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "68 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "CEVİZLİ" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "CEVİZLİ")
            {
                label5.Text = "69 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }

            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "MALTEPE")

            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "62 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "62 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "65 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "65 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "MALTEPE" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "66 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "25 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "MALTEPE")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }


            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "25 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "25 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "59 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "59 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "62 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "62 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";
            }
            if (comboBox1.Text == "SÜREYYAPLAJI" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "SÜREYYAPLAJI")
            {
                label5.Text = "63 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "24 DURAK";
            }

            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";

            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";

            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "23 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "23 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "57 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "57 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "60 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "60 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";

            }
            if (comboBox1.Text == "İDEALTEPE" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";

            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "İDEALTEPE")
            {
                label5.Text = "61 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "23 DURAK";

            }


            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "20 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "20 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "54 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "54 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "55 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "57 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "57 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKYALI" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "KÜÇÜKYALI")
            {
                label5.Text = "58 DAKİKA";
                label6.Text = "25.68 TL";
                label8.Text = "22 DURAK";
            }



            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "17 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "17 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "51 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "51 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "54 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "54 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "BOSTANCI" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "56 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "BOSTANCI")
            {
                label5.Text = "56 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "21 DURAK";
            }


            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "15 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "15 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }

            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }

            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "49 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "49 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "52 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "52 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "SUADİYE" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "SUADİYE")
            {
                label5.Text = "53 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "20 DURAK";
            }


            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "12 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "12 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "46 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "46 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "49 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "49 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "ERENKÖY" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "ERENKÖY")
            {
                label5.Text = "50 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "19 DURAK";
            }


            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "9 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "9 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }

            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "42 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "43 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "43 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "47 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "47 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "GÖZTEPE" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "GÖZTEPE")
            {
                label5.Text = "48 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "18 DURAK";
            }



            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }

            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "ÜSKÜDAR")
            {
                label5.Text = "7 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "7 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }

            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "AKVARYUM")
            {

                label5.Text = "40 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "FENERYOLU")
            {
                label5.Text = "40 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "FLORYA")
            {

                label5.Text = "41 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "FENERYOLU")
            {

                label5.Text = "41 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {

                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "FENERYOLU")
            {

                label5.Text = "42 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "MUSTAFA KEMAL")
            {

                label5.Text = "44 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "FENERYOLU")
            {

                label5.Text = "44 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "FENERYOLU" && comboBox2.Text == "HALKALI")
            {

                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "FENERYOLU")
            {

                label5.Text = "45 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "17 DURAK";
            }

            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {

                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {

                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "ÜSKÜDAR")
            {

                label5.Text = "4 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }

            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {

                label5.Text = "4 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "SİRKECİ")
            {

                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {

                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "YENİKAPI")
            {

                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {

                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "KAZLIÇEŞME")
            {

                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {

                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "ZEYTİNBURNU")
            {

                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {

                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "YENİMAHALLE")
            {

                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {

                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "BAKIRKÖY")
            {

                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {

                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }

            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "ATAKÖY")
            {

                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "YEŞİLYURT")
            {

                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {

                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "YEŞİLKÖY")
            {

                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {

                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "AKVARYUM")
            {

                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {

                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "FLORYA")
            {

                label5.Text = "38 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {

                label5.Text = "38 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {

                label5.Text = "40 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {

                label5.Text = "40 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "MUSTAFA KEMAL")
            {

                label5.Text = "41 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {

                label5.Text = "41 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "SÖĞÜTLÜÇEŞME" && comboBox2.Text == "HALKALI")
            {

                label5.Text = "42 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "16 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "SÖĞÜTLÜÇEŞME")
            {

                label5.Text = "42 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "16 DURAK";
            }

            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "ÜSKÜDAR")
            {

                label5.Text = "2 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {

                label5.Text = "2 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "SİRKECİ")
            {

                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {

                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "YENİKAPI")
            {

                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {

                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "KAZLIÇEŞME")
            {

                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {

                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "ZEYTİNBURNU")
            {

                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {

                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "YENİMAHALLE")
            {

                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {

                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "BAKIRKÖY")
            {

                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {

                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "ATAKÖY")
            {

                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {

                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "YEŞİLYURT")
            {

                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {

                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "YEŞİLKÖY")
            {

                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {

                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "AKVARYUM")
            {

                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {

                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "FLORYA")
            {

                label5.Text = "35 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {

                label5.Text = "35 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {

                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {

                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "MUSTAFA KEMAL")
            {

                label5.Text = "39 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {

                label5.Text = "39 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "AYRILIK ÇEŞMESİ" && comboBox2.Text == "HALKALI")
            {

                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "AYRILIK ÇEŞMESİ")
            {

                label5.Text = "40 DAKİKA";
                label6.Text = "22.26 TL";
                label8.Text = "15 DURAK";
            }

            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "SİRKECİ")
            {

                label5.Text = "4 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "ÜSKÜDAR")
            {

                label5.Text = "4 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "YENİKAPI")
            {

                label5.Text = "6 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "ÜSKÜDAR")
            {

                label5.Text = "6 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "KAZLIÇEŞME")
            {

                label5.Text = "9 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "ÜSKÜDAR")
            {

                label5.Text = "9 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }

            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "ZEYTİNBURNU")
            {

                label5.Text = "12 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "ÜSKÜDAR")
            {

                label5.Text = "12 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "YENİMAHALLE")
            {

                label5.Text = "14 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "ÜSKÜDAR")
            {

                label5.Text = "14 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "BAKIRKÖY")
            {

                label5.Text = "17 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "ÜSKÜDAR")
            {

                label5.Text = "17 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "ATAKÖY")
            {

                label5.Text = "20 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "ÜSKÜDAR")
            {

                label5.Text = "20 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "YEŞİLYURT")
            {

                label5.Text = "27 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "ÜSKÜDAR")
            {

                label5.Text = "27 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "YEŞİLKÖY")
            {

                label5.Text = "30 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "ÜSKÜDAR")
            {

                label5.Text = "30 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "AKVARYUM")
            {

                label5.Text = "33 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "ÜSKÜDAR")
            {

                label5.Text = "33 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "FLORYA")
            {

                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {

                label5.Text = "35 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "ÜSKÜDAR")
            {

                label5.Text = "35 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "MUSTAFA KEMAL")
            {

                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "ÜSKÜDAR")
            {

                label5.Text = "37 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "ÜSKÜDAR" && comboBox2.Text == "HALKALI")
            {

                label5.Text = "38 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "ÜSKÜDAR")
            {

                label5.Text = "38 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "14 DURAK";
            }


            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "YENİKAPI")
            {

                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "SİRKECİ")
            {

                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "KAZLIÇEŞME")
            {

                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "SİRKECİ")
            {

                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "ZEYTİNBURNU")
            {

                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "SİRKECİ")
            {

                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "YENİMAHALLE")
            {

                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "SİRKECİ")
            {

                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "BAKIRKÖY")
            {

                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "SİRKECİ")
            {

                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "ATAKÖY")
            {

                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "SİRKECİ")
            {

                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "30 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "30 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "33 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "33 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "SİRKECİ" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "SİRKECİ")
            {
                label5.Text = "34 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "13 DURAK";
            }

            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "28 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "28 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "31 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "31 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "YENİKAPI" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "YENİKAPI")
            {
                label5.Text = "32 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "12 DURAK";
            }


            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "25 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "25 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "28 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "28 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "KAZLIÇEŞME" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "KAZLIÇEŞME")
            {
                label5.Text = "29 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "11 DURAK";
            }

            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "22 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "22 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "25 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "25 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "ZEYTİNBURNU" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "ZEYTİNBURNU")
            {
                label5.Text = "26 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "10 DURAK";
            }


            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "20 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "20 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "23 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "23 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "YENİMAHALLE" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "YENİMAHALLE")
            {
                label5.Text = "24 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "9 DURAK";
            }

            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "17 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "17 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "19 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "19 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "20 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "20 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "BAKIRKÖY" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "BAKIRKÖY")
            {
                label5.Text = "21 DAKİKA";
                label6.Text = "19.29 TL";
                label8.Text = "8 DURAK";
            }

            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "13 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "14 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "14 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "16 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "18 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "ATAKÖY" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "19 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "ATAKÖY")
            {
                label5.Text = "19 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "7 DURAK";
            }

            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "6 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "6 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "10 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "10 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "YEŞİLYURT" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "YEŞİLYURT")
            {
                label5.Text = "11 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "6 DURAK";
            }

            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "4 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "4 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "7 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "7 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "YEŞİLKÖY" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "YEŞİLKÖY")
            {
                label5.Text = "8 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "5 DURAK";
            }

            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "1 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "1 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "4 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "4 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "AKVARYUM" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "AKVARYUM")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }


            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "5 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "4 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "2 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "FLORYA" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "4 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "FLORYA")
            {
                label5.Text = "4 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "3 DURAK";
            }

            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "2 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "2 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "KÜÇÜKÇEKMECE" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "KÜÇÜKÇEKMECE")
            {
                label5.Text = "3 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "2 DURAK";
            }


            if (comboBox1.Text == "MUSTAFA KEMAL" && comboBox2.Text == "HALKALI")
            {
                label5.Text = "1 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
            if (comboBox1.Text == "HALKALI" && comboBox2.Text == "MUSTAFA KEMAL")
            {
                label5.Text = "1 DAKİKA";
                label6.Text = "15 TL";
                label8.Text = "1 DURAK";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void zaman()
        {
            label9.Text = DateTime.Now.ToLongTimeString();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            button2.Visible = false;
            button1.Visible = true;
            button1.Enabled = true;
            timer1.Enabled = true;

            if (count % 2 == 0)
            {
                axWindowsMediaPlayer3.URL = "C:\\Users\\PC\\Downloads\\istanbulkart2.mpeg";
            }
            else
            {
                axWindowsMediaPlayer3.URL = "C:\\Users\\PC\\Downloads\\istanbulkart1.mpeg";
            }
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            pictureBox2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToLongTimeString();
            label7.Text = label7.Text.Substring(1) + label7.Text.Substring(0, 1);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int sayac = 0;

        private void timer3_Tick(object sender, EventArgs e)
        {
      
                sayac++;
                if (sayac < 10 && sayac > 0)
                {
                pictureBox3.Visible = true;
                pictureBox3.Enabled = true;
                pictureBox4.Visible = false;
                pictureBox4.Enabled = false;
                pictureBox5.Visible = false;
                pictureBox5.Enabled = false;
                pictureBox6.Visible = false;
                pictureBox6.Enabled = false;
                pictureBox7.Visible = true;
                pictureBox7.Enabled = true;
                timer3.Stop();

            }
            if (sayac <= 20)
                {
                pictureBox3.Visible = false;
                pictureBox3.Enabled = false;
                pictureBox4.Visible = true;
                pictureBox4.Enabled = true;
                pictureBox5.Visible = false;
                pictureBox5.Enabled = false;
                pictureBox6.Visible = false;
                pictureBox6.Enabled = false;
                pictureBox7.Visible = true;
                pictureBox7.Enabled = true;
                timer3.Stop();


            }
            if (sayac <= 30)
                {
                pictureBox3.Visible = false;
                pictureBox3.Enabled = false;
                pictureBox4.Visible = false;
                pictureBox4.Enabled = false;
                pictureBox5.Visible = true;
                pictureBox5.Enabled = true;
                pictureBox6.Visible = false;
                pictureBox6.Enabled = false;
                pictureBox7.Visible = true;
                pictureBox7.Enabled = true;
                timer3.Stop();

            }
            if (sayac <= 40)
                {
                pictureBox3.Visible = false;
                pictureBox3.Enabled = false;
                pictureBox4.Visible = false;
                pictureBox4.Enabled = false;
                pictureBox5.Visible = false;
                pictureBox5.Enabled = false;
                pictureBox6.Visible = true;
                pictureBox6.Enabled = true;
                pictureBox7.Visible = true;
                pictureBox7.Enabled = true;
                timer3.Stop();


            }
            if (sayac <= 50)
                {
                    pictureBox3.Visible = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Visible = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Visible = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Visible = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Visible = true;
                    pictureBox7.Enabled = true;
                timer3.Stop();
            }
            
            }
        }
    }

