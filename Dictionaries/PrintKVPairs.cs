public void PrintKVPairs(Dictionary<char, int> dict) {
        foreach (KeyValuePair<char, int> pair in dict) {
            Console.WriteLine("Key: {0}, Value: {1}",  pair.Key, pair.Value); 
        }
    }
