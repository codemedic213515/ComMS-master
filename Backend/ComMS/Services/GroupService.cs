using ComMS.Models;

namespace ComMS.Services
{
    public class GroupService
    {
        private readonly ConstructionPortalDBContext _db;

        public GroupService(ConstructionPortalDBContext db)
        {
            _db = db;
        }

        public List<TM_グループ名マスタ_TM_GroupNameMaster> GetGroup()
        {
            var grp = _db.TM_グループ名マスタ_TM_GroupNameMaster.ToList();
            return grp;
        }


    }
}
