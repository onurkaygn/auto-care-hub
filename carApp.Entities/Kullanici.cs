using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carApp.Entities
{
    public class Kullanici : IEntity
    {
        public int Id { get; set; }
        [StringLength(50)]

        [Display(Name = "Adı"), Required(ErrorMessage = "{0} Boş Bırakılamaz")]
        public string Adi { get; set; }
        [Display(Name = "Soyadı"), Required(ErrorMessage = "{0} Boş Bırakılamaz")]
        [StringLength(50)]

        public string Soyadi { get; set; }
        [StringLength(50)]

        public string Email { get; set; }
        [StringLength(20)]

        public string? Telefon { get; set; }
        [StringLength(50)]

        public string? KullaniciAdi { get; set; }
        [StringLength(50)]

        public string Sifre { get; set; }
        public bool AktifMi { get; set; }
        [Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
        public DateTime? EklenmeTarihi { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Rol seçimi zorunludur.")]
        public int RolId { get; set; }
        [Display(Name = "Kullanıcı Rolü"), Required(ErrorMessage = "{0} Boş Bırakılamaz")]

        public virtual Rol? Rol { get; set; }
    }
}
