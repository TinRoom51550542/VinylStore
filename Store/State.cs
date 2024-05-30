using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    abstract class State
    {

        public abstract void HandleAddToCart();
        public abstract void HandleWeighProducts();
        public abstract void HandleProcessPayment();
    }
}
