using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4.repository
{
    internal interface Repository<I,T>
    {
        T Get(int id);
        void Insert(T item);
        void Update(I id, T item);
        void Delete(I id);
    }
}
