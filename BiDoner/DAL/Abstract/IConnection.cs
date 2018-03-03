using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiDoner.DAL.Abstract
{
    public interface IConnection
    {
        IDbConnection GetConnection { get; }
    }
}
