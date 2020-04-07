namespace Chess
{
    public abstract class TPiece
    {
        public int ImageId;
        public int Value;
        public TPlayer Player;
        public TCell Cell;

        public TPiece(TPlayer player)
        {
            Player = player;
            Player.Pieces.Add(this);
        }
    }
}