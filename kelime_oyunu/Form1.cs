using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kelime_oyunu
{
    public partial class Form1 : Form
    {
        int sansayac,daksayac,sorusayac,sorusaysayac,rsayi1,k,rsayi2,harfsayac,rsayac,arapuan,tpuan,ysayac,sorusayacdis;
        int [] rsayidizi = new int[15];
        string kelime;
        bool durum;
        string[] sorular =new string[14];
        string[] cevaplar =new string[14] ;
        Random r = new Random();
        Label l = new Label();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false; label2.Visible = false; label3.Visible = false; label4.Visible = false;
            label5.Visible = false; label6.Visible = false; label7.Visible = false; label8.Visible = false;
            label9.Visible = false; label10.Visible = false;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer1.Interval = 1000;
            timer2.Interval = 20;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            label18.Text = "04:00";
            durum = true;
            sorusayac = 0; sorusaysayac = 1; harfsayac = 0; sorusayacdis = 0;
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (durum == true)
                {
                    timer1.Enabled = true;
                }
                label11.Text = sorular[sorusayac];
                sorusayac++;
                durum = false;
                if (sorusaysayac == 1)
                {
                    kelime = cevaplar[0];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = false; label6.Visible = false; label7.Visible = false; label8.Visible = false;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 400;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 2)
                {
                    kelime = cevaplar[1];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = false; label6.Visible = false; label7.Visible = false; label8.Visible = false;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 400;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 3)
                {
                    kelime = cevaplar[2];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = false; label7.Visible = false; label8.Visible = false;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 500;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 4)
                {
                    kelime = cevaplar[3];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = false; label7.Visible = false; label8.Visible = false;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 500;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 5)
                {
                    kelime = cevaplar[4];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = false; label8.Visible = false;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 600;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 6)
                {
                    kelime = cevaplar[5];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = false; label8.Visible = false;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 600;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 7)
                {
                    kelime = cevaplar[6];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = false;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 700;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 8)
                {
                    kelime = cevaplar[7];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = false;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 700;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 9)
                {
                    kelime = cevaplar[8];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = true;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 800;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 10)
                {
                    kelime = cevaplar[9];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = true;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 800;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 11)
                {
                    kelime = cevaplar[10];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = true;
                    label9.Visible = true; label10.Visible = false;
                    arapuan = 900;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 12)
                {
                    kelime = cevaplar[11];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = true;
                    label9.Visible = true; label10.Visible = false;
                    arapuan = 900;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 13)
                {
                    kelime = cevaplar[12];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = true;
                    label9.Visible = true; label10.Visible = true;
                    arapuan = 1000;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();

                }
                if (sorusaysayac == 14)
                {
                    kelime = cevaplar[13];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = true;
                    label9.Visible = true; label10.Visible = true;
                    arapuan = 1000;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();


                }
                sorusaysayac++;
                if (sorusaysayac < 15)
                {

                    button3.Text = "Soru " + sorusaysayac;
                }
                else
                {
                    button3.Text = "Başla";

                    button3.Enabled = true;

                }
                harfsayac = 0;
                label1.Text = "___";
                label2.Text = "___";
                label3.Text = "___";
                label4.Text = "___";
                label5.Text = "___";
                label6.Text = "___";
                label7.Text = "___";
                label8.Text = "___";
                label9.Text = "___";
                label10.Text = "___";
                button1.Enabled = true;
                button2.Enabled = true;

                Array.Clear(rsayidizi, 0, (rsayidizi.Length));              


            }
            catch
            {
                ;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
            sansayac++;
            if (sansayac > 50)
            {
                label18.Text ="0"+ (3 - daksayac).ToString() + " : 0" + (60 - sansayac).ToString();
            }
            else
            {
                label18.Text = "0" + (3 - daksayac).ToString() + " : " + (60 - sansayac).ToString();//Daha fazla bilgi için : www.gorselprogramlama.com
            }
           
           
            if (sansayac ==60)
            {
                daksayac++;
                sansayac = 0;
            }
            if (daksayac == 4)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
                timer1.Enabled = false;                
            }        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
                rsayac = 0;
                harfsayac++;
                switch (sorusayac)
                {
                    case 1:
                        {
                            arapuan -= 100;
                            label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                            kelime = cevaplar[0];
                            while (rsayac == 0)
                            {
                                rsayi1 = r.Next(5);
                                if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                                {
                                    rsayidizi[harfsayac] = rsayi1;
                                    rsayac++;
                                    ysayac++;
                                 }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 4)
                            {
                                ysayac = 0;
                                button1.Enabled = false;
                            }
                            
                            break;

                        }
                    case 2:
                        {
                            arapuan -= 100;
                            label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                            kelime = cevaplar[1];
                            while (rsayac == 0)
                            {
                                rsayi1 = r.Next(5);
                                if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                                {
                                    rsayidizi[harfsayac] = rsayi1;
                                    rsayac++;
                                    ysayac++;                                   
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 4)
                            {
                                ysayac = 0;
                                button1.Enabled = false;
                            }
                           
                            break;

                        }
                    case 3:
                        {
                            arapuan -= 100;
                            label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                            kelime = cevaplar[2];
                            while (rsayac == 0)
                            {
                                rsayi1 = r.Next(6);
                                if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                                {
                                    rsayidizi[harfsayac] = rsayi1;
                                    rsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 5)
                            {
                                ysayac = 0;
                                button1.Enabled = false;
                            }
                            break;

                        }
                    case 4:
                        {
                            arapuan -= 100;
                            label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                            kelime = cevaplar[3];
                            while (rsayac == 0)
                            {
                                rsayi1 = r.Next(6);
                                if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                                {
                                    rsayidizi[harfsayac] = rsayi1;
                                    rsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 5)
                            {
                                ysayac = 0;
                                button1.Enabled = false;
                            }
                            break;

                        }
                    case 5:
                        {
                            arapuan -= 100;
                            label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                            kelime = cevaplar[4];
                            while (rsayac == 0)
                            {
                                rsayi1 = r.Next(7);
                                if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                                {
                                    rsayidizi[harfsayac] = rsayi1;
                                    rsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 6)
                            {
                                ysayac = 0;
                                button1.Enabled = false;
                            }
                            break;

                        }
                    case 6:
                        {
                            arapuan -= 100;
                            label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                            kelime = cevaplar[5];
                            while (rsayac == 0)
                            {
                                rsayi1 = r.Next(7);
                                if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                                {
                                    rsayidizi[harfsayac] = rsayi1;
                                    rsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 6)
                            {
                                ysayac = 0;
                                button1.Enabled = false;
                            }
                            break;

                        }
                    case 7:
                        {
                            arapuan -= 100;
                            label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                            kelime = cevaplar[6];
                            while (rsayac == 0)
                            {
                                rsayi1 = r.Next(8);
                                if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                                {
                                    rsayidizi[harfsayac] = rsayi1;
                                    rsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 7)
                            {
                                ysayac = 0;
                                button1.Enabled = false;
                            }
                            break;

                        }
                    case 8:
                        {
                            arapuan -= 100;
                            label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                            kelime = cevaplar[7];
                            while (rsayac == 0)
                            {
                                rsayi1 = r.Next(8);
                                if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                                {
                                    rsayidizi[harfsayac] = rsayi1;
                                    rsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 7)
                            {
                                ysayac = 0;
                                button1.Enabled = false;
                            }
                            break;

                        }
                    case 9:
                        {
                            arapuan -= 100;
                            label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                            kelime = cevaplar[8];
                            while (rsayac == 0)
                            {
                                rsayi1 = r.Next(9);
                                if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                                {
                                    rsayidizi[harfsayac] = rsayi1;
                                    rsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 8)
                            {
                                ysayac = 0;
                                button1.Enabled = false;
                            }
                            break;

                        }
                    case 10:
                        {
                            arapuan -= 100;
                            label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                            kelime = cevaplar[9];
                            while (rsayac == 0)
                            {
                                rsayi1 = r.Next(9);
                                if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                                {
                                    rsayidizi[harfsayac] = rsayi1;
                                    rsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 8)
                            {
                                ysayac = 0;
                                button1.Enabled = false;
                            }
                            break;

                        }
                    case 11:
                        {
                            arapuan -= 100;
                            label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                            kelime = cevaplar[10];
                            while (rsayac == 0)
                            {
                                rsayi1 = r.Next(10);
                                if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                                {
                                    rsayidizi[harfsayac] = rsayi1;
                                    rsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 9)
                            {
                                ysayac = 0;
                                button1.Enabled = false;
                            }
                            break;

                        }
                    case 12:
                        {
                            arapuan -= 100;
                            label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                            kelime = cevaplar[11];
                            while (rsayac == 0)
                            {
                                rsayi1 = r.Next(10);
                                if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                                {
                                    rsayidizi[harfsayac] = rsayi1;
                                    rsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 9)
                            {
                                ysayac = 0;
                                button1.Enabled = false;
                            }
                            break;

                        }
                    case 13:
                        {
                            arapuan -= 100;
                            label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                            kelime = cevaplar[12];
                            while (rsayac == 0)
                            {
                                rsayi1 = r.Next(11);
                                if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                                {
                                    rsayidizi[harfsayac] = rsayi1;
                                    rsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 10)
                            {
                                ysayac = 0;
                                button1.Enabled = true;
                            }
                            break;

                        }
                    case 14:
                        {
                            arapuan -= 100;
                            label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                            kelime = cevaplar[13];
                            while (rsayac == 0)
                            {
                                rsayi1 = r.Next(11);
                                if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                                {
                                    rsayidizi[harfsayac] = rsayi1;
                                    rsayac++;
                                    ysayac++;
                                }
                            }
                            timer2.Enabled = true;
                            if (ysayac == 10)
                            {
                                ysayac = 0;
                                button1.Enabled = false;
                                timer1.Enabled = false;
                            }
                            
                            break;

                        }


                }
            
           
           
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                switch (rsayi1)
                {
                    case 1:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label1.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label1.Text = kelime[0].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }

                        break;
                    case 2:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label2.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label2.Text = kelime[1].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }
                        break;
                    case 3:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label3.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label3.Text = kelime[2].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }
                        break;
                    case 4:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label4.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label4.Text = kelime[3].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }
                        break;
                    case 5:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label5.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label5.Text = kelime[4].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }
                        break;
                    case 6:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label6.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label6.Text = kelime[5].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }
                        break;
                    case 7:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label7.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label7.Text = kelime[6].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }
                        break;
                    case 8:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label8.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label8.Text = kelime[7].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }
                        break;
                    case 9:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label9.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label9.Text = kelime[8].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }
                        break;
                    case 10:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label10.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label10.Text = kelime[9].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }
                        break;
                    default:
                        MessageBox.Show("Hata");
                        break;
                }
            }
            catch
            { ;
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            switch (sorusayac)
            {
                case 1:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[0])                        
                            tpuan += arapuan;                        
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString(); 
                        label3.Text= kelime[2].ToString(); label4.Text = kelime[3].ToString(); 
                        break;
                    }
                case 2:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[1])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        break;
                    }
                case 3:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[2])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString();
                        break;
                    }
                case 4:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[3])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString();
                        break;
                    }
                case 5:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[4])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        break;
                    }
                case 6:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[5])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        break;
                    }
                case 7:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[6])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        label7.Text = kelime[6].ToString();
                        break;
                    }
                case 8:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[7])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        label7.Text = kelime[6].ToString();
                        break;
                    }
                case 9:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[8])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        label7.Text = kelime[6].ToString(); label8.Text = kelime[7].ToString();
                        break;
                    }
                case 10:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[9])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        label7.Text = kelime[6].ToString(); label8.Text = kelime[7].ToString();
                        break;
                    }
                case 11:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[10])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        label7.Text = kelime[6].ToString(); label8.Text = kelime[7].ToString();
                        label9.Text = kelime[8].ToString();
                        break;
                    }
                case 12:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[11])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        label7.Text = kelime[6].ToString(); label8.Text = kelime[7].ToString();
                        label9.Text = kelime[8].ToString();
                        break;
                    }
                case 13:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[12])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        label7.Text = kelime[6].ToString(); label8.Text = kelime[7].ToString();
                        label9.Text = kelime[8].ToString(); label10.Text = kelime[9].ToString();
                        break;
                    }
                case 14:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[13])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        label7.Text = kelime[6].ToString(); label8.Text = kelime[7].ToString();
                        label9.Text = kelime[8].ToString(); label10.Text = kelime[9].ToString();
                        timer1.Enabled = false;
                        break;
                    }


            }
        }

       private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            durum = true;
        }

      

       private void button6_Click(object sender, EventArgs e)
       {

            sansayac = 0; daksayac = 0; tpuan = 0; arapuan = 0;
            timer1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Text = "Başla";
            durum = true;
            sorusayac = 0; sorusaysayac = 1; harfsayac = 0; sorusayacdis = 0;
            button3.Enabled = true;

            sorular[0] = "1- Akla ve gerçeğe aykırı";
            cevaplar[0] = "ABES";
            sorular[1] = "2- İnekte 4tane Kadında 2 tane";
            cevaplar[1] = "AYAK";
            sorular[2] = "3-Kişiye özel Çevre, yöre, etraf";
            cevaplar[2] = "MUHİT";
            sorular[3] = "4-Kişinin düşmanı ";
            cevaplar[3] = "HISIM";
            sorular[4] = "5- Sporda veya oyunda yenilmiş olanın aynı rakiple oynadığı ikinci oyun";
            cevaplar[4] = "RÖVANŞ";
            sorular[5] = "6- Zeytingillerden, yaprakları karşılıklı bir ağaççık ";
            cevaplar[5] = "LEYLAK";
            sorular[6] = "7- Çaresiz bir biçimde, çıkar yolu olmaksızın";
            cevaplar[6] = "UMARSIZ";
            sorular[7] = "8- Yemek yeme gereksinimi duymak";
            cevaplar[7] = "ACIKMAK";
            sorular[8] = "9- Bir yerde çalışan kimselere genellikle kazançtan dağıtılan  para";
            cevaplar[8] = "İKRAMİYE";
            sorular[9] = "10- Aralarındaki düşünce veya çıkar ayrılığını, karşılıklı ödünlerle kaldırarak uyuşmak";
            cevaplar[9] = "UZLAŞMAK";
            sorular[10] = "11- İyi arkadaşlık eden, saygılı, görgülü, kibar erkek";
            cevaplar[10] = "CENTİLMEN";
            sorular[11] = "12- Giysi ve mal değeri bilmeyen, derbeder, serseri, avare (kimse)";
            cevaplar[11] = "ÇULTUTMAZ";
            sorular[12] = "13- Bir durumu, bir haberi sözle veya yazıyla halka bildirmek.";
            cevaplar[12] = "ANONSETMEK";
            sorular[13] = "14-Karın doyurmak, beslenmek";
            cevaplar[13] = "YİYİPİÇMEK";
       }

    }    
}
