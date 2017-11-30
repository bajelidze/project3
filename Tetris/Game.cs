using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Game
    {
        public bool saveExists = false;
        int score = 0;
        public int[,] nextPiece = new int[4, 4];
        public int[,] board = new int[21, 10];
        public int color;
        public bool pieceExists;

        static Random rnd = new Random();
        public int roll;

        // These is the list of all picies with all possible
        // rotations, one of these are chosen at random
        int[,,] pieces = new int[19, 4, 4] {
            {                                // | piece
                { 1, 1, 1, 1 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
            },
            {
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 },
            },
            {                       // |- piece
                { 2, 2, 2, 0 },
                { 0, 2, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
            },
            {
                { 0, 0, 2, 0 },
                { 0, 2, 2, 0 },
                { 0, 0, 2, 0 },
                { 0, 0, 0, 0 },
            },
            {
                { 0, 2, 0, 0 },
                { 2, 2, 2, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
            },
            {
                { 0, 2, 0, 0 },
                { 0, 2, 2, 0 },
                { 0, 2, 0, 0 },
                { 0, 0, 0, 0 },
            },
            {                       // |_ piece
                { 3, 3, 3, 0 },
                { 3, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
            },
            {
                { 0, 3, 3, 0 },
                { 0, 0, 3, 0 },
                { 0, 0, 3, 0 },
                { 0, 0, 0, 0 },
            },
            {
                { 0, 0, 3, 0 },
                { 3, 3, 3, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
            },
            {
                { 0, 3, 0, 0 },
                { 0, 3, 0, 0 },
                { 0, 3, 3, 0 },
                { 0, 0, 0, 0 },
            },
            {                   // _| piece
                { 4, 4, 4, 0 },
                { 0, 0, 4, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
            },
            {
                { 0, 0, 4, 0 },
                { 0, 0, 4, 0 },
                { 0, 4, 4, 0 },
                { 0, 0, 0, 0 },
            },
            {
                { 4, 0, 0, 0 },
                { 4, 4, 4, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
            },
            {
                { 0, 4, 4, 0 },
                { 0, 4, 0, 0 },
                { 0, 4, 0, 0 },
                { 0, 0, 0, 0 },
            },
            {                   // Z piece
                { 0, 0, 5, 0 },
                { 0, 5, 5, 0 },
                { 0, 5, 0, 0 },
                { 0, 0, 0, 0 },
            },
            {
                { 5, 5, 0, 0 },
                { 0, 5, 5, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
            },
            {                   // Z piece reversed
                { 0, 6, 0, 0 },
                { 0, 6, 6, 0 },
                { 0, 0, 6, 0 },
                { 0, 0, 0, 0 },
            },
            {
                { 0, 6, 6, 0 },
                { 6, 6, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
            },
            {                   // square piece
                { 0, 7, 7, 0 },
                { 0, 7, 7, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
            },
        };

        public Game()
        {

        }

        // sets all elements in field array to 0
        private void clear()
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 21; j++)
                {
                    board[i, j] = 0;
                }
            }
        }

        // renders the field
        public void rndNextPiece()
        {
            roll = rnd.Next(0, 19); // random number from 0 to 18 (including)
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    nextPiece[i, j] = 0;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    nextPiece[i, j] = pieces[roll, i, j];
                }
            }
        }

        public void AddNewPiece()
        {
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if(nextPiece[i, j] != 0)
                    {
                        color = nextPiece[i, j];
                        break;
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if(nextPiece[i, j] != 0)
                    {
                        board[i, j + 3] = 8;
                    }
                }
            }
            pieceExists = true;
        }
    }
}
