using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Team4.repository;
using Team4.models;

namespace Team4
{
    // UserRepository임 다음과 같이 상속받아서 사용하면 됨.
    public class UserRepository : Repository<long,User>
    {
        const string fileName = "./user.csv";
        StreamReader StreamReader = new StreamReader(fileName);
        StreamWriter StreamWriter = new StreamWriter(fileName);

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(User item)
        {
            throw new NotImplementedException();
        }

        public void Update(long id, User item)
        {
            throw new NotImplementedException();
        }
    }
}
