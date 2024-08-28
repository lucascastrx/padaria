using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria
{
    internal interface IRepository<T,D>
    {
        D Create(D Data);
        D Read(T Id);
        D Update(T Id, D data);
        void Delete(T Id);

    }
}
