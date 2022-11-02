using Asoeco.DataAccess.HomeData;
using Asoeco.Models;

namespace Asoeco.Services.HomeService
{
    public class HomeService : IHomeService
    {
        private IHomeDataAccess homeDataAccess;

        public HomeService() { 
            this.homeDataAccess = new HomeDataAccess();            
        }
        public HomeModel getHome()
        {
            return this.homeDataAccess.getHome();
        }
        public AssociatesModel getAssociates()
        {
            return this.homeDataAccess.getAssociates();
        }
    }
}
