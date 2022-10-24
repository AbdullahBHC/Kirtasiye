using System;
using System.Collections.ObjectModel;
using System.Text;

namespace Kırtasiye.Models
{
    public static class Veriler
    {
        public static ObservableCollection<Kategori> Kategoriler = new ObservableCollection<Kategori>();
        public static ObservableCollection<Urun> Urunler = new ObservableCollection<Urun>();

        static Veriler()
        {
            Kategoriler.Add(new Kategori() {UrunKategorisi="Kalemler"});
            Kategoriler.Add(new Kategori() {UrunKategorisi="Defter ve Kitaplar"});
            Kategoriler.Add(new Kategori() { UrunKategorisi = "Boyalar"});
            Kategoriler.Add(new Kategori() { UrunKategorisi = "Diğer" });

            Urunler.Add(new Urun() {
                UrunAdi = "Kurşun Kalem",
                UrunAlisFiyati = 4,
                UrunSatisFiyati = 5,
                UrunAdeti = 200,
                UrunKategorisi = Kategoriler[0]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "Silgi",
                UrunAlisFiyati = 4,
                UrunSatisFiyati = 5,
                UrunAdeti = 200,
                UrunKategorisi = Kategoriler[3]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "Defter",
                UrunAlisFiyati = 15,
                UrunSatisFiyati = 20,
                UrunAdeti = 50,
                UrunKategorisi = Kategoriler[1]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "Kitap",
                UrunAlisFiyati = 25,
                UrunSatisFiyati = 30,
                UrunAdeti = 50,
                UrunKategorisi = Kategoriler[1]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "Çanta",
                UrunAlisFiyati = 300,
                UrunSatisFiyati = 350,
                UrunAdeti = 10,
                UrunKategorisi = Kategoriler[3]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "Cetvel",
                UrunAlisFiyati = 7,
                UrunSatisFiyati = 10,
                UrunAdeti = 100,
                UrunKategorisi = Kategoriler[3]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "Makas",
                UrunAlisFiyati = 7,
                UrunSatisFiyati = 10,
                UrunAdeti = 100,
                UrunKategorisi = Kategoriler[3]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "Print Yapıştırıcı",
                UrunAlisFiyati = 15,
                UrunSatisFiyati = 20,
                UrunAdeti = 100,
                UrunKategorisi = Kategoriler[3]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "Faber Castell Pastel Boya 12 Renk",
                UrunAlisFiyati = 40,
                UrunSatisFiyati = 50,
                UrunAdeti = 50,
                UrunKategorisi = Kategoriler[2]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "Faber Castell Kuru Boya 12 Renk",
                UrunAlisFiyati = 30,
                UrunSatisFiyati = 40,
                UrunAdeti = 50,
                UrunKategorisi = Kategoriler[2]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "Faber Castell Sulu Boya 12 Renk",
                UrunAlisFiyati = 30,
                UrunSatisFiyati = 40,
                UrunAdeti = 50,
                UrunKategorisi = Kategoriler[2]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "Keçeli Boya 24 Renk",
                UrunAlisFiyati = 40,
                UrunSatisFiyati = 50,
                UrunAdeti = 50,
                UrunKategorisi = Kategoriler[2]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "Suluk 700mL.",
                UrunAlisFiyati = 90,
                UrunSatisFiyati = 100,
                UrunAdeti = 50,
                UrunKategorisi = Kategoriler[3]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "24'lü 0.7 Uç 3 Adet",
                UrunAlisFiyati = 20,
                UrunSatisFiyati = 25,
                UrunAdeti = 100,
                UrunKategorisi = Kategoriler[0]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "Beslenme Çantası",
                UrunAlisFiyati = 180,
                UrunSatisFiyati = 200,
                UrunAdeti = 50,
                UrunKategorisi = Kategoriler[3]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "8'li Fosforlu Kalem",
                UrunAlisFiyati = 40,
                UrunSatisFiyati = 50,
                UrunAdeti = 100,
                UrunKategorisi = Kategoriler[0]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "Kalem Kutusu",
                UrunAlisFiyati = 40,
                UrunSatisFiyati = 50,
                UrunAdeti = 50,
                UrunKategorisi = Kategoriler[3]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "12'li Büro Bandı",
                UrunAlisFiyati = 40,
                UrunSatisFiyati = 45,
                UrunAdeti = 50,
                UrunKategorisi = Kategoriler[3]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "Kalemtıraş",
                UrunAlisFiyati = 15,
                UrunSatisFiyati = 20,
                UrunAdeti = 100,
                UrunKategorisi = Kategoriler[0]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "80gr. A4",
                UrunAlisFiyati = 90,
                UrunSatisFiyati = 100,
                UrunAdeti = 50,
                UrunKategorisi = Kategoriler[1]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "Faber Castell 12'li Kırmızı Kalem",
                UrunAlisFiyati = 40,
                UrunSatisFiyati = 50,
                UrunAdeti = 100,
                UrunKategorisi = Kategoriler[2]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "4'lü Tahta Kalemi",
                UrunAlisFiyati = 25,
                UrunSatisFiyati = 30,
                UrunAdeti = 100,
                UrunKategorisi = Kategoriler[0]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "10'lu 50x70cm Fon Kartonu",
                UrunAlisFiyati = 20,
                UrunSatisFiyati = 25,
                UrunAdeti = 50,
                UrunKategorisi = Kategoriler[1]
            });

            Urunler.Add(new Urun()
            {
                UrunAdi = "Faber Castell 10'lu Parmak Boyası",
                UrunAlisFiyati = 40,
                UrunSatisFiyati = 50,
                UrunAdeti = 100,
                UrunKategorisi = Kategoriler[2]
            });
        }
    }
}
