using atakankendikendine1.Models;
using atakankendikendine1.MyDbContact;

namespace atakankendikendine1
{
    public partial class Form1 : Form
    { // Db ile ileti�im kurmak i�in kendi contact�m� �a��racag�m
        MyDbContactt _db;
        LicensePlate Plaka;
        public Form1()
        {
            InitializeComponent();
            _db = new MyDbContactt();
            Plaka = new LicensePlate(); // global de�i�ken olsunlar dey�
        }

        // ilk �nce textbox � bo� olarak kullanamamalar�n� sa�layan bir metot yazal�m
        public bool TextBoxKontrol()
        {
            if (string.IsNullOrEmpty(txtLicensePlate.Text))
                return true; // bo�sa true g�nder 

            return false; // bo� de�ilse false g�nder 
        }
        // e�er hata al�nacak bir i�lem yapt�larsa bunun kontrol�n� sa�layacak bir messagebox i�in yani her seferinde messagebox i�ine yazd�rmadan bir string ifadeyle mesaj� yazd�r�p metotun i�ine g�nderelim 
        public void Mesaj(string mesaj)
        {
            MessageBox.Show(mesaj, "Warning!", MessageBoxButtons.OK);
            return;
        }

        // grid ekran�nda g�z�km�yor ekledi�im �ey atakan sen kendi db z�mb�rt�n� kullanmad�n ki ??? nerede kullanca��n� iyi ��ren !
        private void btnPlakaEkle_Click(object sender, EventArgs e)
        {  // ekle butonun i�levi ekle butonuna bas�ld��� zaman txt box i�indeki verinin tablo verisi olarak grid e i�lenmesidir
            if (TextBoxKontrol())
            {
                Mesaj("L�tfen textbox � bo� b�rakmay�n�z !");
            }
            Plaka.Name = txtLicensePlate.Text;
            SecilenPlakaAd.Text = "Se�ilen" + Plaka.Name;
            _db.LicensePlates.Add(Plaka); // bunu ekledikten sorna grid de g�stermem laz�m ��nk� databaseden cekecez yani
            _db.SaveChanges();            // BUNU GRID DEN SONRA YAZINCA GRID EKLE BUTONUNA BASTIGIM GIBI YENI VER�Y� G�STERMED� 
            dgvlicensePlate.DataSource = _db.LicensePlates.ToList();




            /* _db.Add(Plaka);*/ // buradaki eksi�in _db.tablo ad� sonra eklemek _db.LicensePlates.Add(Plaka)
            /* dgvlicensePlate.DataSource = Plaka.Name.ToList();*/// asla b�yle yapmamal�s�n grid veriyi databaseden �ekmeli 
            /* dgvlicensePlate.Rows[0].Visible = false;*/ // kolonlar�n g�r�n�rl���n� engelledim olmad� ama bu  ��nk� bunlar atakan rows de�il columns olacakm�� dgv.Column[0]...









            MessageBox.Show("Tebrikler ba�ar�yla plaka eklediniz", "Tebrikler", MessageBoxButtons.OK);

            txtLicensePlate.Text = "";
            SecilenPlakaAd.Text = "Se�ilen";
        }



        // VER� NASIL G�NCELLER�M ?
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // grid in sell click eventiyle veriyi se�meyi ba�ard�k ve bu veriyi g�ncelle butonuna bast�g�nda textboxta yaz�lan yeni veriyle de�i�tirmesini istiyoruz 
            TextBoxKontrol();
            Plaka.Name = txtLicensePlate.Text;
            _db.SaveChanges();
            MessageBox.Show("Ba�ar�yla g�ncelleme i�lemi yapt�n�z");
            dgvlicensePlate.DataSource = _db.LicensePlates.ToList(); // grid g�ncelleme 




        }
        // grid g�ncel tabloyu g�stersin diye ne yapabiliriz ?
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvlicensePlate.DataSource = _db.LicensePlates.ToList();
        }




        // BEN B�R VER�Y� NASIL S�LEB�L�R�M ?


        private void btnPlakaSil_Click(object sender, EventArgs e)
        { // PLAKAYI S�LMEK ���N �LK �NCE GR�D DEN HANG� PLAKAYI S�LECEG�M�Z� SE�MEM�Z LAZIM S�LECEG�M�Z PLAKA BELL� OLSUN D�YE LABEL A  YAZDIRALIM SE��LEN NESNEY� SONRA SE��LEN NESNEY� S�LEL�M GR�D DE G�NCELLENS�N 
            if (Plaka != null) // neden null olmad�g� s�rece sildirmemiz gerekiyor ? 
            {
                _db.LicensePlates.Remove(Plaka);
                _db.SaveChanges();
                dgvlicensePlate.DataSource = _db.LicensePlates.ToList();
                MessageBox.Show("Plaka ba�ar�yla silindi");
                Plaka = null;
                SecilenPlakaAd.Text = "Se�ilen";
            }
            else
            {
                Mesaj("L�tfen silinecek bir veriye t�klay�n�z");
            }

        }

        private void dgvlicensePlate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Plaka = (LicensePlate)dgvlicensePlate.SelectedRows[0].DataBoundItem;
            SecilenPlakaAd.Text = "Se�ilen "+Plaka.Name;

        }
    }
}
