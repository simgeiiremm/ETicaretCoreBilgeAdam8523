using AppCore.Records.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Business.Models
{ //string dışında diğer veri tipleri zorunlu olmalı
    public class UrunModel : RecordBase
    {
        //Fluent Validation 
        #region Entity
        [Required(ErrorMessage ="{0} zorunludur!")] //string için yapılır null olmasını engeller
        [MinLength(2, ErrorMessage ="{0} minimum {1} karakter olmalıdır!")]
        [MaxLength(200, ErrorMessage = "{0} maksimum {1} karakter olmalıdır!")]
        [DisplayName("Adı")]
        public string Adi { get; set; }

        [StringLength(500, ErrorMessage ="{0} maksimum {1} karakter olmalıdır!")]
        [DisplayName("Açıklaması")]
        public string Aciklamasi { get; set; }

        [DisplayName("Birim Fiyatı")]
        [Required(ErrorMessage = "{0} zorunludur!")]
        [Range(0, double.MaxValue, ErrorMessage = "{0} {1} ile {2} arasında olmalıdır!")]
        public double? BirimFiyati { get; set; }
        
        [DisplayName("Stok Miktarı")]
        [Required(ErrorMessage = "{0} zorunludur!")]
        [Range(0,1000000, ErrorMessage ="{0} {1} ile {2} arasında olmalıdır!")]
        public int? StokMiktari { get; set; }

        [DisplayName("Son Kullanma Tarihi")]
        public DateTime? SonKullanmaTarihi { get; set; }

        [DisplayName("Kategori")]
        [Required(ErrorMessage = "{0} zorunludur!")]
        public int? KategoriId { get; set; }
        #endregion

        #region Sayfanın İhtiyacı
        [DisplayName("Birim Fiyatı")]
        public string BirimFiyatiDisplay { get; set; }

        [DisplayName("Son Kullanma Tarihi")]
        public string SonKullanmaTarihiDisplay { get; set; }

        [DisplayName("Kategori")]
        public string KategoriAdiDisplay { get; set; }

        #endregion

    }
}
