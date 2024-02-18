using BenchmarkDotNet.Attributes;

namespace ArraySum;

public class Benchnark
{
     int[] nums = [1, 2, 3, 4];
     const int target = 5;

    [Benchmark]
    public void CheckSum()
    {
        Formulas.CheckSum(nums, target);
    }

    [Benchmark]
    public void CheckSumNestedLoop()
    {
        Formulas.CheckSumNestedLoop(nums, target);
    }
}