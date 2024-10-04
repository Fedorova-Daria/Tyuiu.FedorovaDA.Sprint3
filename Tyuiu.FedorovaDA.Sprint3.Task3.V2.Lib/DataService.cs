using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FedorovaDA.Sprint3.Task3.V2.Lib
{
    public class DataService : ISprint3Task3V2
    {
        public int GetMaxCharCount(string value, char item)
        {
            int count = 0;

            foreach (char ch in value)
            {
                if (ch == item)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
