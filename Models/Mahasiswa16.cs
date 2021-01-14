using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P6_1_0320190016.Models
{
    public class Mahasiswa16
    {
        [Key]
        [DisplayName("NIM")]
        [Required(ErrorMessage = "NIM Wajib Di-Isi!")]
        public string nim { get; set; }

        [Key]
        [DisplayName("Nama")]
        [Required(ErrorMessage = "Nama Wajib Di-Isi!")]
        public string nama { get; set; }

        [Key]
        [DisplayName("Alamat")]
        [Required(ErrorMessage = "Alamat Wajib Di-Isi!")]
        public string alamat { get; set; }

        [Key]
        [DisplayName("E-Mail")]
        [Required(ErrorMessage = "E-Mail Wajib Di-Isi!")]
        public string email { get; set; }

        [Key]
        [DisplayName("Tanggal Lahir")]
        [Required(ErrorMessage = "Tanggal lahir Wajib Di-Isi!")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime tgl_lahir { get; set; }
    }
}