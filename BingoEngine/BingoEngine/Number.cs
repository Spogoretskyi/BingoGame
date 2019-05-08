
namespace BingoEngine
{
    class Number
    {
        private int _num;
        private int _stringNum;
        private int _columnNum;
        private bool _isSelected;
        public bool IsSelected { get; set; } = false;
        public int Num => _num;
        public Number(int num, int str, int column)
        {
            _num = num;
            _stringNum = str;
            _columnNum = column;
        }
    }
}
