using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class TKnight : TPiece
    {
        public TKnight(TPlayer player) : base(player)
        {
            ImageId = 4;
            Value = 3;
        }
    }
}
