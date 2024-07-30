using Essentials;
using Pieces;

namespace Board
{
    class Board
    {
        class BoardSquare
        {
            private string name;
            private bool isTaken;

            public BoardSquare(string name)
            {
                this.name = name;
                isTaken = false;
            }

            public string getName() { return name; }
            public bool getAccesibility() { return isTaken; }
            public void setAccesibility(bool access) { isTaken = access; }
        }

        private List<BoardSquare> playField;

        public Board()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    playField.Add(new BoardSquare(Es.letters[i] + j));
                }
            }
        }
    }
}