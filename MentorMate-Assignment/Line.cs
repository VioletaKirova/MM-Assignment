namespace MentorMate_Assignment
{
    public abstract class Line : ILine
    {
        protected char Dash = '-';

        protected char Star = '*';

        public Line(int inputNumber, int index, int lenght)
        {
            this.InputNumber = inputNumber;
            this.Index = index;
            this.Length = lenght;
        }

        public int InputNumber { get; set; }

        public int Index { get; set; }

        public int Length { get; set; }

        public string Half { get; set; }

        public string GenerateString(char symbol, int count)
        {
            return new string(symbol, count);
        }

        public string Draw()
        {
            return $"{this.Half}{this.Half}";
        }

        public abstract void SetHalf();
    }
}
