public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
          // Tạo một hashmap để lưu trữ tần suất xuất hiện của từng phần tử trong mảng nums
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        // Đếm tần suất xuất hiện của từng phần tử trong mảng nums
        foreach (int num in nums)
        {
            if (!frequencyMap.ContainsKey(num))
            {
                frequencyMap[num] = 0;
            }
            frequencyMap[num]++;
        }
        // Sắp xếp các phần tử theo tần suất giảm dần và lấy k phần tử đầu tiên
        var sorted = frequencyMap.OrderByDescending(x => x.Value).Take(k);
        return sorted.Select(x => x.Key).ToArray();
    }
}
