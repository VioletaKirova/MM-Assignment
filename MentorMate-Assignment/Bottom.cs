namespace MentorMate_Assignment
{
    public class Bottom : Line, IBottom
    {
        public Bottom(int inputNumber, int index, int lenght, int middleStarsCount, int middleStarsDecrement) 
            : base(inputNumber, index, lenght)
        {
            this.MiddleStarsCount = middleStarsCount;
            this.MiddleStarsDecrement = middleStarsDecrement;
        }

        public int MiddleStarsCount { get; set; }

        public int MiddleStarsDecrement { get; set; }

        public string BorderDashes { get; set; }

        public string MiddleDashes { get; set; }

        public string BorderStars { get; set; }

        public string MiddleStars { get; set; }

        public void SetBorderDashes()
        {
            int count = this.Index - 1;
            this.BorderDashes = this.GenerateString(this.Dash, count);
        }

        public void SetMiddleDashes()
        {
            int count = (this.Length - (this.BorderDashes.Length * 2 + this.BorderStars.Length * 2 + this.MiddleStars.Length)) / 2;
            this.MiddleDashes = this.GenerateString(this.Dash, count);

        }

        public void SetBorderStars()
        {
            int count = this.InputNumber;
            this.BorderStars = this.GenerateString(this.Star, count);
        }

        public void SetMiddleStars()
        {
            int count = this.MiddleStarsCount - this.MiddleStarsDecrement;
            this.MiddleStars = this.GenerateString(this.Star, count);
        }

        public override void SetHalf()
        {
            this.Half = $"{this.BorderDashes}{this.BorderStars}{this.MiddleDashes}{this.MiddleStars}{this.MiddleDashes}{this.BorderStars}{this.BorderDashes}";
        }
    }
}
