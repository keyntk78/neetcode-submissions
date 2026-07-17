public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
          if (nums == null || nums.Length == 0)
    {
        return Array.Empty<int>();
    }

    int n = nums.Length;

    int[] prefixs = new int[n];
    int[] suffixs = new int[n];
    int[] result = new int[n];

    // Tích các phần tử bên trái
    prefixs[0] = 1;

    for (int i = 1; i < n; i++)
    {
        prefixs[i] = prefixs[i - 1] * nums[i - 1];
    }

    // Tích các phần tử bên phải
    suffixs[n - 1] = 1;

    for (int i = n - 2; i >= 0; i--)
    {
        suffixs[i] = suffixs[i + 1] * nums[i + 1];
    }

    // Tích bên trái × tích bên phải
    for (int i = 0; i < n; i++)
    {
        result[i] = prefixs[i] * suffixs[i];
    }

    return result;
    }
}
