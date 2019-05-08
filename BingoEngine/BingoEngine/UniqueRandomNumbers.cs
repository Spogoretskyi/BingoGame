using System.Collections.Generic;

namespace BingoEngine
{
    class UniqueRandomNumbers
    {
       List<int> uniqueNambers;
        public List<int> GetListUniqueRandomNumbers(int lenght, int min, int max)
        {
            uniqueNambers = new List<int>();

            while (uniqueNambers.Count != lenght)
            {
                var number = RandomNumber.GetRandomNumber(min, max);
                if (!uniqueNambers.Contains(number))
                    uniqueNambers.Add(number);
            }
            return uniqueNambers;
        }
    }
}
