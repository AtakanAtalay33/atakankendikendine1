using atakankendikendine1.Models;
using atakankendikendine1.MyDbContact;

namespace atakankendikendine1
{
    public partial class Form1 : Form
    { // Db ile iletiþim kurmak için kendi contactýmý çaðýracagým
        MyDbContactt _db;
        LicensePlate Plaka;
        public Form1()
        {
            InitializeComponent();
            _db = new MyDbContactt();
            Plaka = new LicensePlate(); // global deðiþken olsunlar deyü
        }

        // ilk önce textbox ý boþ olarak kullanamamalarýný saðlayan bir metot yazalým
        public bool TextBoxKontrol()
        {
            if (string.IsNullOrEmpty(txtLicensePlate.Text))
                return true; // boþsa true gönder 

            return false; // boþ deðilse false gönder 
        }
        // eðer hata alýnacak bir iþlem yaptýlarsa bunun kontrolünü saðlayacak bir messagebox için yani her seferinde messagebox içine yazdýrmadan bir string ifadeyle mesajý yazdýrýp metotun içine gönderelim 
        public void Mesaj(string mesaj)
        {
            MessageBox.Show(mesaj, "Warning!", MessageBoxButtons.OK);
            return;
        }

        // grid ekranýnda gözükmüyor eklediðim þey atakan sen kendi db zýmbýrtýný kullanmadýn ki ??? nerede kullancaðýný iyi öðren !
        private void btnPlakaEkle_Click(object sender, EventArgs e)
        {  // ekle butonun iþlevi ekle butonuna basýldýðý zaman txt box içindeki verinin tablo verisi olarak grid e iþlenmesidir
            if (TextBoxKontrol())
            {
                Mesaj("Lütfen textbox ý boþ býrakmayýnýz !");
            }
            Plaka.Name = txtLicensePlate.Text;
            SecilenPlakaAd.Text = "Seçilen" + Plaka.Name;
            _db.LicensePlates.Add(Plaka); // bunu ekledikten sorna grid de göstermem lazým çünkü databaseden cekecez yani
            _db.SaveChanges();            // BUNU GRID DEN SONRA YAZINCA GRID EKLE BUTONUNA BASTIGIM GIBI YENI VERÝYÝ GÖSTERMEDÝ 
            dgvlicensePlate.DataSource = _db.LicensePlates.ToList();




            /* _db.Add(Plaka);*/ // buradaki eksiðin _db.tablo adý sonra eklemek _db.LicensePlates.Add(Plaka)
            /* dgvlicensePlate.DataSource = Plaka.Name.ToList();*/// asla böyle yapmamalýsýn grid veriyi databaseden çekmeli 
            /* dgvlicensePlate.Rows[0].Visible = false;*/ // kolonlarýn görünürlüðünü engelledim olmadý ama bu  çünkü bunlar atakan rows deðil columns olacakmýþ dgv.Column[0]...









            MessageBox.Show("Tebrikler baþarýyla plaka eklediniz", "Tebrikler", MessageBoxButtons.OK);

            txtLicensePlate.Text = "";
            SecilenPlakaAd.Text = "Seçilen";
        }



        // VERÝ NASIL GÜNCELLERÝM ?
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // grid in sell click eventiyle veriyi seçmeyi baþardýk ve bu veriyi güncelle butonuna bastýgýnda textboxta yazýlan yeni veriyle deðiþtirmesini istiyoruz 
            TextBoxKontrol();
            Plaka.Name = txtLicensePlate.Text;
            _db.SaveChanges();
            MessageBox.Show("Baþarýyla güncelleme iþlemi yaptýnýz");
            dgvlicensePlate.DataSource = _db.LicensePlates.ToList(); // grid güncelleme 




        }
        // grid güncel tabloyu göstersin diye ne yapabiliriz ?
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvlicensePlate.DataSource = _db.LicensePlates.ToList();
        }




        // BEN BÝR VERÝYÝ NASIL SÝLEBÝLÝRÝM ?


        private void btnPlakaSil_Click(object sender, EventArgs e)
        { // PLAKAYI SÝLMEK ÝÇÝN ÝLK ÖNCE GRÝD DEN HANGÝ PLAKAYI SÝLECEGÝMÝZÝ SEÇMEMÝZ LAZIM SÝLECEGÝMÝZ PLAKA BELLÝ OLSUN DÝYE LABEL A  YAZDIRALIM SEÇÝLEN NESNEYÝ SONRA SEÇÝLEN NESNEYÝ SÝLELÝM GRÝD DE GÜNCELLENSÝN 
            if (Plaka != null) // neden null olmadýgý sürece sildirmemiz gerekiyor ? 
            {
                _db.LicensePlates.Remove(Plaka);
                _db.SaveChanges();
                dgvlicensePlate.DataSource = _db.LicensePlates.ToList();
                MessageBox.Show("Plaka baþarýyla silindi");
                Plaka = null;
                SecilenPlakaAd.Text = "Seçilen";
            }
            else
            {
                Mesaj("Lütfen silinecek bir veriye týklayýnýz");
            }

        }

        private void dgvlicensePlate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Plaka = (LicensePlate)dgvlicensePlate.SelectedRows[0].DataBoundItem;
            SecilenPlakaAd.Text = "Seçilen "+Plaka.Name;

        }
    }
}
