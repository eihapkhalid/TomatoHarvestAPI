using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomatoHarvestAPI.Models;

namespace TomatoHarvestAPI.DataAccess.Repository.IRepository
{
    public interface IUserRepository : IRepository<TbUser>
    {
        void Update(TbUser obj);
    }
}
