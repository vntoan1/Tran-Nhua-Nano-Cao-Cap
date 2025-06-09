using Microsoft.Extensions.Options;

namespace TranNhua.Models
{
    public class HomeViewModel
    {
        public List<TranNhuaDep> TranNhuaList { get; set; } = new();
        public List<OpTuong> OpTuongList { get; set; } = new();
        public List<VachNgan> VachNganList { get; set; } = new();
        public List<TranTha> TranThaList { get; set; } = new();
    }

    public class TranNhuaItem
    {
        public string noidung { get; set; } = string.Empty;
        public string chitietsanpham { get; set; } = string.Empty;
        public string thongso { get; set; } = string.Empty;
        public int soluong { get; set; }
        public decimal dongia { get; set; }
    }
}
