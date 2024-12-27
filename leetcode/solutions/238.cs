using System.Linq;
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var prefix = new int[nums.Length];
        prefix[0] = 1;
        for (int i = 1; i < nums.Length; i++) {
            prefix[i] = prefix[i - 1] * nums[i - 1];
        }
        int product = 1;
        Console.WriteLine("["+string.Join(",", prefix)+"]");
        for (int i = nums.Length - 1; i >= 0; i--) {
            prefix[i] = prefix[i] * product;
            product *= nums[i];
        }
        return prefix;
    }
}

public class Program {
    public static void Main(string[] args) {
        var sol = new Solution();
        int[] nums = sol.ProductExceptSelf([1, 2, 3, 4]);
    }
}
