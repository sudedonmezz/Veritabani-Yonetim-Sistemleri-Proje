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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VerTabanProje
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // NpgsqlConnection nesnesi oluşturun ve bağlantıyı açın
            using (NpgsqlConnection baginti = new NpgsqlConnection("host=localhost;port=5432;dbname=Odev2;user=postgres;password=masratip;"))
            {
                baginti.Open();

                // Seçilen kart türüne göre saklı yordam adını belirleyin
                string selectedProcedure = GetSelectedProcedure();

                // Eğer geçerli bir kart türü seçilmemişse hata mesajı göster
                if (string.IsNullOrEmpty(selectedProcedure))
                {
                    MessageBox.Show("Lütfen geçerli bir kart türü seçin.");
                    return;
                }

                // NpgsqlCommand nesnesi oluşturun ve saklı yordamı çağırın
                using (NpgsqlCommand cmd = new NpgsqlCommand(selectedProcedure, baginti))
                {
                    // Saklı yordamın türünü belirtin
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // textbox1 içeriğini integer'a çevirip saklı yordam parametresine ekleyin
                    int kartId;
                    if (int.TryParse(textBox1.Text, out kartId))
                    {
                        cmd.Parameters.AddWithValue("kartid", kartId);
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir kart ID giriniz.");
                        return;
                    }

                    // Saklı yordamı çalıştırın
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Silme işlemi tamamlandı.");
            }
        }
        private string GetSelectedProcedure()
        {
            // Kart türüne göre saklı yordam adını belirleyen fonksiyon
            switch (comboBox1.SelectedItem?.ToString())
            {
                case "60_yasiustu_Kart":
                    return "delete_60yasiustu";
                case "65_yasiustu_Kart":
                    return "delete_65yasiustu";
                case "Anonim":
                    return "delete_Anonim";
                case "Engelli_Kart":
                    return "delete_EngelliK";
                case "Ogrenci":
                    return "delete_Ogrenci";
                case "Ogretmen":
                    return "delete_Ogretmen";
                case "OgrenciAylik":
                    return "delete_OgrenciAylik";
                case "TamAylik":
                    return "delete_TamAylik";
                case "sosyalAylik":
                    return "delete_SosyalAylik";
                case "sehitAilesi_Kart":
                    return "delete_SehitAilesiK";
                default:
                    return null;
            }
        }

    }

}
    