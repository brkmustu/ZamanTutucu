using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ZamanTutucu.WinFormApp
{
    public partial class ZamanTutucu : Form
    {
        private DateTime sayac_time = new DateTime();
        public ZamanTutucu()
        {
            TopMost = true;
            InitializeComponent();
            timer1.Interval = 1000;
            sayac_lbl.Text = sayac_time.ToString("HH:mm:ss");
            UygulamaAyarlari.AyarlarDosyasiniOlustur();
        }

        private void MevcutLoglariYukle()
        {
            dataGridView1.Rows.Clear();
            var mevcutLoglar = Worklog.DosyadanOku();
            if (mevcutLoglar != null && mevcutLoglar.Count > 0)
            {
                if (mevcutLoglar.TryGetValue(Worklog.EforGunAdi(), out List<Worklog> dayLogs))
                {
                    foreach (var item in dayLogs)
                    {
                        dataGridView1.Rows.Add(item.JiraNo, item.Aciklama, item.Sure);
                    }
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            MevcutLoglariYukle();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MevcutLoglariYukle();
            dataGridView1.Rows.Add(txt_jirano.Text, rtxt_aciklama.Text, sayac_time.ToString("HH:mm:ss"));
            sayac_time = new DateTime();
            sayac_lbl.Text = sayac_time.ToString("HH:mm:ss");
            txt_jirano.Text = "";
            rtxt_aciklama.Text = "";
            LogEkle();
        }

        private void baslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MevcutLoglariYukle();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac_time = sayac_time.AddSeconds(1);
            sayac_lbl.Text = sayac_time.ToString("HH:mm:ss");
        }

        private void durdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void eksilt_Click(object sender, EventArgs e)
        {
            sayac_time = sayac_time.AddMinutes(-1);
            sayac_lbl.Text = sayac_time.ToString("HH:mm:ss");
        }

        private void arttir_Click(object sender, EventArgs e)
        {
            sayac_time = sayac_time.AddMinutes(1);
            sayac_lbl.Text = sayac_time.ToString("HH:mm:ss");
        }

        private void LogEkle()
        {
            var worklogs = new List<Worklog>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                worklogs.Add(new Worklog(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString()));
            }

            var writingLogs = new Dictionary<string, List<Worklog>>();

            var dosyadakiLoglar = Worklog.DosyadanOku();

            if (dosyadakiLoglar != null && dosyadakiLoglar.Count > 0)
            {
                foreach (var worklogsInDay in dosyadakiLoglar)
                {
                    if (worklogsInDay.Key == Worklog.EforGunAdi())
                        continue;

                    writingLogs.Add(worklogsInDay.Key, worklogsInDay.Value);
                }
            }

            writingLogs.Add(Worklog.EforGunAdi(), worklogs);
            Worklog.DosyayaYaz(writingLogs);
        }

        private void btn_ayarlar_Click(object sender, EventArgs e)
        {
            var ayarlar = new Ayarlar();
            ayarlar.Show();
        }

        private void btn_tumloglar_Click(object sender, EventArgs e)
        {
            var uygulamaAyarlari = UygulamaAyarlari.Oku();

            var worklogDosyaYolu = uygulamaAyarlari != null ? uygulamaAyarlari.WorkLogsDosyaYolu : null;

            string[] files = Directory.GetFiles(worklogDosyaYolu);

            var workLogList = new Dictionary<string, List<Worklog>>();

            foreach (string file in files)
            {
                if (file.EndsWith("tumLoglar.json"))
                    continue;

                var worklogs = Worklog.DosyadanOku(file);
                if (worklogs != null && worklogs.Count > 0)
                {
                    foreach (var worklogsInDay in worklogs)
                    {
                        workLogList.Add(worklogsInDay.Key, worklogsInDay.Value);
                    }
                }
            }

            if (workLogList == null || workLogList.Count == 0)
            {
                MessageBox.Show("Gösterilecek herhangi log bulunamadı!");
            }
            else
            {
                Worklog.DosyayaYaz(workLogList, "tumLoglar.json");

                System.Diagnostics.Process.Start("notepad++.exe", Worklog.TamDosyaAdi("tumLoglar.json"));
            }
        }
    }

    public class Yardimci
    {
        public static CultureInfo CultureInfo => new CultureInfo("tr-tr", false);
    }

    public class Worklog
    {

        public Worklog(string jiraNo, string aciklama, string sure)
        {
            Tarih = DateTime.Now;
            JiraNo = jiraNo;
            Aciklama = aciklama;
            Sure = sure;
        }
        public string JiraNo { get; private set; }
        public string Aciklama { get; private set; }
        public string Sure { get; private set; }
        public DateTime Tarih { get; private set; }

        public static string DosyaAdi()
        {
            return DateTime.Now.ToString("yyyy-MMMM", Yardimci.CultureInfo);
        }
        /// <summary>
        /// parametre boş gönderilirse bugünün string değeri döndürülür
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string EforGunAdi(DateTime? value = null)
        {
            return value.HasValue ? value.Value.ToString("yyyy-MM-dd") : DateTime.Now.ToString("yyyy-MM-dd");
        }

        public static void DosyayaYaz(List<Worklog> worklogs, string dosyaAdi = "")
        {
            worklogs = worklogs.Distinct(new WorklogEqualityComparer()).ToList();
            using (StreamWriter writer = new StreamWriter(TamDosyaAdi(dosyaAdi), false))
            {
                writer.Write(JsonConvert.SerializeObject(new Dictionary<string, List<Worklog>>
                {
                    { EforGunAdi(), worklogs }
                }, Formatting.Indented));
            }
        }
        public static void DosyayaYaz(Dictionary<string, List<Worklog>> worklogs, string dosyaAdi = "")
        {
            var toWriteList = new Dictionary<string, List<Worklog>>();
            foreach (var worklogsInDay in worklogs)
            {
                var currentWorklogs = worklogsInDay.Value.Distinct(new WorklogEqualityComparer()).ToList();
                toWriteList.Add(worklogsInDay.Key, currentWorklogs);
            }
            using (StreamWriter writer = new StreamWriter(TamDosyaAdi(dosyaAdi), false))
            {
                writer.Write(JsonConvert.SerializeObject(toWriteList, Formatting.Indented));
            }
        }

        public static string TamDosyaAdi(string dosyaAdi = "")
        {
            var uygulamaAyarlari = UygulamaAyarlari.Oku();

            var worklogDosyaYolu = uygulamaAyarlari != null ? uygulamaAyarlari.WorkLogsDosyaYolu : null;

            var path = Path.GetDirectoryName(string.IsNullOrEmpty(worklogDosyaYolu) ? Application.ExecutablePath : worklogDosyaYolu);

            var worklogsPath = Path.Combine(path, "worklogs");

            if (!Directory.Exists(worklogsPath))
                Directory.CreateDirectory(worklogsPath);

            return Path.Combine(worklogsPath, string.IsNullOrEmpty(dosyaAdi) ? DosyaAdi() + ".json" : dosyaAdi);
        }

        public static Dictionary<string, List<Worklog>> DosyadanOku(string dosyaAdi = "")
        {
            var _dosyaAdi = TamDosyaAdi(dosyaAdi);
            if (!File.Exists(_dosyaAdi)) return null;
            var currentWorkLogsText = File.ReadAllText(_dosyaAdi);
            if (string.IsNullOrEmpty(currentWorkLogsText)) return null;
            return JsonConvert.DeserializeObject<Dictionary<string, List<Worklog>>>(currentWorkLogsText);
            //var currentLogs = new List<Worklog>();
            //for (int i = 1; i <= DateTime.Now.Day; i++)
            //{
            //    if (logs.TryGetValue(EforGunAdi(new DateTime(DateTime.Now.Year, DateTime.Now.Month, i)), out List<Worklog> dayLogs))
            //    {
            //        currentLogs.AddRange(dayLogs);
            //    }
            //}
            //return currentLogs;
        }
    }

    public class WorklogEqualityComparer : IEqualityComparer<Worklog>
    {
        public bool Equals(Worklog x, Worklog y)
        {
            return x.JiraNo.Equals(y.JiraNo) && x.Sure.Equals(y.Sure) && x.Aciklama.Equals(y.Aciklama);
        }

        public int GetHashCode(Worklog obj)
        {
            return obj.JiraNo.GetHashCode() + obj.Aciklama.GetHashCode() + obj.Sure.GetHashCode();
        }
    }
}
