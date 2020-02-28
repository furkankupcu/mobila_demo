using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobilya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz Alınmıştır" );
                
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                //Kredi kartı

            }
            else if (radioButton5.Checked == true)
            {
                //havale
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MobilyaFabrika m1 = new KocaeliFabrika();
                m1.Mobilyasipariş("kestane");

            }
            else if (radioButton2.Checked == true)
            {
                MobilyaFabrika m1 = new KayseriFabrika();
                m1.Mobilyasipariş("çam");

            }
            else if (radioButton3.Checked == true)
            {
                MobilyaFabrika m1 = new İnegölFabrika();
                m1.Mobilyasipariş("meşe");

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (mobilyaComboBox.SelectedIndex == 0)
            {
                Mobilya mobilya = new Dolap();
               

                if (checkBox1.Checked == true)
                {
                    mobilya = new MDF(mobilya);
                    
                }
                if(checkBox2.Checked==true)
                {
                    mobilya = new Teslimat(mobilya);  
                }
                if (checkBox3.Checked == true)
                {
                    mobilya = new Garanti(mobilya);
                }

                seçim.Text = mobilya.getİsim(); ;
                fiyat.Text = mobilya.getFİyat().ToString(); ;

            }


            else if(mobilyaComboBox.SelectedIndex==1)
            {
                Mobilya mobilya = new Masa();
                

                if (checkBox1.Checked == true)
                {
                    mobilya = new MDF(mobilya);

                }
                if (checkBox2.Checked == true)
                {
                    mobilya = new Teslimat(mobilya);
                }
                if (checkBox3.Checked == true)
                {
                    mobilya = new Garanti(mobilya);
                }

                seçim.Text = mobilya.getİsim(); ;
                fiyat.Text = mobilya.getFİyat().ToString(); ;
            }
             
            else if(mobilyaComboBox.SelectedIndex==2)
            {
                Mobilya mobilya = new Dolap();

                if (checkBox1.Checked == true)
                {
                    mobilya = new MDF(mobilya);

                }
                if (checkBox2.Checked == true)
                {
                    mobilya = new Teslimat(mobilya);
                }
                if (checkBox3.Checked == true)
                {
                    mobilya = new Garanti(mobilya);
                }

                seçim.Text = mobilya.getİsim(); ;
                fiyat.Text = mobilya.getFİyat().ToString(); ;

            }
        }
    
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (mobilyaComboBox.SelectedIndex == 0)
            {
                Mobilya mobilya = new Dolap();

                if (checkBox1.Checked == true)
                {
                    mobilya = new MDF(mobilya);

                }
                if (checkBox2.Checked == true)
                {
                    mobilya = new Teslimat(mobilya);
                }
                if (checkBox3.Checked == true)
                {
                    mobilya = new Garanti(mobilya);
                }

                seçim.Text = mobilya.getİsim(); ;
                fiyat.Text = mobilya.getFİyat().ToString(); ;

            }


            else if (mobilyaComboBox.SelectedIndex == 1)
            {
                Mobilya mobilya = new Masa();

                if (checkBox1.Checked == true)
                {
                    mobilya = new MDF(mobilya);

                }
                if (checkBox2.Checked == true)
                {
                    mobilya = new Teslimat(mobilya);
                }
                if (checkBox3.Checked == true)
                {
                    mobilya = new Garanti(mobilya);
                }

                seçim.Text = mobilya.getİsim(); ;
                fiyat.Text = mobilya.getFİyat().ToString(); ;
            }

            else if (mobilyaComboBox.SelectedIndex == 2)
            {
                Mobilya mobilya = new Dolap();

                if (checkBox1.Checked == true)
                {
                    mobilya = new MDF(mobilya);

                }
                if (checkBox2.Checked == true)
                {
                    mobilya = new Teslimat(mobilya);
                }
                if (checkBox3.Checked == true)
                {
                    mobilya = new Garanti(mobilya);
                }

                seçim.Text = mobilya.getİsim(); ;
                fiyat.Text = mobilya.getFİyat().ToString(); ;

            }
        }
    
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (mobilyaComboBox.SelectedIndex == 0)
            {
                Mobilya mobilya = new Dolap();

                if (checkBox1.Checked == true)
                {
                    mobilya = new MDF(mobilya);

                }
                if (checkBox2.Checked == true)
                {
                    mobilya = new Teslimat(mobilya);
                }
                if (checkBox3.Checked == true)
                {
                    mobilya = new Garanti(mobilya);
                }

                seçim.Text = mobilya.getİsim(); ;
                fiyat.Text = mobilya.getFİyat().ToString(); ;

            }


            else if (mobilyaComboBox.SelectedIndex == 1)
            {
                Mobilya mobilya = new Masa();

                if (checkBox1.Checked == true)
                {
                    mobilya = new MDF(mobilya);

                }
                if (checkBox2.Checked == true)
                {
                    mobilya = new Teslimat(mobilya);
                }
                if (checkBox3.Checked == true)
                {
                    mobilya = new Garanti(mobilya);
                }

                seçim.Text = mobilya.getİsim(); ;
                fiyat.Text = mobilya.getFİyat().ToString(); ;
            }

            else if (mobilyaComboBox.SelectedIndex == 2)
            {
                Mobilya mobilya = new Dolap();
               

                if (checkBox1.Checked == true)
                {
                    mobilya = new MDF(mobilya);

                }
                if (checkBox2.Checked == true)
                {
                    mobilya = new Teslimat(mobilya);
                }
                if (checkBox3.Checked == true)
                {
                    mobilya = new Garanti(mobilya);
                }

                seçim.Text = mobilya.getİsim(); ;
                fiyat.Text = mobilya.getFİyat().ToString(); ;

            }
        }
    }
}
