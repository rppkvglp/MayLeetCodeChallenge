public class Trie 
{
    TrieNode root;
    public Trie() 
    {
        root = new TrieNode();
    }   
    public void Insert(string word) 
    {
        GetEndNode(word, true);
    }
    public bool Search(string word) 
    {
        TrieNode node = GetEndNode(word, false);
        return node != null && node.isWord;
    }    
    public bool StartsWith(string prefix) 
    {
        TrieNode node = GetEndNode(prefix, false);
        return node != null;  
    }    
    public TrieNode GetEndNode(string word, bool insert)
    {
        TrieNode node = root;
        int wordIndex = 0;
        while (node != null && wordIndex < word.Length)
        {
            int nodeIndex = word[wordIndex] - 'a';
            if (insert && node.nodes[nodeIndex] == null) node.nodes[nodeIndex] = new TrieNode();
            node = node.nodes[nodeIndex];
            wordIndex++;
        }
        
        if (insert) node.isWord = true;
        return node;
    }
}

public class TrieNode
{
    public bool isWord;
    public TrieNode[] nodes = new TrieNode[26];
}
