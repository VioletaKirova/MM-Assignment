namespace MentorMate_Assignment
{
    public interface ILine
    {
        int InputNumber { get; set; }

        int Index { get; set; }

        int Length { get; set; }

        string Half { get; set; }

        string GenerateString(char symbol, int count);

        string Draw();

        void SetHalf();
    }
}
