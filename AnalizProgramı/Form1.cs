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
            
            bool sonuc=true;

            if (e.KeyChar == (char)Keys.Enter)
            {
                for (int i = 0; i < 7; i++)
                {
                    list[i].Visible = false;
                    list[i].Text = string.Empty;
                }

               sonuc = int.TryParse(rtxtSlot.Text,out slotSayi);

                if (!sonuc)
                {
                    MessageBox.Show("Lütfen sayı giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rtxtSlot.Clear();
                }
               else if (sonuc && slotSayi > 7 || slotSayi < 1)
                {
                    MessageBox.Show("Lütfen 1 ile 7 arasında bir sayı giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rtxtSlot.Clear();
                }
                else
                {
                    for (int i = 0; i < slotSayi; i++)
                    {
                        list[i].Visible = true;
                    }
                }

               

            }

        }

        OpenFileDialog OpenFileDialog = new OpenFileDialog();
        string dosyaYolu = string.Empty;
        private void btndosya_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog.Title = "Bir dosya seçin";
            OpenFileDialog.FileName = "Dosya Seç";
            OpenFileDialog.InitialDirectory = @"C:\Users\Mesut\Desktop";
            OpenFileDialog.Filter = "(*.txt)|*.txt";          

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                lbldosya.Text = OpenFileDialog.SafeFileName;
                dosyaYolu = OpenFileDialog.FileName;
            }

        }

        int analizSayisi = 0;
            private void rtxtAnaliz_KeyPress(object sender, KeyPressEventArgs e)
            {             
                bool sonuc = true;
               
                if (e.KeyChar == (char)Keys.Enter)
                {

                    sonuc = int.TryParse(rtxtAnaliz.Text,out analizSayisi);

                if (!sonuc)
                {
                    MessageBox.Show("Lütfen Sayı Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rtxtAnaliz.Clear();
                }
                else
                {
                    MessageBox.Show("Analiz sayısı alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
              }
          }

        private void btnArka_Click(object sender, EventArgs e)
        {

            if (dosyaYolu == string.Empty)
            {
                MessageBox.Show("Lütfen bir dosya seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {



                string deger = string.Empty;
                List<string> txtUzunluk = new List<string>();

                string[] gelen = new string[7];

                bool slotlarDurumu = true;


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

                int visibility = 0;
                for (int a=0;a<list.Count;a++)
                {
                    if (list[a].Visible == false)
                    {
                        visibility++;
                    }
                }


                if (visibility == 7)
                {
                    MessageBox.Show("Hiçbir slot açılmadı","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }


                else
                {

                

                if (slotlarDurumu)
                {



                    StreamReader read = new StreamReader(dosyaYolu, Encoding.GetEncoding("windows-1254"));

                    string metin = read.ReadLine();

                    while (metin != null)
                    {
                        txtUzunluk.Add(metin);
                        metin = read.ReadLine();
                    }

                    int sayac = 0;


                    for (int i = 0; i < txtUzunluk.Count - 6; i++)
                    {


                        for (int j = 0; j < gelen.Length; j++)
                        {
                            if (gelen[j] == txtUzunluk[j + i].ToString())
                            {
                                sayac++;

                            }

                            if (sayac == slotSayi)
                            {

                                for (int sayi = 0; sayi < analizSayisi; sayi++)
                                {
                                    deger += "," + txtUzunluk[j + i + sayi + 1];
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
                    listBox1.Items.Add(birlestir + " " + deger);

                    birlestir = string.Empty;
                    Array.Clear(gelen, 0, 6);


                }

                else
                {
                    MessageBox.Show("Slotları boş geçemezsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

               }

            }
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            if (dosyaYolu == string.Empty)
            {
                MessageBox.Show("Lütfen bir dosya seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

            

            string deger = string.Empty;
            List<string> txtUzunluk = new List<string>();

            string[] gelen = new string[7];

            bool slotlarDurumu = true;


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

                int visibility = 0;
                for (int a = 0; a < list.Count; a++)
                {
                    if (list[a].Visible == false)
                    {
                        visibility++;
                    }
                }


                if (visibility == 7)
                {
                    MessageBox.Show("Hiçbir slot açılmadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                else
                {

                

                if (slotlarDurumu)
            {



                StreamReader read = new StreamReader(dosyaYolu, Encoding.GetEncoding("windows-1254"));

                string metin = read.ReadLine();

                while (metin != null)
                {
                    txtUzunluk.Add(metin);
                    metin = read.ReadLine();
                }

                int sayac = 0;


                for (int i = 0; i < txtUzunluk.Count - 6; i++)
                {


                    for (int j = 0; j < gelen.Length; j++)
                    {
                        if (gelen[j] == txtUzunluk[j + i].ToString())
                        {
                            sayac++;

                        }

                        if (sayac == slotSayi)
                        {

                            for (int sayi = 0; sayi < analizSayisi; sayi++)
                            {
                                if((j + i - sayi - slotSayi) < 0)
                                {
                                    
                                }
                                else
                                {
                                    deger += txtUzunluk[j + i - sayi - slotSayi] + ",";
                                }
                               
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
                listBox1.Items.Add(deger  + " " + birlestir);

                birlestir = string.Empty;
                Array.Clear(gelen, 0, 6);


            }

            else
            {
                MessageBox.Show("Slotları boş geçemezsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

                }

           }
       }
    }

  }
