using Class.Solution;
class Program
{
    static void Main()
    {
        int[] nums = new int[] { 1, 2, 2, 3 };
        var s = new Solution();
        Console.WriteLine(s.Subsets(nums).ToString());
    }

}


