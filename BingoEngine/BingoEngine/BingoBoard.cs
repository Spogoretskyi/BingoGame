using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoEngine
{
    public class BingoBoard
    {
        private Number[,] _board;
        private int[,] _getBoard;
        private int[] _verticalCounter;
        private int[] _horizontalCounter;
        private int _leftDiagonalCounter;
        private int _rightDiagonalCounter;
        
        public BingoBoard(int min, int max, int gridSizeX, int gridSizeY)
        {
            _board = new Number[gridSizeX, gridSizeY];
            _getBoard = new int[gridSizeX, gridSizeY];

            UniqueRandomNumbers urn = new UniqueRandomNumbers();
            var numbers = urn.GetListUniqueRandomNumbers(_board.GetLength(0) * _board.GetLength(1), min, max);
            int index = 0;

            for (int i = 0; i < _board.GetLength(0); i++)
            {
                for (int j = 0; j < _board.GetLength(1); j++)
                {
                    _board[i, j] = new Number(numbers.ElementAtOrDefault(index), i, j);
                    _getBoard[i, j] = numbers.ElementAtOrDefault(index);
                    index++;
                }
            }
        }

        public int[,] GetBingoBoardNumbers()
        {
            return _getBoard;
        }

        public bool CheckForConcurrence(int number, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int i = 0; i < _board.GetLength(0); i++)
            {
                for (int j = 0; j < _board.GetLength(1); j++)
                {
                    if (_board[i, j].Num == number)
                    {
                        _board[i, j].IsSelected = true;
                        x = i;
                        y = j;

                        return true;
                    }
                }
            }
            return false;
        }

        public bool CheckHorizontal(out int index)
        {
            index = 0;
            for (int i = 0; i < _horizontalCounter.Length; i++)
            {
                if (_horizontalCounter[i] == _horizontalCounter.Length)
                {
                    index = i;
                    return true;
                }
            }
            return false;
        }

        public bool CheckVertical(out int index)
        {
            index = 0;
            for (int i = 0; i < _verticalCounter.Length; i++)
            {
                if (_verticalCounter[i] == _verticalCounter.Length)
                {
                    index = i;
                    return true;
                }
            }
            return false;
        }

        public bool CheckLeftDiagonal()
        {
                if (_leftDiagonalCounter == _board.GetLength(0))
                    return true;
            return false;
        }

        public bool CheckRightDiagonal()
        {
                if (_rightDiagonalCounter == _board.GetLength(0))
                    return true;
            return false;
        }

        public void CheckLines()
        {
            _leftDiagonalCounter = 0;
            _rightDiagonalCounter = 0;
            _horizontalCounter = new int[_board.GetLength(0)];
            _verticalCounter = new int[_board.GetLength(1)];

            int rightDiagonal = _board.GetLength(1) - 1;
            for (int i = 0; i < _board.GetLength(0); i++)
            {
                for (int j = 0; j < _board.GetLength(1); j++)
                {
                    if (_board[i, j].IsSelected == true)
                    {
                        _horizontalCounter[i]++;
                        _verticalCounter[j]++;

                        if (i == j)
                            _leftDiagonalCounter++;

                        if (j == rightDiagonal)
                            _rightDiagonalCounter++;
                    }
                }
                rightDiagonal--;
            }
        }
    }
}
