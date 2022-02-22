using System;
using System.Collections.Generic;
namespace TwelveToneHelper
{
    public class ToneRow
    {
        public ToneRow()
        {
            row = GenerateRow();
        }
        public string PrintRow() 
        {
            string printedRow = "";
            row.ForEach(delegate(int tone)
            {
                printedRow += $" {tone},";
            });
            return printedRow;
        }
        public int GetLength()
        {
            return row.Count;
        }
        private List<int> GenerateRow()
        {
            List<int> baseRow = new List<int> 
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            List<int> newRow = new List<int>();
            var random = new Random();
            while (baseRow.Count > 0)
            {
                int index = random.Next(baseRow.Count);
                newRow.Add(baseRow[index]);
                baseRow.RemoveAt(index);

            }
            return newRow;
        }

        List<int> row;
    }
}