namespace ComMS.DTOs
{
    public class ClientSelectDTO
    {
        public int? 得意先CD_CustomerCode { get; set; }
        public string 得意先名_CustomerName { get; set; }
    }

    public class VendorSelectDTO
    {
        public int? 仕入先CD_SupplierCode { get; set; }
        public string 仕入先名_SupplierName { get; set; }
        public string ランク_Rank { get; set; }

    }
}
