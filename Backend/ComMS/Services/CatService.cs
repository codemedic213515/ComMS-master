using ComMS.DTOs;
using ComMS.Models;

namespace ComMS.Services
{
    public class CatService
    {
        readonly ConstructionPortalDBContext _db;
        public CatService(ConstructionPortalDBContext db)
        {
            _db = db;
        }

        public List<Category1SelectDTO> GetCategory1()
        {
            var catList = new List<Category1SelectDTO>();
            catList = _db.TM_分類1マスタ_Category1Master.Select(x => new Category1SelectDTO()
            {
                分類1_Category1 = x.分類1_Category1,
                分類名_CategoryName = x.分類名_CategoryName
            }).ToList();

            return catList;
        }

        public List<TM_分類2マスタ_Category2Master> GetCat2(int cat1)
        {
            var cat2List = new List<TM_分類2マスタ_Category2Master>();
            cat2List = _db.TM_分類2マスタ_Category2Master.Where(e=>e.分類1_Category1 == cat1).ToList();
            return cat2List;
        }

        public List<TM_分類3マスタ_Category3Master> GetCat3(int cat1, int cat2)
        {
            var cat3List = new List<TM_分類3マスタ_Category3Master>();
            cat3List = _db.TM_分類3マスタ_Category3Master.Where(e => e.分類1_Category1 == cat1 && e.分類2_Category2 == cat2).ToList();
            return cat3List;
        }

        public TM_素材マスタ_TM_MaterialMaster GetMat(int cat1, int cat2, int cat3)
        {
            var material = _db.TM_素材マスタ_TM_MaterialMaster.Where(e => e.分類1_Category1 == cat1 && e.分類2_Category2 == cat2 && e.分類3_Category3 == cat3).FirstOrDefault();
            return material;
        }
    }

}
