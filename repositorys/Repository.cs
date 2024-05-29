using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4.repository
{
    // 상속받아서 JPA 처럼 사용하면 됨
    // 상속 후 내부 메소드는 추가 구현해야함
    internal interface Repository<I,T>
    {
        T Get(int id);
        void Insert(T item);
        void Update(I id, T item);
        void Delete(I id);
    }
}
