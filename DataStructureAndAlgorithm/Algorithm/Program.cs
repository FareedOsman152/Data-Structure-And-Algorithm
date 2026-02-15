using Algorithm.Sorting.SelectionSorting;

namespace Algorithm;

class Program
{
    static void Main(string[] args)
    {
        List<int> xList = [7, 2, 0, 4, 8, 1, 4, 3];
        PrintList(xList);
        Console.WriteLine("=============");
        SelectionSortingService<int>.Sort(xList);
        PrintList(xList);
        
    }

    public static void PrintList(List<int> list)
    {
        foreach (var i in list)
        {
            Console.WriteLine(i);
        }
    }
}