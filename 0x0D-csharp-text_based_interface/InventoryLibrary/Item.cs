using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryLibrary
{
    class Item : BaseClass
    {
        public string name {get; set;} = " ";
        public string description {get; set;} = null;
        public float? price {get; set;} = null;
        public string[] tags {get; set;} = null;
    }
}
