using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class TPawn : TPiece
    {
        public TPawn(TPlayer player) : base(player)
        {
            ImageId = 6;
            Value = 1;
        }
    }
}
