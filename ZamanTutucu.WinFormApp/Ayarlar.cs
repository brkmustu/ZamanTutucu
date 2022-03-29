using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace ZamanTutucu.WinFormApp
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
            var ayarlar = UygulamaAyarlari.Oku();
            if (ayarlar != null)
                txt_dosya_yolu.Text = ayarlar.WorkLogsDosyaYolu;
        }

        private void btn_dosyasec_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txt_dosya_yolu.Text = fbd.SelectedPath;
                    lbl_dosya_yolu.Text = fbd.SelectedPath;
                }
            }
        }

        private void btn_ayarlari_kaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_dosya_yolu.Text))
            {
                UygulamaAyarlari.AyarlariKaydet(new UygulamaAyarlari { WorkLogsDosyaYolu = txt_dosya_yolu.Text });
                lbl_dosya_yolu.Text = txt_dosya_yolu.Text;
            }
        }
    }

    public class UygulamaAyarlari
    {
        public string WorkLogsDosyaYolu { get; set; }

        public static string DosyaAdi()
        {
            var path = Path.GetDirectoryName(Application.ExecutablePath);

            var ayarlarPath = Path.Combine(path, "ayarlar");

            if (!Directory.Exists(ayarlarPath))
                Directory.CreateDirectory(ayarlarPath);

            return Path.Combine(ayarlarPath, "ayarlar.json");
        }

        public static void AyarlarDosyasiniOlustur()
        {
            var ayarlarFileName = DosyaAdi();

            if (!File.Exists(ayarlarFileName))
            {
                var file = File.Create(ayarlarFileName);
                file.Close();

                AyarlariKaydet(new UygulamaAyarlari
                {
                    WorkLogsDosyaYolu = Path.GetDirectoryName(Worklog.TamDosyaAdi())
                });
            }
        }

        public static void AyarlariKaydet(UygulamaAyarlari ayarlar)
        {
            using (StreamWriter writer = new StreamWriter(DosyaAdi(), false))
            {
                writer.Write(JsonConvert.SerializeObject(ayarlar, Formatting.Indented));
            }
        }

        public static UygulamaAyarlari Oku()
        {
            var dosyaAdi = DosyaAdi();
            var currentWorkLogsText = File.ReadAllText(dosyaAdi);
            if (string.IsNullOrEmpty(currentWorkLogsText)) return null;
            return JsonConvert.DeserializeObject<UygulamaAyarlari>(currentWorkLogsText);
        }
    }
}
