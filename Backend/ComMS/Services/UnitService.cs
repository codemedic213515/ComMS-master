using ComMS.Models;

namespace ComMS.Services
{
    public class UnitService
    {
        private readonly ConstructionPortalDBContext _db;
        public UnitService(ConstructionPortalDBContext db)
        {

            _db = db;

        }

        public List<TM_単位マスタ_TM_UnitMaster> GetUnits()
        {
            var units = _db.TM_単位マスタ_TM_UnitMaster.ToList();
            return units;
        }
    }
}
