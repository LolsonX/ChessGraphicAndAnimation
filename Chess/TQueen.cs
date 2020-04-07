using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class TQueen : TPiece
    {
        public TQueen(TPlayer player) : base(player)
        {
            ImageId = 8;
            Value = 10;
        }
    }
}
