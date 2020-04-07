using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class TBoard : UserControl
    {
        public static int N = 8;
        public TCell[,] Cells = new TCell[N, N];
        public TPlayer WhitePlayer = new TPlayer();
        public TPlayer BlackPlayer = new TPlayer();
        public TBoard()
        {
            InitializeComponent();
            for (int y = 0; y < N; y++)
                for (int x = 0; x < N; x++)
                {
                    var cell = new TCell();
                    cell.Board = this;
                    cell.X = x;
                    cell.Y = y;
                    Cells[y, x] = cell;
                }
            Reset();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.ScaleTransform(CellWidth, CellHeight);
            var brush = new SolidBrush(ForeColor);
            for (int y=0; y<N; y++)
                for(int x=0; x<N; x++)
                {
                    var cell = Cells[y, x];
                    brush.Color = ForeColor;
                    if ((x + y) % 2 == 0)
                        brush.Color = BackColor;
                    var rc = new RectangleF(x, y, 1, 1);
                    e.Graphics.FillRectangle(brush, rc);
                }
           foreach(var piece in WhitePlayer.Pieces)
            {
                var rc = new RectangleF(piece.Cell.X, piece.Cell.Y, 1, 1);
                var image = piecesImages.Images[piece.ImageId];
                e.Graphics.DrawImage(image, rc);
            }             
        }

        public void Reset()
        {
            var player = WhitePlayer;
            for(int i=0; i<2; i++)
            {
                new TRook(player);
                new TKnight(player);
                new TBishop(player);
                new TQueen(player);
                new TKing(player);
                new TBishop(player);
                new TKnight(player);
                new TRook(player);
                for (int j = 0; j < N; j++)
                    new TPawn(player);
                for(int j = 0; j<player.Pieces.Count; j++)
                {
                    var x = j % N;
                    var y = j / N;
                    if (player == BlackPlayer)
                        y = N - 1 - y;
                    player.Pieces[j].Cell = Cells[y, x];
                }
                player = BlackPlayer;
            }
        }
        public float CellWidth
        {
            get { return Width / (float)N; }
        }
        public float CellHeight
        {
            get { return Height / (float)N; }
        }
    }
}
