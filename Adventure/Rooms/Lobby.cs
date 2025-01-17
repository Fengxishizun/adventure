using Adventure.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public class Lobby : BaseRoom
    {
        public Lobby()
        {
            AddItems(new Rock());
        }
        public override string Description => $"Dim lobby with {String.Join(",", items)}";

        public override string Name => "Lobby";
    }
}
