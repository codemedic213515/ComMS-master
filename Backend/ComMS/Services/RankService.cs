using ComMS.Models;

namespace ComMS.Services
{
    public class RankService
    {
        private readonly ConstructionPortalDBContext _db;
        public RankService(ConstructionPortalDBContext db)
        {
            _db = db;
        }

        public  List<TM_ランクマスタ_TM_RankMaster> GetAllRanks()
        {
            var ranks = _db.TM_ランクマスタ_TM_RankMaster.ToList();
            return ranks;
        }

    }
}
