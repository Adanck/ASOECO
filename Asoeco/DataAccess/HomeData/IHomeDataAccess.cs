using Asoeco.Models;

namespace Asoeco.DataAccess.HomeData
{
    public interface IHomeDataAccess
    {
        public HomeModel getHome();
        public AssociatesModel getAssociates();
    }
}
