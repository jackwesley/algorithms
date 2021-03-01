using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    //Caso exista o valor procurado na árvore retorna true, ao contrário retorna false
    //Busca em profundidade DFS
    public class DepthFirstSearch
    {
        public bool Search(Node node, int valueToFind)
        {
            if (node == null)
                return false;

            if (node.Value == valueToFind)
                return true;

            return Search(node.Left, valueToFind) || Search(node.Right, valueToFind);
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
