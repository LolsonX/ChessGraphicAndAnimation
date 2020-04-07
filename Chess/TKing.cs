using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class TKing : TPiece
    {
        public TKing(TPlayer player) : base(player)
        {
            ImageId = 2;
            Value = 1000;
        }
    }
}
