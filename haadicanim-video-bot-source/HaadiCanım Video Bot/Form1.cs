using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Eklenenler
using HtmlAgilityPack;
using System.Net;
using System.IO;
using System.Reflection;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace HaadiCanım_Video_Bot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Değişkenler */
        string kaynakSiteURL = "http://yookartik.com/videolar";
        string kaynakSiteHTML = null;
        string tirnak = null;
        string progYol = Application.StartupPath + @"\Videolar\";
        string zamanFarki = null;


        #region Veri Ayıklama Fonksiyon
        public string ayiklananVeri;
        void veriAyiklama(string kaynakKod, string ilkVeri, int ilkVeriKS, string sonVeri)
        {
            try
            {
                string gelen = kaynakKod;
                int titleIndexBaslangici = gelen.IndexOf(ilkVeri) + ilkVeriKS;
                int titleIndexBitisi = gelen.Substring(titleIndexBaslangici).IndexOf(sonVeri);
                ayiklananVeri = gelen.Substring(titleIndexBaslangici, titleIndexBitisi);
            }
            catch //(Exception ex)
            {
                //MessageBox.Show("Hata: " + ex.Message, "Hata;", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region FORM_LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            //Düzeltmeler
            tirnak = textBox_Tirnak.Text;

            videoListesiCek();
        }
        #endregion

        #region Video Listesi Çekme Fonksiyonu
        void videoListesiCek()
        {

            try
            {
                //Listeyi Temizle
                listView_VideoListesi.Items.Clear();

                //Site Kaynak Kodu Alma
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                kaynakSiteHTML = client.DownloadString(kaynakSiteURL);

                //Xpath Veri Döndürme
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(kaynakSiteHTML);
                HtmlNodeCollection xPath = dokuman.DocumentNode.SelectNodes("//div[@class='col-lg-6 col-md-6 col-xs-6 icerik iceriklist']");
                foreach (var veri in xPath)
                {

                    //Video Adı
                    veriAyiklama(veri.InnerHtml, "<strong>", 8, "</strong>");
                    string videoAdi = ayiklananVeri.Trim();

                    //Video Url
                    veriAyiklama(veri.InnerHtml, "href=" + tirnak, 6, tirnak);
                    string videoUrl = "http:" + ayiklananVeri;

                    //Video Resim
                    veriAyiklama(veri.InnerHtml, "src=" + tirnak, 5, tirnak);
                    string videoResim = "http:" + ayiklananVeri;

                    //Video Açıklama
                    veriAyiklama(veri.InnerHtml, "context3_ozet" + tirnak + ">", 15, "</div>");
                    string videoAciklama = ayiklananVeri.Trim();

                    //Video Listesine Ekleme
                    string[] ciktilar = { videoAdi, videoUrl, videoResim, videoAciklama };
                    ListViewItem veriler = new ListViewItem(ciktilar);
                    listView_VideoListesi.Items.Add(veriler);

                }

                //Bilgi Mesajları
                label1.Text = "Son Güncelleme: " + DateTime.Now.ToString("hh:mm:ss dd MMMM yyyy");
                statusLabel.ForeColor = Color.DarkGreen;
                statusLabel.Text = "Videolar Çekildi. Son Güncelleme: " + DateTime.Now.ToString("hh:mm:ss dd MMMM yyyy");

            }
            catch (Exception ex)
            {
                //Bilgi Mesajları
                label1.Text = "Videoları çekerken bir sorun oluştu.";
                statusLabel.ForeColor = Color.DarkRed;
                statusLabel.Text = "Videoları çekerken bir sorun oluştu. Hata: " + ex.Message;

            }
        }

        #endregion

        #region Video Listesini Çek Button
        private void button1_Click(object sender, EventArgs e)
        {
            videoListesiCek();
        }
        #endregion

        #region VideoListesi Seçili İtem
        private void listView_VideoListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Temizle
            textBox_VideoAdi.Clear();
            textBox_VideoEtiketleri.Clear();
            textBox_VideoAciklama.Clear();
            textBox_VideoKategori.Clear();
            textBox_VideoKaynak.Clear();
            pictureBox_VideoResim.ImageLocation = null;
            button_VideoEkle.Enabled = false;

            //Video Listesi Seçili item
            if (listView_VideoListesi.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem item = listView_VideoListesi.SelectedItems[0];

            //Video Adı
            textBox_VideoAdi.Text = item.SubItems[0].Text;
            label_Baslik_Limit.ForeColor = Color.Blue;
            label_Baslik_Limit.Text = "[" + textBox_VideoAdi.TextLength.ToString() + "] karakter.";

            //Video Açıklama
            textBox_VideoAciklama.Text = item.SubItems[3].Text;
            label_Aciklama_Limit.ForeColor = Color.Blue;
            label_Aciklama_Limit.Text = "[" + textBox_VideoAciklama.TextLength.ToString() + "] karakter.";

            //Video Resim 
            pictureBox_VideoResim.ImageLocation = item.SubItems[2].Text;
            textBox_VideoResim.Text = item.SubItems[2].Text;

            //Seçili Video
            seciliVideo(item.SubItems[1].Text);
            textBox1.Text = item.SubItems[1].Text;
        }
        #endregion

        #region Video Listesinden Seçilen Video Çekme
        void seciliVideo(string videoUrl)
        {

            try
            {
                //Site Kaynak Kodu Alma
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                kaynakSiteHTML = client.DownloadString(videoUrl);

                //Video Kaynak

                veriAyiklama(kaynakSiteHTML, "<iframe src=" + tirnak, 13, tirnak);
                string url = "http:" + ayiklananVeri;
                ayiklananVeri = null;
                webBrowser1.Navigate(url);

                //Video Kategori
                try
                {
                    HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                    dokuman.LoadHtml(kaynakSiteHTML);
                    HtmlNodeCollection XPath = dokuman.DocumentNode.SelectNodes("//span[@class='kategori_adi']/a");
                    foreach (var veri in XPath)
                    {
                        textBox_VideoKategori.Text += veri.InnerText;
                    }
                }
                catch { }

                //Video Etiket
                string videoEtiket = textBox_VideoAdi.Text;
                string[] etiketler = videoEtiket.Split(' ');
                foreach (string etiket in etiketler)
                {
                    textBox_VideoEtiketleri.Text += etiket.ToLower() + ",";
                }

                //Bilgi Mesajları
                statusLabel.ForeColor = Color.DarkGreen;
                statusLabel.Text = "Seçili video bilgileri çekildi. Tarih: " + DateTime.Now.ToString("hh:mm:ss dd MMMM yyyy");
            }
            catch (Exception ex)
            {
                //Bilgi Mesajları
                statusLabel.ForeColor = Color.DarkRed;
                statusLabel.Text = "Seçili video çekilirken hata oluştu. Hata: " + ex.Message;
            }

        }

        #region Video Kaynağı WebBrowser
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                string htmlkod = webBrowser1.Document.Body.InnerHtml.ToString();
                veriAyiklama(htmlkod, ",{" + tirnak + "url" + tirnak + ":" + tirnak, 9, ".mp4");
                textBox_VideoKaynak.Text = ayiklananVeri + ".mp4";
                webBrowser1.Stop();
                button_VideoEkle.Enabled = true; 
            }
            catch (Exception ex)
            {
                //Bilgi Mesajları
                statusLabel.ForeColor = Color.DarkRed;
                statusLabel.Text = "Seçili videonun video kaynağı çekilemedi. Hata: " + ex.Message;
            }
        }
        #endregion

        #endregion

        #region Seo Limit KeyPress
        private void textBox_VideoAdi_KeyUp(object sender, KeyEventArgs e)
        {
            int limit = textBox_VideoAdi.TextLength;
            label_Baslik_Limit.Text = "[" + limit.ToString() + "]";
             if (limit > 70)
             {
                 label_Baslik_Limit.ForeColor = Color.Red;
                 label_Baslik_Limit.Text = "[" + limit.ToString() + "] karakter. 70 karakteri aştı. Seo açısından sorun olabilir.";
             }
             else
             {
                 label_Baslik_Limit.ForeColor = Color.Blue;
                 label_Baslik_Limit.Text = "[" + limit.ToString() + "] karakter.";
             }
        }

        private void textBox_VideoAciklama_KeyUp(object sender, KeyEventArgs e)
        {
            int limit = textBox_VideoAciklama.TextLength;
            label_Aciklama_Limit.Text = "[" + limit.ToString() + "]";
            if (limit > 256)
            {
                label_Aciklama_Limit.ForeColor = Color.Red;
                label_Aciklama_Limit.Text = "[" + limit.ToString() + "] karakter. 256 karakteri aştı.";
            }
            else
            {
                label_Aciklama_Limit.ForeColor = Color.Blue;
                label_Aciklama_Limit.Text = "[" + limit.ToString() + "] karakter.";
            }
        }
        #endregion

        #region Video İndirme İşlemi
        private void videoDownload(string downLink, string kayitYol)
        {
            try
            {
                // Zaman Farkı
                zamanFarki = DateTime.Now.ToString();

                WebClient client = new WebClient();
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                client.DownloadFileAsync(new Uri(downLink), kayitYol);

                //Bilgi Mesajı
                statusLabel.ForeColor = Color.DarkGreen;
                statusLabel.Text = "Seçili video indirme işlemi başladı. Tarih: " + DateTime.Now.ToString("hh:mm:ss dd MMMM yyyy");
            }
            catch (Exception ex)
            {
                //Bilgi Mesajı
                statusLabel.ForeColor = Color.DarkRed;
                statusLabel.Text = "Video indirme işleminde hata oluştu. Hata: " + ex.Message;
                MessageBox.Show("Video indirme işleminde hata oluştu./nHata: " + ex.Message,"Hata!",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                //Diğer
                listView_VideoListesi.Enabled = true;
                button1.Enabled = true;
            }
        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            //indirme tamamlandığında
            TimeSpan ts = (Convert.ToDateTime(zamanFarki) - Convert.ToDateTime(DateTime.Now));

            //Bilgi Mesajı
            statusLabel.ForeColor = Color.DarkGreen;
            statusLabel.Text = "Video başarıyla indirildi. " + ts.Seconds + " saniye sürdü.";

            //Youtube video upload
            Run();

        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        { 
            //indirme yüzdesi
            progress_VideoIndirme.Value = e.ProgressPercentage;

            //Bilgi Mesajı
            statusLabel.ForeColor = Color.DarkBlue;
            statusLabel.Text = "["+ e.ProgressPercentage.ToString() + " %] seçili video indiriliyor. Tarih: " + DateTime.Now.ToString("hh:mm:ss dd MMMM yyyy");
        }
        #endregion

        #region Youtube Upload
        private async Task Run()
        {
            UserCredential credential;
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    // This OAuth 2.0 access scope allows an application to upload files to the
                    // authenticated user's YouTube channel, but doesn't allow other types of access.
                    new[] { YouTubeService.Scope.YoutubeUpload },
                    "user",
                    CancellationToken.None
                );
            }


            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = Assembly.GetExecutingAssembly().GetName().Name
            });

            var video = new Video();
            video.Snippet = new VideoSnippet();
            video.Snippet.Title = "Default Video Title";
            video.Snippet.Description = "Default Video Description";
            video.Snippet.Tags = new string[] { "tag1", "tag2" };
            video.Snippet.CategoryId = "22"; // See https://developers.google.com/youtube/v3/docs/videoCategories/list
            video.Status = new VideoStatus();
            video.Status.PrivacyStatus = "unlisted"; // or "private" or "public"
            var filePath = @"D:\VB6 - C# Projelerim\haadicanim-video-bot-source\HaadiCanım Video Bot\bin\Debug\Videolar\Uyanmakta Zorlananlar İçi.mp4"; // Replace with path to actual movie file.

            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                var videosInsertRequest = youtubeService.Videos.Insert(video, "snippet,status", fileStream, "video/*");
                videosInsertRequest.ProgressChanged += videosInsertRequest_ProgressChanged;
                videosInsertRequest.ResponseReceived += videosInsertRequest_ResponseReceived;

                await videosInsertRequest.UploadAsync();
            }
        }

        void videosInsertRequest_ProgressChanged(Google.Apis.Upload.IUploadProgress progress)
        {
            /*switch (progress.Status)
            {
                case UploadStatus.Uploading:
                    //Bilgi Mesajları
                    statusLabel.ForeColor = Color.DarkBlue;
                    statusLabel.Text = "[" + progress.BytesSent.ToString() + "] Video yükleniyor. Tarih: " + DateTime.Now.ToString("hh:mm:ss dd MMMM yyyy");
                break;

                case UploadStatus.Failed:
                    //Bilgi Mesajları
                    statusLabel.ForeColor = Color.DarkRed;
                    statusLabel.Text = "Video yüklenirken hata oluştu. Hata: " + progress.Exception;
                break;
            }*/
        }

        void videosInsertRequest_ResponseReceived(Video video)
        {
            //Bilgi Mesajları
            statusLabel.ForeColor = Color.DarkGreen;
            statusLabel.Text = "Video başarıyla Youtube yüklendi. Tarih: " + DateTime.Now.ToString("hh:mm:ss dd MMMM yyyy");
            textBox_YoutubeLink.Text = "https://youtu.be/" + video.Id;
        }

        #endregion













        private void button_VideoEkle_Click(object sender, EventArgs e)
        {
            //Diğer
            button_VideoEkle.Enabled = false;
            listView_VideoListesi.Enabled = false;
            button1.Enabled = false;

            //Bilgi Mesajı
            statusLabel.ForeColor = Color.DarkGreen;
            statusLabel.Text = "Video Ekleme İşlemi Başladı. Tarih: " + DateTime.Now.ToString("hh:mm:ss dd MMMM yyyy");

            //Video İndirme
            string downLink = textBox_VideoKaynak.Text;
            string dosyaAdi = textBox_VideoAdi.Text + ".mp4";
            string kayitYol = progYol + dosyaAdi;
            textBox_VideoLocalKayitYol.Text = kayitYol;
            videoDownload(downLink, kayitYol);
        }


    }
}
