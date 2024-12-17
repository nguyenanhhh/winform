using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietTre_KLTN
{
    public class HoaDoncs
    {
        // Properties
        public string ID_HD { get; set; }       // Invoice ID
        public string ID_KH { get; set; }       // Customer ID
        public string ID_NV { get; set; }       // Employee ID
        public string ID_DH { get; set; }       // Order ID
        public string MaHD { get; set; }        // Invoice Code
        public string GhiChu { get; set; }      // Notes
        public string PTTT { get; set; }        // Payment Method
        public DateTime NgayLapHD { get; set; } // Invoice Date

        // Default Constructor
        public HoaDoncs()
        {
        }

        // Parameterized Constructor
        public HoaDoncs(string id_hd, string id_kh, string id_nv, string id_dh,
                       string maHD, string ghiChu, string pttt, DateTime ngayLapHD)
        {
            ID_HD = id_hd;
            ID_KH = id_kh;
            ID_NV = id_nv;
            ID_DH = id_dh;
            MaHD = maHD;
            GhiChu = ghiChu;
            PTTT = pttt;
            NgayLapHD = ngayLapHD;
        }
    }
}
