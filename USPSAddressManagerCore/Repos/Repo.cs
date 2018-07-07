using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USPSAddressManagerCore.Repos
{
    public interface Repo<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> Get();
        IEnumerable<T> Get(string query);
        void Add(T item);
        void Update(T item);
        void Delete(T item);
    }
}
