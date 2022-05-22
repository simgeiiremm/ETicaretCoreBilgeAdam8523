using AppCore.Records.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Ulke : RecordBase
    {
        [Required]
        [StringLength(105)]
        public string Adi { get; set; }
        public List<Sehir> Sehirler { get; set; }
        public List<KullaniciDetayi> KullaniciDetaylari { get; set; }
    }
}
