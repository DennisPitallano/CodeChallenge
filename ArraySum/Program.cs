using ArraySum;
using BenchmarkDotNet.Running;

int[] nums = [1, 2, 3, 4];
const int target = 5;


//var result = Formulas.CheckSum(nums, target);
//Console.WriteLine(result);
//var result1 = Formulas.CheckSumNestedLoop(nums, target);
//Console.WriteLine(result1);

//for benchmark
BenchmarkRunner.Run<Benchnark>();