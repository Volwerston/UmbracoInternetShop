using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Models.Auxiliary
{
    interface IBuilder<TResult, TContext>
    {
        TContext Context { get; set; }
        TResult Build();
    }
}
