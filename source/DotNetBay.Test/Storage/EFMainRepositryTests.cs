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
        public void Dispose()
        { }
        public IMainRepository CreateMainRepository()
        {
            return new EFMainRepository();
        }
    }
}
