public class Solution {
    public bool IsAnagram(string s, string t) {

            if(s.Length != t.Length)
            {
                return false;
            }

            int[] count = new int[26];

            foreach (int c in s)
            {
                count[c - 'a']++;
            }

            foreach (int c in t)
            {
                count[c - 'a']--;

                if(count[c - 'a'] < 0)
                {
                    return false;
                }
            }

            return true;
    }
}
