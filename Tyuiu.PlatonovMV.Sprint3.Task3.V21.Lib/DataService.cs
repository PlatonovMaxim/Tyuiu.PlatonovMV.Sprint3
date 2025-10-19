using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PlatonovMV.Sprint3.Task3.V21.Lib
{
    public class DataService : ISprint3Task3V21
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string result = "";

            foreach (char c in value)
            {
                if (char.IsDigit(c))
                {
                    result += item;
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }
    }
}