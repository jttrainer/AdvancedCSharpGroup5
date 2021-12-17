using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forever_Home_Finder.Models
{
    public interface IPetUnitOfWork
    {
        Repository<PetType> PetTypes { get; }
        Repository<Pet> Pets { get; }
        Repository<User> Users { get; }
        Repository<AddInfo> AddInfo { get; }

        void Save();
    }
}
