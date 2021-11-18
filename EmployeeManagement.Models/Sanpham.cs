using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Models
{
    public class Sanpham
    {
        [Key]
        public int SanphamId { get; set; }
        public string TenSP { get; set; }
        public double GiaSP { get; set; }
       /* public Size Size { get; set; }*/
        public int ColorId { get; set; }
       /* public int SizeId { get; set; }*/
        public Color Color { get; set; }
        public string PhotoPath { get; set; }

    }
    
}
