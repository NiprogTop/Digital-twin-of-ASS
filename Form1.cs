using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Клон_АОЛ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {
            
        }
        private bool _cancel;
        private void Form1_Load(object sender, EventArgs e)
        {
            _cancel = false;                                
        }
        private void smenaChisel()
        {
            Task.Run(() =>
            {
                try
                {
                    
                    while (_cancel == true)
                    {
                        gg();
                        Thread.Sleep(5000);
                                                
                        //int s1 = rnd.Next(10, 1000);
                        //int s2 = rnd.Next(0, 100);
                        //int s3 = rnd.Next(0, 100);
                        //int s4 = rnd.Next(-100, 100);
                        //numericUpDown1.Text = Convert.ToString(s1);
                        //numericUpDown2.Text = Convert.ToString(s2);
                        //numericUpDown3.Text = Convert.ToString(rnd.Next(0, 100));
                        //numericUpDown4.Text = Convert.ToString(s4);
                        //numericUpDown_1();
                        //numericUpDown_2();
                        //numericUpDown_3();
                        //numericUpDown_4();
                        //Future_Values1();
                        //Thread.Sleep(2000);

                    }
                }

                //catch (Exception ex) { numericUpDown1.Text = Convert.ToString(404); }
                catch (Exception)
                {

                    //await Task.Run(() =>
                    //{
                    //    Random rnd = new Random();
                    //    int s1 = rnd.Next(10, 1000);
                    //    int s2 = rnd.Next(0, 100);
                    //    int s3 = rnd.Next(0, 100);
                    //    int s4 = rnd.Next(-100, 100);
                    //    gh(s1, s2, s3, s4);

                    //});
                    Invoke((MethodInvoker)delegate
                    {
                        numericUpDown1.Text = Convert.ToString(404);
                    });
                }
            });
        }
        private async void gg() {
            Random rnd = new Random();
            await Task.Run(() =>
            {
                int s1 = 1201 + rnd.Next(1, 15);
                int s2 = 27 + rnd.Next(1, 4);
                int s3 = rnd.Next(0, 100);
                int s4 = -24 + rnd.Next(1,6);
                int s5 = 755831 + rnd.Next(1, 8);
                int sб = 617673 + rnd.Next(1, 8);
                gh(s1, s2, s3, s4, s5, sб);
                    //numericUpDown1.Text = Convert.ToString(s1);
                    //numericUpDown2.Text = Convert.ToString(s2);
                    //numericUpDown3.Text = Convert.ToString(s3);
                    //numericUpDown4.Text = Convert.ToString(s4);
                    
                
            });
        }
        private async void gh(int s1, int s2, int s3, int s4, int s5,int sб)
        {
            await Task.Run(() =>
            {
                Invoke((MethodInvoker)delegate
                {
                    numericUpDown1.Text = Convert.ToString(s1);
                    numericUpDown2.Text = Convert.ToString(s2);
                    numericUpDown3.Text = "1," + Convert.ToString(s3);
                    numericUpDown4.Text = Convert.ToString(s4);
                    label25.Text = "55." + Convert.ToString(s5) + "°";
                    label26.Text = "37." + Convert.ToString(sб) + "°";
                });

            });
        }
        //private void numericUpDown_1()
        //{
        //    Random rnd = new Random();
        //    numericUpDown1.Text = Convert.ToString(rnd.Next(10, 1000));
        //}
        //private void numericUpDown_2()
        //{
        //    Random rnd = new Random();
        //    numericUpDown2.Text = Convert.ToString(rnd.Next(0, 100));
        //}
        //private void numericUpDown_3()
        //{
        //    Random rnd = new Random();
        //    numericUpDown3.Text = Convert.ToString(rnd.Next(0, 100));
        //}
        //private void numericUpDown_4()
        //{
        //    Random rnd = new Random();
        //    numericUpDown4.Text = Convert.ToString(rnd.Next(-100, 100));
        //}

        private async void button1_Click(object sender, EventArgs e)
        {
            if (label15.BackColor == Color.DarkGreen)
            {
                label15.BackColor = Color.DarkRed;
                label15.Text = "Ofline";
                _cancel = false;
            }
            else {
                label15.BackColor = Color.DarkGreen;
                label15.Text = "Online";
                _cancel = true;
                await Task.Run(() =>
                {
                    smenaChisel();
                });
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Future_Values1();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numericUpDown6.Value; i++)
            {
                Future_Values2();
            }
        }
        private void Future_Values1()
        {
            label11.Text = Convert.ToString(numericUpDown1.Value + 50);
            label12.Text = Convert.ToString(numericUpDown2.Value + 5);
            label13.Text = Convert.ToString(numericUpDown3.Value + 50);
            label14.Text = Convert.ToString(numericUpDown4.Value + 5);
        }
        private void Future_Values2()
        {
            label11.Text = Convert.ToString(Convert.ToInt32(label11.Text) + 50);
            label12.Text = Convert.ToString(Convert.ToInt32(label12.Text) + 5);
            label13.Text = Convert.ToString(Convert.ToDouble(label13.Text) + 50);
            label14.Text = Convert.ToString(Convert.ToInt32(label14.Text) + 5);
        }
        private void Label25_Change()//это дерьмо не работает
        {
            
        label25.Text = Convert.ToString(55.755831+10) + "°";
            
        }
    }
}
