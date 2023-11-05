using System.Collections.Generic;
using System.Text;

namespace RotationExcers
{
    internal class Rotative
    {
        public List<int> elements = new List<int>();

        public void Add(int element)
        {
            elements.Add(element);
        }
        public void RotLeft(int number) 
        { 
            for(int i = 0; i < number; i++)
            {
                Rotate();
            }
        }

        internal string PrintElements()
        {
            var result = new StringBuilder(string.Empty);
            elements.ForEach(i =>
            {
                result.Append($"{i} ");
            });
            
            return result.ToString();
        }

        private void Rotate()
        {
            var firstNum = elements.First();
            elements.RemoveAt(0);
            elements.Add(firstNum);
        }
    }
}
