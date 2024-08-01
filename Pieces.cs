namespace Pieces
{
    class Piece
    {
        private string signature;
        private char colour;

        public string getSignature() { return signature; }
        protected void setSignature(string signature) { this.signature = signature; }
        public char getColour() { return colour; }
        protected void setColour(char colour) { this.colour = colour; }
    }

    class Pawn : Piece
    {
        public Pawn(char colour)
        {
            this.setSignature("P");
            this.setColour(colour);
        }
    }

    class Bishop : Piece
    {
        public Bishop(char colour)
        {
            this.setSignature("B");
            this.setColour(colour);
        }
    }

    class Knight : Piece
    {
        public Knight(char colour)
        {
            this.setSignature("K");
            this.setColour(colour);
        }
    }

    class Rook : Piece
    {
        public Rook(char colour)
        {
            this.setSignature("R");
            this.setColour(colour);
        }
    }

    class Queen : Piece
    {
        public Queen(char colour)
        {
            this.setSignature("Q");
            this.setColour(colour);
        }
    }

    class King : Piece
    {
        public King(char colour)
        {
            this.setSignature("X");
            this.setColour(colour);
        }
    }
}