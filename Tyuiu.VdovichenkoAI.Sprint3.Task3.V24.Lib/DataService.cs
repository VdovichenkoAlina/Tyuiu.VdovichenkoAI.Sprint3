using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VdovichenkoAI.Sprint3.Task3.V24.Lib
{
    public class DataService : ISprint3Task3V24
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            string result = value;
            foreach (char letter in value)
            {
                if (replaceable == 'g')
                {
                    result = result.Replace('g', '*');
                }
            }
            return result;
        }
    }
}
