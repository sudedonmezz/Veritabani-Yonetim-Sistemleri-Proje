using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VerTabanProje
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Insert_ok_Click(object sender, EventArgs e)
        {
            INSERT.Enabled = true;

            if (comboBox1.SelectedIndex == 0 && checkBox1.Checked)
            {
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;

                kartID.Enabled = true;
                TC.Enabled = true;
                DogumT.Enabled = true;
                RenkTx.Text = "yesil";
                UcretTx.Text = "10tl";
                //60 yas usutu


            }
            else if (comboBox1.SelectedIndex == 1 && checkBox1.Checked)
            {
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;

                kartID.Enabled = true;
                TC.Enabled = true;
                DogumT.Enabled = true;
                RenkTx.Text = "sari";
                UcretTx.Text = "0tl";
            }
            else if (comboBox1.SelectedIndex == 2 && checkBox1.Checked)
            {
                label2.Enabled = true;
                kartID.Enabled = true;
                RenkTx.Text = "Kirmzi";
                UcretTx.Text = "13tl";
            }
            else if (comboBox1.SelectedIndex == 3 && checkBox1.Checked)
            {
                label2.Enabled = true;
                label3.Enabled = true;
                label8.Enabled = true;

                kartID.Enabled = true;
                TC.Enabled = true;
                BelgeID.Enabled = true;
                RenkTx.Text = "yesil";
                UcretTx.Text = "0tl";
            }
            else if (comboBox1.SelectedIndex == 4 && checkBox1.Checked)
            {
                label2.Enabled = true;
                label3.Enabled = true;
                label5.Enabled = true;
                label6.Enabled = true;

                kartID.Enabled = true;
                TC.Enabled = true;
                OkulAd.Enabled = true;
                OgrenciNo.Enabled = true;
                RenkTx.Text = "mor";
                UcretTx.Text = "7tl";
            }
            else if (comboBox1.SelectedIndex == 5 && checkBox1.Checked)
            {
                label2.Enabled = true;
                label3.Enabled = true;
                label5.Enabled = true;
                label7.Enabled = true;

                kartID.Enabled = true;
                TC.Enabled = true;
                OkulAd.Enabled = true;
                OgretmenNo.Enabled = true;

                RenkTx.Text = "kahverengi";
                UcretTx.Text = "10tl";
            }
            else if (comboBox1.SelectedIndex == 6 && checkBox1.Checked)
            {
                label2.Enabled = true;
                label3.Enabled = true;
                label8.Enabled = true;

                kartID.Enabled = true;
                TC.Enabled = true;
                BelgeID.Enabled = true;

                RenkTx.Text = "sari";
                UcretTx.Text = "0tl";
                // belge engelli kart ve sehit kart icinde var
            }
            else if (comboBox1.SelectedIndex == 2 && checkBox2.Checked)
            {
                label2.Enabled = true;
                kartID.Enabled = true;

                RenkTx.Text = "gri";
                UcretTx.Text = "1177tl";
            }
            else if (comboBox1.SelectedIndex == 4 && checkBox2.Checked)
            {

                label2.Enabled = true;
                label3.Enabled = true;
                label5.Enabled = true;
                label6.Enabled = true;

                kartID.Enabled = true;
                TC.Enabled = true;
                OkulAd.Enabled = true;
                OgrenciNo.Enabled = true;
                RenkTx.Text = "mor";
                UcretTx.Text = "212tl";
            }
            else if (comboBox1.SelectedIndex == 0 && checkBox2.Checked || comboBox1.SelectedIndex == 5 && checkBox2.Checked)
            {
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;
                label8.Enabled = true;
                label5.Enabled = true;
                label7.Enabled = true;

                kartID.Enabled = true;
                TC.Enabled = true;
                BelgeID.Enabled = true;
                OkulAd.Enabled = true;
                OgretmenNo.Enabled = true;
                DogumT.Enabled = true;

                RenkTx.Text = "kirmizi";
                UcretTx.Text = "483tl";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void INSERT_Click(object sender, EventArgs e)
        {

            string tarihString = DogumT.Text;

            /*if (DateTime.TryParseExact(tarihString, 'yyyy-MM-dd', null, System.Globalization.DateTimeStyles.None, out DateTime tarih))
            {
                // Başarılı ise, tarih değerini istediğiniz şekilde kullanabilirsiniz
                MessageBox.Show("Tarih: " + tarih.ToString('yyyy-MM-dd'), "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Başarısız ise, kullanıcıyı bilgilendir
                MessageBox.Show("Geçersiz tarih formatı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            if (comboBox1.SelectedIndex == 0 && checkBox1.Checked)
            {
                
                try
                {
                    int tcno = int.Parse(TC.Text);
                    int kID = int.Parse(kartID.Text);

                    using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=Odev2;Username=postgres;Password=masratip;"))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand("insert_to60yasustu", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            // DateTimePicker'dan tarih bilgisini al

                            //DateTime selectedDate = DogumT.Value.Date;

                            command.Parameters.AddWithValue("KartlarID", kID);
                            command.Parameters.AddWithValue("TC_NO", tcno);
                                command.Parameters.AddWithValue("Dogum_Tarihi", tarihString);

                                command.ExecuteNonQuery();

                                MessageBox.Show("succsesfully inserted.");
                            
                            
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
                    int tcno = int.Parse(TC.Text);
                    int kID = int.Parse(kartID.Text);

                    using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=Odev2;Username=postgres;Password=masratip;"))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand("insert_to65yasustu", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("KartlarID", kID);
                            command.Parameters.AddWithValue("TC_NO", tcno);
                            command.Parameters.AddWithValue("Dogum_Tarihi", NpgsqlTypes.NpgsqlDbType.Date, DateTime.Now.Date);

                            command.ExecuteNonQuery();

                            MessageBox.Show("succsesfully inserted.");


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


                    using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=Odev2;Username=postgres;Password=masratip;"))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand("insert_toK", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("KartlarID", kID);
                            command.ExecuteNonQuery();

                            MessageBox.Show("succsesfully inserted.");


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
                    int tcno = int.Parse(TC.Text);
                    int belge = int.Parse(BelgeID.Text);
                    int kID = int.Parse(kartID.Text);



                    using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=Odev2;Username=postgres;Password=masratip;"))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand("insert_toEngelliK", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("KartlarID", kID);
                            command.Parameters.AddWithValue("TC_NO", tcno);
                            command.Parameters.AddWithValue("Belge_ID",belge );
                            
                            command.ExecuteNonQuery();

                            MessageBox.Show("succsesfully inserted.");


                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }

            else if (comboBox1.SelectedIndex == 4 && checkBox1.Checked)
            {
                try
                {
                    int tcno = int.Parse(TC.Text);
                    int ogrencino = int.Parse(OgrenciNo.Text);
                    int kID = int.Parse(kartID.Text);


                    using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=Odev2;Username=postgres;Password=masratip;"))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand("insert_toOgrenciK", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("KartlarID", kID);
                            command.Parameters.AddWithValue("TC_NO", tcno);
                            command.Parameters.AddWithValue("OkulAdi", OkulAd.Text);
                            command.Parameters.AddWithValue("ogrenci_No", ogrencino);

                            command.ExecuteNonQuery();

                            MessageBox.Show("succsesfully inserted.");


                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            else if (comboBox1.SelectedIndex == 5 && checkBox1.Checked)
            {
                try
                {
                    int tcno = int.Parse(TC.Text);
                    int personLno = int.Parse(OgretmenNo.Text);
                    int kID = int.Parse(kartID.Text);


                    using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=Odev2;Username=postgres;Password=masratip;"))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand("insert_toOgretmenK", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("KartlarID", kID);
                            command.Parameters.AddWithValue("TC_NO", tcno);
                            command.Parameters.AddWithValue("OkulAdi", OkulAd.Text);
                            command.Parameters.AddWithValue("personal_No", personLno);

                            command.ExecuteNonQuery();

                            MessageBox.Show("succsesfully inserted.");


                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            else if (comboBox1.SelectedIndex == 6 && checkBox1.Checked)
            {
                try
                {
                    int tcno = int.Parse(TC.Text);
                    int belge = int.Parse(BelgeID.Text);
                    int kID = int.Parse(kartID.Text);


                    using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=Odev2;Username=postgres;Password=masratip;"))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand("insert_toSehitAilesiK", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("KartlarID", kID);
                            command.Parameters.AddWithValue("TC_NO", tcno);
                            command.Parameters.AddWithValue("Belge_ID", belge);

                            command.ExecuteNonQuery();

                            MessageBox.Show("succsesfully inserted.");


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


                    using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=Odev2;Username=postgres;Password=masratip;"))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand("insert_toTamAylik", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("KartlarID", kID);

                            command.ExecuteNonQuery();

                            MessageBox.Show("succsesfully inserted.");


                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            else if (comboBox1.SelectedIndex == 4 && checkBox2.Checked)
            {
                try
                {
                    int tcno = int.Parse(TC.Text);
                    int ogrencino = int.Parse(OgrenciNo.Text);
                    int kID = int.Parse(kartID.Text);


                    using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=Odev2;Username=postgres;Password=masratip;"))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand("insert_toOgrenciAylik", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("KartlarID", kID);
                            command.Parameters.AddWithValue("TC_NO", tcno);
                            command.Parameters.AddWithValue("OkulAdi", OkulAd.Text);
                            command.Parameters.AddWithValue("ogrenci_No", ogrencino);

                            command.ExecuteNonQuery();

                            MessageBox.Show("succsesfully inserted.");


                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            else if (comboBox1.SelectedIndex == 0 && checkBox2.Checked || comboBox1.SelectedIndex == 5 && checkBox2.Checked)
            {
                try
                {
                    int tcno = int.Parse(TC.Text);
                    int personal = int.Parse(OgretmenNo.Text);
                    int kID = int.Parse(kartID.Text);



                    using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=Odev2;Username=postgres;Password=masratip;"))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand("insert_toSosyalAylik", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("KartlarID", kID);
                            command.Parameters.AddWithValue("TC_NO", tcno);
                            command.Parameters.AddWithValue("OkulAdi", OkulAd.Text);
                            command.Parameters.AddWithValue("personalNo",personal);
                         //   command.Parameters.AddWithValue("@Dogum_Tarihi",DogumT.Text);

                            command.ExecuteNonQuery();

                            MessageBox.Show("succsesfully inserted.");


                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            
        }
    }
}
