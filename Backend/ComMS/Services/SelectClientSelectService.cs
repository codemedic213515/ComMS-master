using ComMS.DTOs;
using ComMS.Models;

namespace ComMS.Services
{
    public class SelectClientSelectService
    {
        readonly ConstructionPortalDBContext _db;
        public SelectClientSelectService(ConstructionPortalDBContext db)
        {

            _db = db;
        }

        public List<ClientSelectDTO> getClient()
        {
            var clientList = new List<ClientSelectDTO>();
            clientList = _db.TM_得意先マスタ_CustomerMaster.Select(x => new ClientSelectDTO()
            {
                得意先CD_CustomerCode = x.得意先CD_CustomerCode,
                得意先名_CustomerName = x.得意先名_CustomerName
            }).ToList();

            return clientList;
        }
    }
}
