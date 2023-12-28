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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VerTabanProje
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                int kID = int.Parse(textBox1.Text);

                using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=Odev2;Username=postgres;Password=masratip;"))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM arama(Kartlar_ID) AS result_record(\"KartlarID\" INT, \"TC_NO\" BIGINT, \"60+ dogum_Tarihi\" TEXT, \"60_kRenk\" TEXT, \"60_kUcret\" INT, \"65+ dogum_Tarihi\" TEXT, \"65_kRenk\" TEXT, \"65_kUcret\" INT, \"anonimK_renk\" TEXT, \"anonimK_ucret\" INT, \"Ogrenci_okul\" TEXT, \"Ogrenci_no\" INT, \"Ogrenci_renk\" TEXT, \"Ogrenci_ucret\" INT, \"Ogrenci_okul_Aylik\" TEXT, \"Ogrenci_no_Aylik\" INT, \"Ogrenci_renk_Aylik\" TEXT, \"Ogrenci_ucret_Aylik\" INT, \"Ogretmen_okul\" TEXT, \"personal_no\" INT, \"OgretmenK_renk\" TEXT, \"OgretmenK_ucret\" INT, \"TamAylik_renk\" TEXT, \"TamAylik_ucret\" INT, \"SehitAilesiK_renk\" TEXT, \"SehitAilesiK_belge\" INT, \"SehitAilesiK_ucret\" INT, \"sosyal_ogretmen\" TEXT, \"sosyal_date\" TEXT, \"sosyal_renk\" TEXT, \"sosyal_ucret\" INT);\r\n", connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("Kartlar_ID", kID);

                        command.ExecuteNonQuery();

                        // Create a DataTable to hold the results
                        DataTable dataTable = new DataTable();

                        // Use a DataAdapter to fill the DataTable with the results of the function
                        using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command))
                        {
                            dataAdapter.Fill(dataTable);
                        }

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;

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
