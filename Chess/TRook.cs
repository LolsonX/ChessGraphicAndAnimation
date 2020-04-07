using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class TRook : TPiece
    {
        public TRook(TPlayer player) : base(player)
        {
            ImageId = 10;
            Value = 5;
        }
    }
}
