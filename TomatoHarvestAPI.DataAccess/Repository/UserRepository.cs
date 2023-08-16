using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomatoHarvestAPI.DataAccess.Data;
using TomatoHarvestAPI.DataAccess.Repository.IRepository;
using TomatoHarvestAPI.Models;

namespace TomatoHarvestAPI.DataAccess.Repository
{
    public class UseraRepository : Repository<TbUser>, IUserRepository
    {
        #region dependency injection
        private ApplicationDbContext _db;
        public UseraRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        #endregion

        #region Update
        public void Update(TbUser obj)
        {
            _db.TbUsers.Update(obj);
        }
        #endregion

        #region AuthorizeUser Function:
        public TbUser AuthorizeUser(string userName, string password)
        {
            try
            {
                // Perform user authorization logic based on your business requirements
                TbUser user = _db.TbUsers.FirstOrDefault(u => u.UserName == userName && u.Password == password);

                if (user != null)
                {
                    // Create a new instance of TbUser with only the necessary data to return
                    return new TbUser()
                    {
                        UserName = user.UserName,
                        Email = user.Email
                    };
                }

                return null; // Return null if user is not found
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during the authorization process
                Console.WriteLine("An error occurred while authorizing the user: " + ex.Message);
                return null;
            }
        }
        #endregion

    }
}
