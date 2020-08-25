using System;
using System.Collections.Generic;

namespace BinarySearchTreeDojo
{
    public class BinarySearchTree
    {
        private Node root;

        private BinarySearchTree()
        {
            // private constructor so it can't be instantiated like this
            root = null;
        }

        public static BinarySearchTree Build(List<int> elements)
        {
            BinarySearchTree tree = new BinarySearchTree();

            // TODO construct a binary search tree here
            foreach (var item in elements)
            {
                tree.Add(item);
            }
            return tree;
        }

        public Boolean Search(int toFind)
        {
            // TODO return true if the element has been found, false if its not in the tree.
            bool isFound = false;
            Node current = root;
            while (current != null && isFound == false)
            {
                if (current.data == toFind) isFound = true;
                if (toFind < current.data)
                {
                    if (current.left == null) break;
                    else current = current.left;
                }
                if (toFind > current.data)
                {
                    if (current.right == null) break;
                    else current = current.right;
                }
            }

            return isFound;
        }

        public void Add(int toAdd)
        {
            // TODO adds an element. Throws an error if it exist.
            if (Search(toAdd) == true) throw new ArgumentException();
            else
            {
                Node newNode = new Node(toAdd);
                if (root == null) root = newNode;
                else
                {
                    Node current = root;
                    while (current != null)
                    {
                        Node parent = current;
                        if (toAdd < current.data)
                        {
                            current = current.left;
                            if (current == null) parent.left = newNode;
                        }
                        else
                        {
                            current = current.right;
                            if (current == null) parent.right = newNode;
                        }
                    }
                }
            }
        }

        public void Remove(int toRemove)
        {
            // TODO removes an element. Throws an error if its not on the tree.
            this.root = Remove(root, toRemove);
        }

        public Node Remove(Node parent, int key)
        {
            if (parent == null) return parent;
            if (key < parent.data) parent.left = Remove(parent.left, key);
            else if (key > parent.data) parent.right = Remove(parent.right, key);
            else
            {
                if (parent.left == null) return parent.right;
                else if (parent.right == null) return parent.left;
                parent.right = Remove(parent.right, parent.data);
            }
            return parent;
        }
    }

    public class Node
{
    public int data;
    public Node left, right;

    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}
}