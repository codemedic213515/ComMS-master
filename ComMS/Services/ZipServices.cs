using ComMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ComMS.Services
{
    public class ZipServices
    {
        readonly ConstructionPortalDBContext _db;
        public ZipServices(ConstructionPortalDBContext db)
        {
            _db = db;
        }

        public List<TC_ZIP> GetZIPs()
        {
            var zips = new List<TC_ZIP>();
            zips = _db.TC_ZIP.Take(300).ToList();
            return zips;
        }

        public string GetAddressFromZip(string zip) 
        {
            var address = _db.TC_ZIP.FirstOrDefault(e=>e.ZIP == zip);
            if (address == null) { }
            var realAddress = address.TodoufukenCD + " " + address.Todoufuken + " " + address.ShikuCD + " " + address.Shiku + " " + address.Cyouson;
            return realAddress;
        }
    }
}
