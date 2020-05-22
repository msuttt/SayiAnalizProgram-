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

        public void OnundekiniGetir()
        {
            
            string deger = string.Empty;
            List<string> txtUzunluk = new List<string>();

            string[] gelen = new string[7];

            // bool slotlarDurumu = true;


            for (int i = 0; i <= list.Count - 1; i++)
            {
                //if (list[i].Visible == true && list[i].Text == string.Empty)
                //{

                //    slotlarDurumu = false;
                //    break;

                //}

                // else
                // {

                //slotlarDurumu = true;

                if (list[i].Text != string.Empty)
                {
                    gelen[i] = list[i].Text;
                }
                //}

            }

            //int visibility = 0;
            //for (int a = 0; a < list.Count; a++)
            //{
            //    if (list[a].Visible == false)
            //    {
            //        visibility++;
            //    }
            //}


            //if (visibility == 7)
            //{
            //    MessageBox.Show("Hiçbir slot açılmadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}


            // else
            // {



            // if (slotlarDurumu)
            // {



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
                            if ((j + i - sayi - slotSayi) < 0)
                            {

                            }
                            else
                            {
                                deger += txtUzunluk[j + i - sayi - slotSayi] + "-";
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
            listBox1.Items.Add(deger);

            birlestir = string.Empty;
            Array.Clear(gelen, 0, 6);


            // }

            //else
            //{
            //    MessageBox.Show("Slotları boş geçemezsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}              

            //}
        }
        public void ArkasındakiniGetir()
        {
            listBox1.Items.Clear();   
                string deger = string.Empty;
                List<string> txtUzunluk = new List<string>();

                string[] gelen = new string[7];

                // bool slotlarDurumu = true;


                for (int i = 0; i <= list.Count - 1; i++)
                {
                    //if (list[i].Visible == true && list[i].Text == string.Empty)
                    //{

                    //    slotlarDurumu = false;
                    //    break;

                    //}

                    // else
                    // {

                    // slotlarDurumu = true;

                    if (list[i].Text != string.Empty)
                    {
                        gelen[i] = list[i].Text;
                    }
                    // }

                }

            //int visibility = 0;
            //for (int a=0;a<list.Count;a++)
            //{
            //    if (list[a].Visible == false)
            //    {
            //        visibility++;
            //    }
            //}


            //if (visibility == 7)
            //{
            //    MessageBox.Show("Hiçbir slot açılmadı","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //}


            // else
            // {



            // if (slotlarDurumu)
            // {


            StreamReader read=null;
            try
            {
                 read = new StreamReader(dosyaYolu, Encoding.GetEncoding("windows-1254"));


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

                                deger += txtUzunluk[j + i + sayi + 1] + "-";

                                //if (sayi == analizSayisi - 1)
                                //{
                                //    deger += "-";
                                //}

                            }

                            sayac = 0;
                        }
                    }

                    sayac = 0;

                }


                string birlestir = string.Empty;
                for (int birles = 0; birles <= gelen.Length - 1; birles++)
                {
                    if (gelen[birles] != string.Empty)
                    {
                        birlestir += gelen[birles] + ",";
                    }

                }

                listBox1.Items.Add(deger);

                birlestir = string.Empty;
                Array.Clear(gelen, 0, 6);




                //}

                //else
                //{
                //    MessageBox.Show("Slotları boş geçemezsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}

                //}
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Dosya seç");
            }
            
                


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            rdbtnArka.Checked=true;
         
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
            bool dogruMu = true;
            int outsayi = 0;
            if (e.KeyChar == (char)Keys.Enter)
            {

                dogruMu = int.TryParse(rtxtSlot.Text, out outsayi);
                if (!dogruMu)
                {

                }

                else
                {

               

                for (int i = 0; i < 7; i++)
                {
                    list[i].Visible = false;
                    list[i].Text = string.Empty;
                }

                slotSayi = Convert.ToInt32(rtxtSlot.Text);

                if(slotSayi > 7 || slotSayi < 0)
                {
                    rtxtSlot.Clear();
                }

                else
                {
                    for (int i = 0; i < slotSayi; i++)
                    {
                        list[i].Visible = true;
                    }
                }


                }//
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

            bool dogruMu = true;
            int  outsayi = 0;

            if (e.KeyChar == (char)Keys.Enter)
            {

                dogruMu = int.TryParse(rtxtSlot.Text, out outsayi);
                if (!dogruMu)
                {

                }

                else
                {
              
                analizSayisi = Convert.ToInt32(rtxtAnaliz.Text);
                  

                } //

            }


        }


        private void rtxtAnaliz_TextChanged(object sender, EventArgs e)
        {
           
        }
        
       private void rtxtAnaliz_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        int rakam =0;
        private void rtxtRakam_KeyPress(object sender, KeyPressEventArgs e)
        {
            int outsayi = 0;
            bool dogruMu = true;
            listBox1.Items.Clear();

            if (e.KeyChar == (char)Keys.Enter)
            {
                             

                dogruMu = int.TryParse(rtxtRakam.Text,out outsayi);
                if (!dogruMu)
                {

                }

                else
                {

                    rakam = Convert.ToInt32(rtxtRakam.Text);
                if (rakam > 36 || rakam<0)
                {
                    rtxtRakam.Clear();
                }

                else
                {
                    for (int i = list.Count-1; i > -1; i--)
                    {
                        if (list[i].Visible == true && list[i].Text == string.Empty)
                        {
                            list[i].Text = rakam.ToString();
                            rtxtRakam.Clear();
                            break;
                        }
                     
                    }
                   
                    int sayac = 0;
                    if (rakam.ToString() != list.First().Text)
                    {
                        for (int j = 0; j < list.Count; j++)
                        {
                            if (list[j].Visible == true && list[j].Text != string.Empty)
                            {
                                sayac++;
                            }
                        }

                        if (sayac == slotSayi && slotSayi!=1)
                        {
                            for(int z = 1; z < slotSayi; z++)
                            {
                                
                                
                               list[slotSayi - z].Text = list[slotSayi - (z +1)].Text;

                                if (z==slotSayi-1)
                                {
                                    list[0].Text = rakam.ToString();
                                }


                            }
                        

                        }

                        if (sayac == slotSayi && slotSayi == 1)
                        {
                            list[0].Text = rakam.ToString();
                        }
                    }

                    rtxtRakam.Clear();
               
                }
            }

            if (rdbtnArka.Checked)
            {
                   
               ArkasındakiniGetir();                  
               
            }
            else if (rdbtnOn.Checked)
            {
                OnundekiniGetir();
            }

             

            }//

          
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            rtxtRakam.Clear();
            rtxtSlot.Clear();
            rtxtAnaliz.Clear();
            listBox1.Items.Clear();

            for(int i = 0; i < list.Count; i++)
            {
                list[i].Clear();
                list[i].Visible = false;
            }
        }

        private void rtxtRakam_TextChanged(object sender, EventArgs e)
        {

        }

    }

  }
