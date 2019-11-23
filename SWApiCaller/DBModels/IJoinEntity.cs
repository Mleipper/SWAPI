using System;
using System.Collections.Generic;
using System.Text;

namespace SWApiCaller.DBModels
{
    public interface IJoinEntity<TEntity>
    {
        TEntity Navigation { get; set; }
    }
}
