public class Solution {
    public int PrefixCount(string[] words, string pref) {
        
        
        int ret = 0;
        
        foreach (string word in words) {
            if (word.Length >= pref.Length) {
                for (int i = 0; i < pref.Length; i++) {
                    if (word[i] == pref[i]) {
                        if (i == pref.Length - 1) {
                            ret++;
                        }
                    } else {
                        break;
                    }
                }
            }
            
            
        }
        
        return ret;
    }
}
