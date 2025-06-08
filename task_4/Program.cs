using Tree;

// функция, которая выводит все узлы дерева и выводит на экран все ключи
void main()
{
    Trie trie = new();
    trie.AddWord("cat");
    trie.AddWord("can");
    trie.AddWord("yellow");
    trie.AddWord("yellooun");
    trie.AddWord("wibe");
    List<string> autoNameWords = new List<string>();
    trie.AutoNameGenerate(trie.Root, "yel", autoNameWords);
    autoNameWords.ForEach((word) => Console.WriteLine(word));
}

main();

namespace Tree
{
    public class TreeNode
    {
        public bool IsWord { get; set; }
        public Dictionary<char, TreeNode> Children { get; } = new();
    }

    public class Trie
    {
        private readonly TreeNode _root = new();
        public TreeNode Root
        {
            get { return _root; }
        }

        public void AddWord(string word)
        {
            var node = _root;
            foreach (char c in word)
            {
                if (!node.Children.ContainsKey(c))
                    node.Children[c] = new TreeNode();
                node = node.Children[c];
            }
            node.IsWord = true;
        }

        public bool Search(string word)
        {
            var node = _root;
            foreach (char c in word)
            {
                if (!node.Children.TryGetValue(c, out node))
                    return false;
            }
            return node.IsWord;
        }

        public bool StartsWith(string prefix)
        {
            var node = _root;
            foreach (char c in prefix)
            {
                if (!node.Children.TryGetValue(c, out node))
                    return false;
            }
            return true;
        }

        public void traverse(TreeNode currentNode)
        {
            if (currentNode == null)
            {
                return;
            }
            foreach (char c in currentNode.Children.Keys)
            {
                Console.WriteLine(c);
                traverse(currentNode.Children[c]);
            }
        }

        public void AutoNameGenerate(
            TreeNode currentNode,
            string prefix,
            List<string> AutonameWords,
            string foundWord = ""
        )
        {
            if (currentNode == null)
            {
                return;
            }

            foreach (char c in currentNode.Children.Keys)
            {
                if (prefix.Length == 0)
                {
                    AutoNameGenerate(currentNode.Children[c], prefix, AutonameWords, foundWord + c);
                    if (currentNode.Children[c].IsWord)
                    {
                        AutonameWords.Add(foundWord + c);
                    }
                }
                else
                {
                    if (prefix.StartsWith(c))
                    {
                        foundWord += c;
                        if (currentNode.IsWord)
                        {
                            AutonameWords.Add(foundWord);
                        }
                        AutoNameGenerate(
                            currentNode.Children[c],
                            prefix.Substring(1),
                            AutonameWords,
                            foundWord
                        );
                    }
                    else
                    {
                        AutoNameGenerate(
                            currentNode.Children[c],
                            c + prefix.Substring(1),
                            AutonameWords,
                            foundWord
                        );
                    }
                }
            }
        }
    }
}
