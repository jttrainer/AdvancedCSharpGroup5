using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forever_Home_Finder.Models
{
    public class PetUnitOfWork
    {
        private ForeverContext context { get; set; }
        public PetUnitOfWork(ForeverContext ctx) => context = ctx;

        private Repository<PetType> petTypeData;
        public Repository<PetType> PetTypes
        {
            get
            {
                if (petTypeData == null)
                    petTypeData = new Repository<PetType>(context);
                return petTypeData;
            }
        }

        private Repository<Pet> petData;
        public Repository<Pet> Pets
        {
            get
            {
                if (petData == null)
                    petData = new Repository<Pet>(context);
                return petData;
            }
        }

        private Repository<AddInfo> addInfoData;
        public Repository<AddInfo> AddInfo
        {
            get
            {
                if (addInfoData == null)
                    addInfoData = new Repository<AddInfo>(context);
                return addInfoData;
            }
        }

        private Repository<User> userData;
        public Repository<User> Users
        {
            get
            {
                if (userData == null)
                    userData = new Repository<User>(context);
                return userData;
            }
        }

        public void Save() => context.SaveChanges();
    }
}
