using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerTabanProje
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            update.Enabled = true;
            if (comboBox1.SelectedIndex == 0 && checkBox1.Checked)
            {
                label8.Enabled = true;
                BelgeID.Enabled = true;

            }
            else if (comboBox1.SelectedIndex == 1 && checkBox1.Checked)
            {
                label5.Enabled = true;
                label6.Enabled = true;
               

                OkulAd.Enabled = true;
                OgrenciNo.Enabled = true;
               
                
            }
            else if (comboBox1.SelectedIndex == 2 && checkBox1.Checked)
            {
                label5.Enabled = true;
                label7.Enabled = true;
                
                OkulAd.Enabled = true;
                OgretmenNo.Enabled = true;
               
            }
            else if (comboBox1.SelectedIndex == 3 && checkBox1.Checked)
            {
              
                label8.Enabled = true;
                BelgeID.Enabled = true;
                
            }
            else if (comboBox1.SelectedIndex == 0 && checkBox2.Checked)
            {
                MessageBox.Show("Engelli kartin aylik secenegi bulunmamaktadir");
            }

            else if (comboBox1.SelectedIndex == 3 && checkBox2.Checked)
            {
                MessageBox.Show("Sehit Ailesi Kartinin Aylik Secenegi Bulunmamaktadir");
            }
            else if (comboBox1.SelectedIndex == 1 && checkBox2.Checked)
            {

                label2.Enabled = true;
               
                label5.Enabled = true;
                label6.Enabled = true;

                kartID.Enabled = true;
               
                OkulAd.Enabled = true;
                OgrenciNo.Enabled = true;
                
            }
            else if (comboBox1.SelectedIndex == 2 && checkBox2.Checked)
            {

                

                label5.Enabled = true;

                kartID.Enabled = true;

                OkulAd.Enabled = true;
                

            }
            



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && checkBox1.Checked)
            {
                try
                {
                    int kID = int.Parse(kartID.Text);
                    int Belgeid = int.Parse(BelgeID.Text);



                    using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=Odev2;Username=postgres;Password=masratip;"))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand("update_EngelliK_belge", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("Kartlar_ID", kID);

                            command.Parameters.AddWithValue("Belge_ID", Belgeid);


                            command.ExecuteNonQuery();

                            MessageBox.Show("succsesfully updated.");


                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }


            }
            else if (comboBox1.SelectedIndex == 1 && checkBox1.Checked)
            {
                try
                {
                    int kID = int.Parse(kartID.Text);
                    string OKULad = OkulAd.Text;
                    int OgrenciNO = int.Parse(OgrenciNo.Text);



                    using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=Odev2;Username=postgres;Password=masratip;"))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand("update_OgrenciK", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("Kartlar_ID", kID);
                            command.Parameters.AddWithValue("OkulAdi", OKULad);
                            command.Parameters.AddWithValue("ogrenci_No", OgrenciNO);



                            command.ExecuteNonQuery();

                            MessageBox.Show("succsesfully updated.");


                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            else if (comboBox1.SelectedIndex == 2 && checkBox1.Checked)
            {
                try
                {
                    int kID = int.Parse(kartID.Text);
                    string OKULad = OkulAd.Text;
                    int PersNO = int.Parse(OgretmenNo.Text);

                    using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=Odev2;Username=postgres;Password=masratip;"))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand("update_anonim", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("KartlarID", kID);
                            command.Parameters.AddWithValue("OkulAdi", OKULad);
                            command.Parameters.AddWithValue("personal_No", PersNO);

                            command.ExecuteNonQuery();

                            MessageBox.Show("succsesfully updated.");


                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            else if (comboBox1.SelectedIndex == 3 && checkBox1.Checked)
            {
                try
                {
                    int kID = int.Parse(kartID.Text);
                    int belge = int.Parse(BelgeID.Text);


                    using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=Odev2;Username=postgres;Password=masratip;"))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand("update_sehitAilesiK_belge", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("KartlarID", kID);

                            command.Parameters.AddWithValue("Belge_ID", belge);

                            command.ExecuteNonQuery();

                            MessageBox.Show("succsesfully updated.");


                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }

            else if (comboBox1.SelectedIndex == 1 && checkBox2.Checked)
            {
                try
                {
                    int kID = int.Parse(kartID.Text);
                    string OKULad = OkulAd.Text;
                    int OgrenciNO = int.Parse(OgrenciNo.Text);



                    using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=Odev2;Username=postgres;Password=masratip;"))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand("update_toOgrenciAylik", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("Kartlar_ID", kID);
                            command.Parameters.AddWithValue("OkulAdi", OKULad);
                            command.Parameters.AddWithValue("ogrenci_No", OgrenciNO);



                            command.ExecuteNonQuery();

                            MessageBox.Show("succsesfully updated.");


                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            else if (comboBox1.SelectedIndex == 2 && checkBox2.Checked)
            {
                try
                {
                    int kID = int.Parse(kartID.Text);
                    string OKULad = OkulAd.Text;


                    using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=Odev2;Username=postgres;Password=masratip;"))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand("update_toSosyalAylik", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("KartlarID", kID);
                            command.Parameters.AddWithValue("OkulAdi", OKULad);


                            command.ExecuteNonQuery();

                            MessageBox.Show("succsesfully updated.");


                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
