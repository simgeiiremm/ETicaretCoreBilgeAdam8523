using DataAccess.ENums;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class KullaniciDetayi
    {
        //id özelliği olmaması gerektiği için kullanicidetayini recordbase'den türetemeyiz!
        [Key]
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
        [Required]
        [StringLength(200)]
        public string EPosta { get; set; }
        [Required]
        public string Adres { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public int UlkeId { get; set; }
        public Ulke Ulke { get; set; }
        public int SehirId { get; set; }
        public Sehir Sehir { get; set; }

    }
}
