using ComMS.Models;

namespace ComMS.Services
{
    public class WorkTypeService
    {
        private readonly ConstructionPortalDBContext _db;

        public WorkTypeService(ConstructionPortalDBContext db)
        {
            _db = db;
        }

        public List <TM_工種マスタ_TM_ConstructionTypeMaster> GetWorkType()
        {
            var wT = _db.TM_工種マスタ_TM_ConstructionTypeMaster.ToList();
            return wT;
        }

    }
}
