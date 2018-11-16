using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetBay.Interfaces;
using DotNetBay.Data.EF;

namespace DotNetBay.Test.Storage
{
    class EFMainRepositryTests : MainRepositoryTestBase
    {
        protected override IRepositoryFactory CreateFactory()
        {
            return new EFMainRepositoryFactory();
        }
    }

    public class EFMainRepositoryFactory : IRepositoryFactory
    {
        EFMainRepository instance;
        public void Dispose()
        {
            instance.Database.Delete();
        }
        public IMainRepository CreateMainRepository()
        {
            if(instance == null) instance = new EFMainRepository();
            return instance;
        }
    }
}
