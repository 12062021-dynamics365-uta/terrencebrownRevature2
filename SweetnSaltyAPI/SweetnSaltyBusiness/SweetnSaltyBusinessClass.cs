using SweetnSaltyDbAccess;
using SweetnSaltyModels;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SweetnSaltyBusiness
{
    public class SweetnSaltyBusinessClass : ISweetnSaltyBusinessClass
    {
        private readonly ISweetnSaltyDbAccessClass _dbaAcess;
        private readonly IMapper mapper;

        public SweetnSaltyBusinessClass(ISweetnSaltyDbAccessClass Dbaccess, IMapper mapper)//you need a reference to the DbAccess Layer 
        {
            this.mapper = mapper;
            this._dbaAcess = Dbaccess;
        }
        public async Task<Flavor> PostFlavor(string flavor)
        {
            SqlDataReader dr = await this._dbaAcess.PostFlavor(flavor);
            if (dr.Read())
            {
                Flavor p = this.mapper.EntityToFlavor(dr);
                return p;
            }
            else return null;
        }
    }
}
