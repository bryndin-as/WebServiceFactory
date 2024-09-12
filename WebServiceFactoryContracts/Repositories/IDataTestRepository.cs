using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceFactoryContracts.Repositories
{
    public interface IDataTestRepository
    {
        public Task SetDataTest(int count);
    }
}
