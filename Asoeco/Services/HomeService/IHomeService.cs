using Asoeco.Models;

namespace Asoeco.Services.HomeService
{
    public interface IHomeService
    {
        public HomeModel getHome();
        public AssociatesModel getAssociates();
    }
}
