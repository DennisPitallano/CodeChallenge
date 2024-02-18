namespace ArraySum;

public class Formulas
{

    public static bool CheckSum(int[] nums, int target)
    {
        // Create a HashSet to store the complement of each number
        var complements = new HashSet<int>();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Array Values:[{string.Join(",", nums)}]");
        Console.WriteLine($"Target Value:{target}");
        Console.WriteLine("----------------------------------------");
        foreach (var num in nums)
        {
            // Check if the complement of the current number exists in the HashSet
            Console.WriteLine($"Checking Number:{num}");
            if (complements.Contains(num))
            {
                Console.WriteLine($"Found a pair:{num}");
                return true; // Found a pair that adds up to the target
            }
            Console.WriteLine("----------------------------------------");
            // Add the complement of the current number to the HashSet
            var complement = target - num;
            Console.WriteLine($"Computing Complement:({target}-{num})={complement}");
            Console.WriteLine($"Add Complement Number:{complement}");
            complements.Add(complement);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"HashSet Values:[{string.Join(",", complements)}]");
            Console.WriteLine("----------------------------------------");
        }

        return false; // No pair found
    }

    public static bool CheckSumNestedLoop(int[] array, int target)
    {
        var length = array.Length;
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Array Values:[{string.Join(",", array)}]");
        Console.WriteLine($"Target Value:{target}");
        Console.WriteLine("----------------------------------------");
        // Iterate through each element in the array
        for (var i = 0; i < length; i++)
        {
            // Check if the current element plus any subsequent element equals the target
            Console.WriteLine($"Checking Number:{array[i]}");
            Console.WriteLine("----------------------------------------");
            for (var j = i + 1; j < length; j++)
            {
                Console.WriteLine($"Checking current pair:({array[i]}+{array[j]})={target}");
                if (array[i] + array[j] == target)
                {
                    Console.WriteLine($"Found a pair:{array[j]}");
                    return true; // Found a pair that adds up to the target
                }
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Pair is not equal to the target.");
                Console.WriteLine("----------------------------------------");
            }
        }

        return false; // No pair found that adds up to the target
    }

}