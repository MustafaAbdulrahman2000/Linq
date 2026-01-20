namespace Lecture_01.Services
{
    public interface IPureVsImpureService
    {
        List<int> Numbers { get; set; }
        void AddInteger();
        void AddInteger(int number);
        List<int> AddInteger(List<int> source, int number);
        void AddInteger(ref int number);
    }
}