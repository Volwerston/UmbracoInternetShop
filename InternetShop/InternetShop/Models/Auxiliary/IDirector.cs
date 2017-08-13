using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Models.Auxiliary
{
    interface IDirector<TResult, TContext>
    {
        List<IBuilder<TResult, TContext>> Builders { get; set; }

        void Act();
    }
}
