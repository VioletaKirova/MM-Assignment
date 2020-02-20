namespace MentorMate_Assignment
{
    public interface ITop
    {
        int StarsIncrement { get; set; }

        string Stars { get; set; }

        string MiddleDashes { get; set; }

        string BorderDashes { get; set; }

        void SetStars();

        void SetMiddleDashes();

        void SetBorderDashes();
    }
}
