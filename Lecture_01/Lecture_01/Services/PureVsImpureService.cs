namespace Lecture_01.Services;

public class PureVsImpureService : IPureVsImpureService
{
    public List<int> Numbers { get; set; }

    public void AddInteger()
    {
        Numbers.Add(new Random().Next());
    }

    public void AddInteger(int number)
    {
        Numbers.Add(number);
    }

    public void AddInteger(ref int number)
    {
        number++;
        Numbers.Add(number);
    }

    public List<int> AddInteger(List<int> source, int number)
    {
        var target = new List<int>(source);

        target.Add(number);

        return target;
    }
}
