using System.Collections.Generic;
namespace Storage
    
{
    public interface IDataBase
    {
        public List<Models.Store> getProductFromDB(List<Models.Store> sl);

        

        public void insertDataIntoDB();

    }
}
