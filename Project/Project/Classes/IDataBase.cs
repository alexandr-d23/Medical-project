using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public interface IDataBase
    {
        void add(AbstractInformation information);
        void addAll(ICollection<AbstractInformation> collection);
    }
}
