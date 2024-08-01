using System.Collections.Generic;
using Essentials;
using Pieces;

namespace PlayField
{
    class Board
    {
        class BoardSquare
        {
            private string marking;
            private Piece piece;

            public BoardSquare(string marking, char colour, string piece = null)
            {
                this.marking = marking;
                switch (piece)
                {
                    case "Pawn":
                        this.piece = new Pawn(colour);
                        break;
                    case "Bishop":
                        this.piece = new Bishop(colour);
                        break;
                    case "Knight":
                        this.piece = new Knight(colour);
                        break;
                    case "Rook":
                        this.piece = new Rook(colour);
                        break;
                    case "Queen":
                        this.piece = new Queen(colour);
                        break;
                    case "King":
                        this.piece = new King(colour);
                        break;
                }
            }

            public string getMarking() { return marking; }
            public bool isFree() { return piece == null; }
            public void draw()
            {
                if (this.isFree())
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("x ");
                }
                else
                {
                    switch (piece.getColour())
                    {
                        case 'w':
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 'b':
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                    }
                    Console.Write(piece.getSignature() + " ");
                }
            }
        }

        private List<BoardSquare> Squares;

        public Board()
        {
            Squares = new List<BoardSquare>();

            char colour = 'b';
            for (int i = 8; i > 0; i--)
            {
                if (i < 4)
                {
                    colour = 'w';
                }
                if (i == 8 || i == 1)
                {
                    Squares.Add(new BoardSquare(Es.letters[0] + i, colour, "Rook"));
                    Squares.Add(new BoardSquare(Es.letters[1] + i, colour, "Knight"));
                    Squares.Add(new BoardSquare(Es.letters[2] + i, colour, "Bishop"));
                    Squares.Add(new BoardSquare(Es.letters[3] + i, colour, "Queen"));
                    Squares.Add(new BoardSquare(Es.letters[4] + i, colour, "King"));
                    Squares.Add(new BoardSquare(Es.letters[5] + i, colour, "Bishop"));
                    Squares.Add(new BoardSquare(Es.letters[6] + i, colour, "Knight"));
                    Squares.Add(new BoardSquare(Es.letters[7] + i, colour, "Rook"));
                }
                else if (i == 7 || i == 2)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Squares.Add(new BoardSquare(Es.letters[j] + i, colour, "Pawn"));
                    }
                }
                else
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Squares.Add(new BoardSquare(Es.letters[j] + i, 'w'));
                    }
                }
            }
        }

        public void draw()
        {
            for (int i = 0; i < Squares.Count; i++)
            {
                Squares[i].draw();
                if ((i + 1) % 8 == 0)
                {
                    Console.Write("\n");
                }
            }
        }
    }
}