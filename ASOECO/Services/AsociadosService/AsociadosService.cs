using Asoeco.DataAccess.AsociadosData;
using Asoeco.Models;
using Asoeco.Services.AsociadosService;

namespace Asoeco.Services.AsociadosService
{
    public class AsociadosService : IAsociadosService
    {
        private IAsociadosDataAccess asociadosDataAccess;

        public AsociadosService()
        {
            this.asociadosDataAccess = new AsociadosDataAccess();
        }
        public AssociatesModel getAssociates()
        {
            return this.asociadosDataAccess.getAssociates();
        }
    }
}
