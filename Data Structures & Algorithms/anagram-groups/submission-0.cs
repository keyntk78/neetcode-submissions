public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
         // Tạo 1 hashmap để lưu trữ các nhóm anagram (key: string, value: List<string>)
        Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();
        // Duyệt qua từng chuỗi trong mảng strs
        foreach (var str in strs)
        {
            // chuyển chuỗi thành mảng ký tự và sắp xếp mảng ký tự theo thứ tự tăng dần
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            // chuyển mảng ký tự đã sắp xếp thành chuỗi mới
            string sortedStr = new string(charArray);
            if (!anagramGroups.ContainsKey(sortedStr)){
                anagramGroups[sortedStr] = new List<string>();
            }
            // thêm chuỗi gốc vào danh sách tương ứng với key đã sắp xếp
            anagramGroups[sortedStr].Add(str);
        }
        return new List<List<string>>(anagramGroups.Values);
    }
}
