﻿using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace BinarySearchTreeDojo
{
    public class BinarySearchTree
    {
        private readonly Node root;

        private BinarySearchTree()
        {
            // private constructor so it can't be instantiated like this
            root = null;
        }

        public static BinarySearchTree Build(List<int> elements)
        {
            // TODO construct a binary search tree here
            return null;
        }
    
        public Boolean Search(int toFind) {
            // TODO return true if the element has been found, false if its not in the tree.
            return false;
        }

        public void Add(int toAdd) {
            // TODO adds an element. Throws an error if it exist.
        }

        public void Remove(int toRemove) {
            // TODO removes an element. Throws an error if its not on the tree.
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
