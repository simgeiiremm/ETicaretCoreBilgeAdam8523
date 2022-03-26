using AppCore.Records.Bases;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    //[Table("ETicaretUrunler")] burada da tablo ismini değiştirebiliriz
    public class Urun :RecordBase
    {
        [Required] //string için yapılır null olmasını engeller
        [StringLength(200)]
        public string Adi { get; set; }

        [StringLength(500)]
        public string Aciklamasi { get; set; }
        public double BirimFiyati { get; set; }
        public int StokMiktari { get; set; }
        public DateTime? SonKullanmaTarihi { get; set; }
        public int KategoriId { get; set; } 
        public Kategori Kategori { get; set; } //1-M ilişkiden dolayı kategori kategori oluşturmak zorundayız
    }
}
