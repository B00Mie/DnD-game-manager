using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Base
{
    public class InventoryItem
    {
        public Guid Id { get; set; } = new Guid();
        public int CharacterId { get; set; } = 0;
        public string Name { get; set; }
        public string Description { get; set; } = "";
        public InventoryItem(string name) 
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
