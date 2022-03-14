using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendor1.Model;

namespace Vendor1.Repository
{
    public interface IVendorDetailRepo<T>
    {
        public IEnumerable<Vendor> GetAll();
        public IEnumerable<Vendor> GetVendor(int Id);
        public void PostStock(VendorStock vs);
    }
}
