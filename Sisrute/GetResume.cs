using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisrute
{
    public class GetResume
    {
        /// <summary>
        /// nik, nomor induk kependudukan
        /// </summary>
         string nik { get;  set; }
        /// <summary>
        /// Tanggal masuk rs mulai tanggal, format yyyy-mm-dd"
        /// </summary>
        public string tgl_awal_masuk { get; set; }
        /// <summary>
        /// Tanggal masuk rs sampai tanggal, format yyyy-mm-dd"
        /// </summary>
        public string tgl_akhir_masuk { get; set; }
    }

    public class RsPerujuk
    {
        public string kode_rs { get; set; }
        public string nama_rs { get; set; }
        public string alamat_rs { get; set; }
        public string no_telp_rs { get; set; }
        public string email_rs { get; set; }
    }

    public class DiagnosaGetResume
    {
        public string kode_jenis_diagnosa { get; set; }
        public string nama_jenis_diagnosa { get; set; }
        public string kode_icd10 { get; set; }
        public string keterangan { get; set; }
    }

    public class TindakanGetResume
    {
        public string kode_jenis_tindakan { get; set; }
        public string nama_jenis_tindakan { get; set; }
        public string kode_icd9 { get; set; }
        public string keterangan { get; set; }
    }

    public class Datum
    {
        public RsPerujuk rs_perujuk { get; set; }
        public Pasien pasien { get; set; }
        public Medis medis { get; set; }
        public DiagnosaGetResume[] diagnosa { get; set; }
        public TindakanGetResume[] tindakan { get; set; }
        public object[] obat { get; set; }
        public object[] gambar { get; set; }
    }

    public class GetResumeResponse
    {
        public Datum[] data { get; set; }
        public string message { get; set; }
    }
}
