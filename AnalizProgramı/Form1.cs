using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AnalizProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<RichTextBox> list = new List<RichTextBox>();


        private void Form1_Load(object sender, EventArgs e)
        {
            //for(int i = 1; i <= 7; i++)
            //{
            //    string txt = "rtxt" + i.ToString();
            //    list.Add(txt);
            //}

            list.Add(rtxt1);
            list.Add(rtxt2);
            list.Add(rtxt3);
            list.Add(rtxt4);
            list.Add(rtxt5);
            list.Add(rtxt6);
            list.Add(rtxt7);
        }

        int slotSayi = 0;
        private void rtxtSlot_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == (char)Keys.Enter)
            {
                for (int i = 0; i < 7; i++)
                {
                    list[i].Visible = false;
                    list[i].Text = string.Empty;
                }

                slotSayi = Convert.ToInt32(rtxtSlot.Text);

                for (int i = 0; i < slotSayi; i++)
                {
                    list[i].Visible = true;
                }

            }

        }


        private void btndosya_Click(object sender, EventArgs e)
        {

            string deger = string.Empty;
            List<string> txtUzunluk = new List<string>();

            string[] gelen = new string[6];

            bool slotlarDurumu=true;


            for (int i = 0; i <= list.Count - 1; i++)
            {
                if (list[i].Visible == true && list[i].Text == string.Empty)
                {
                   
                    slotlarDurumu = false;
                    break;
                    
                }

                else
                {

                    slotlarDurumu = true;
                    if (list[i].Text != string.Empty)
                    {
                        gelen[i] = list[i].Text;
                    }
                }

            }


            if (slotlarDurumu)
            {

           

            StreamReader read = new StreamReader(@"C:\Users\Mesut\Desktop\deneme.txt", Encoding.GetEncoding("windows-1254"));

            string metin = read.ReadLine();

            while (metin != null)
            {
                txtUzunluk.Add(metin);
                metin = read.ReadLine();
            }

            int sayac = 0;


            for (int i = 0; i < txtUzunluk.Count - 6; i++)
            {


                for (int j = 0; j <= gelen.Length - 1; j++)
                {
                    if (gelen[j] == txtUzunluk[j + i].ToString())
                    {
                        sayac++;

                    }

                    if (sayac == slotSayi)
                    {

                        for (int sayi = 0; sayi < analizSayisi; sayi++)
                        {
                            deger += txtUzunluk[j + i + sayi + 1] + ",";
                        }

                        sayac = 0;
                    }
                }

                sayac = 0;

            }


            string birlestir = string.Empty;
            for (int birles = 0; birles <= gelen.Length - 1; birles++)
            {
                birlestir += gelen[birles];
            }
            listBox1.Items.Add(deger + " " + birlestir);

            birlestir = string.Empty;
            Array.Clear(gelen, 0, 6);
            
            
            }

            else
            {
                 MessageBox.Show("Slotları boş geçemezsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }

            
        }

        int analizSayisi = 0;
            private void rtxtAnaliz_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {

                    analizSayisi = Convert.ToInt32(rtxtAnaliz.Text);
                }
            }


          
        }
    }
