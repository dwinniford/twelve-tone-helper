namespace TwelveToneHelper
{
    public class ToneRow
    {
        public ToneRow()
        {
            row = new List<int>(){1,2,3,4,5,6};
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
        List<int> row;
    }
}