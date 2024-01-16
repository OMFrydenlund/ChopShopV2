using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChopShopV2
{
    public class Car
    {
        public bool IsInShop;
        public bool EngineHealthy;
        public bool BreaksHealthy;
        public Car(bool isInShop, bool engineHealthy, bool breaksHealthy)
        {
            IsInShop = isInShop;
            EngineHealthy = engineHealthy;
            BreaksHealthy = breaksHealthy;
        }
    }


}
