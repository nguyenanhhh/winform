using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietTre_KLTN
{
    public class DonHang
    {
        // Auto-implemented properties
        public string ID_DH { get; set; }   // ID of DonHang (nvarchar(11))
        public string ID_KH { get; set; }   // ID of Customer
        public string ID_NV { get; set; }   // ID of Employee
        public string ID_GH { get; set; }   // ID of Shipping
        public string MoTa { get; set; }    // Description
        public DateTime NgayDH { get; set; } // Order Date

        // Default Constructor
        public DonHang() { }

        // Parameterized Constructor
        public DonHang(string id_DH, string id_KH, string id_NV, string id_GH, string moTa, DateTime ngayDH)
        {
            ID_DH = id_DH;
            ID_KH = id_KH;
            ID_NV = id_NV;
            ID_GH = id_GH;
            MoTa = moTa;
            NgayDH = ngayDH;
        }

        // ToString Method for easy display
        public override string ToString()
        {
            return $"ID_DH: {ID_DH}, ID_KH: {ID_KH}, ID_NV: {ID_NV}, ID_GH: {ID_GH}, MoTa: {MoTa}, NgayDH: {NgayDH.ToShortDateString()}";
        }
    }
}
