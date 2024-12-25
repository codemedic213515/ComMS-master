using ComMS.Models;

namespace ComMS.Services
{
    public class DepartmentService
    {
        private readonly ConstructionPortalDBContext _db;
        public DepartmentService(ConstructionPortalDBContext db)
        {

            _db = db;

        }

        public List<TC_部署データ_TC_DepartmentData> GetDepartments()
        {
            var departments = _db.TC_部署データ_TC_DepartmentData.ToList();
            return departments;
        }
    }
}
