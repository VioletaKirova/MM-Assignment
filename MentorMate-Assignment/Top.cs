namespace MentorMate_Assignment
{
    public class Top : Line, ITop
    {
        public Top(int inputNumber, int index, int lenght, int starsIncrement)
            : base(inputNumber, index, lenght)
        {
            this.StarsIncrement = starsIncrement;
        }

        public int StarsIncrement { get; set; }

        public string Stars { get; set; }

        public string MiddleDashes { get; set; }

        public string BorderDashes { get; set; }

        public void SetStars()
        {
            int count = this.InputNumber + this.StarsIncrement;
            this.Stars = this.GenerateString(this.Star, count);
        }

        public void SetMiddleDashes()
        {
            int count =  this.Length - (this.BorderDashes.Length * 2 + this.Stars.Length * 2);
            this.MiddleDashes = this.GenerateString(this.Dash, count);
        }

        public void SetBorderDashes()
        {
            int count = this.InputNumber - this.Index;
            this.BorderDashes = this.GenerateString(this.Dash, count);
        }

        public override void SetHalf()
        {
            this.Half = $"{this.BorderDashes}{this.Stars}{this.MiddleDashes}{this.Stars}{this.BorderDashes}";
        }
    }
}
