using ComMS.DTOs;
using ComMS.Models;

namespace ComMS.Services
{
    public class SelectSupplierService
    {
        readonly ConstructionPortalDBContext _db;
        public SelectSupplierService(ConstructionPortalDBContext db)
        {
            _db = db;
        }

        public List<VendorSelectDTO> getVendor(string f)
        {
            var vendors = new List<VendorSelectDTO>();
            vendors = _db.TM_仕入先マスタ_TM_VendorMaster.Where(e => e.ランク_Rank == f).Select(x => new VendorSelectDTO()
            {
                仕入先CD_SupplierCode = x.仕入先CD_SupplierCode,
                仕入先名_SupplierName = x.仕入先名_SupplierName,
                ランク_Rank = x.ランク_Rank
            }).ToList();

            return vendors;
        }
    }
}
