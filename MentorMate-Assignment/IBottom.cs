namespace MentorMate_Assignment
{
    public interface IBottom
    {
        int MiddleStarsCount { get; set; }

        int MiddleStarsDecrement { get; set; }

        string BorderDashes { get; set; }

        string MiddleDashes { get; set; }

        string BorderStars { get; set; }

        string MiddleStars { get; set; }

        void SetBorderDashes();

        void SetMiddleDashes();

        void SetBorderStars();

        void SetMiddleStars();
    }
}
