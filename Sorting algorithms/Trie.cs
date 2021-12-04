using System;
using System.Collections.Generic;


namespace Shakespeare.Sorting_algorithms
{
    public class Trie
    {
        public static Node rootNode;

        public Trie()
        {
            rootNode = null;
        }


        public static void insert(String key, int index)
        {

            if (rootNode == null)
            {
                rootNode = new Node();
            }

            Node currentNode = rootNode;

            for (int i = 0; i < key.Length; i++)
            {
                char keyChar = key[i];

                if (currentNode.getChild(keyChar) == null)
                {
                    currentNode.addChild(keyChar);
                }


                currentNode = currentNode.getChild(keyChar);
            }


            currentNode.addIndex(index);
        }

        public static void traversePreorder(String[] array)
        {
            traversePreorder(rootNode, array);
        }

        public static void traversePreorder(Node node,
                                String[] array)
        {
            if (node == null)
            {
                return;
            }

            //if (node.getIndices().Count > 0)
            //{
            //    foreach (int index in node.getIndices())
            //    {
            //        Console.WriteLine(array[index] + " ");
            //    }
            //}

            for (char index = 'a'; index <= 'z'; index++)
            {
                traversePreorder(node.getChild(index), array);
            }
        }

        public class Node
        {

            public Node[] children;
            public List<int> indices;

            public Node()
            {
                children = new Node[26];
                indices = new List<int>(0);
            }

            public Node getChild(char index)
            {
                if (index < 'a' || index > 'z')
                {
                    return null;
                }

                return children[index - 'a'];
            }

            public void addChild(char index)
            {
                if (index < 'a' || index > 'z')
                {
                    return;
                }

                Node node = new Node();
                children[index - 'a'] = node;
            }

            public List<int> getIndices()
            {
                return indices;
            }

            public void addIndex(int index)
            {
                indices.Add(index);
            }
        }


        public static void printInSortedOrder(String[] array)
        {


            for (int i = 0; i < array.Length; i++)
            {
                insert(array[i], i);
            }

            traversePreorder(array);
        }








    }
}