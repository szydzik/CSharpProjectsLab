using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTree
{
    public class AVLTree<TKey, TValue> : IEnumerable<AVLNode<TKey, TValue>> where TKey : IComparable<TKey>
    {
        private AVLNode<TKey, TValue> root;

        public AVLTree()
        {
            this.root = null;
        }

        /// <summary>
        /// Tree indexer.
        /// </summary>
        public TValue this[TKey key]
        {
            set
            {
                this.Insert(key, value);
            }
            get
            {
                TValue result;
                if (!this.TryGetValue(key, out result))
                {
                    throw new KeyNotFoundException();
                }
                return result;
            }
        }

        ///<summary>
        ///Jesli jest wezel z danym kluczem, ustawia parametr result i zwraca true
        ///</summary>
        public bool TryGetValue(TKey key, out TValue result)
        {
            AVLNode<TKey, TValue> current = root;
            while (current != null)
            {
                if (current.Key.CompareTo(key) == -1)
                {
                    current = current.RightChild;
                }
                else if (current.Key.CompareTo(key) == 1)
                {
                    current = current.LeftChild;
                }
                else
                {
                    result = current.Value;
                    return true;
                }
            }
            result = default(TValue);
            return false;
        }

        /// <summary>
        /// Sprawdza czy w drzewie istnieje wezel o danym indeksie
        /// </summary>
        public bool ContainsKey(TKey key)
        {
            TValue tmp;
            return this.TryGetValue(key, out tmp);
        }

        /// <summary>
        /// Wprowadzanie danych: klucz-wartosc do drzewa
        /// </summary>
        public void Insert(TKey key, TValue value)
        {

            //tworzenie nowego drzewa, jesli nie istnieje. pierwszy wezel jako root
            if (this.root == null)
            {
                this.root = new AVLNode<TKey, TValue>(key, value);
            }
            else
            {
                AVLNode<TKey, TValue> currentNode = root;
                while (currentNode != null)
                {
                    if (currentNode.Key.CompareTo(key) == -1)
                    {
                        if (currentNode.RightChild == null)
                        {
                            currentNode.RightChild = new AVLNode<TKey, TValue>(key, value, currentNode);
                            /*
                             * Since we insert the node in the right child of the current node, the height of the
                             * right subtree increases, so the difference 
                             * height(left-subtree) - height(right-subtree) decreases by 1.
                             */

                            InsertBalanceTree(currentNode, -1);
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.RightChild;
                        }
                    }
                    else if (currentNode.Key.CompareTo(key) == 1)
                    {
                        if (currentNode.LeftChild == null)
                        {
                            currentNode.LeftChild = new AVLNode<TKey, TValue>(key, value, currentNode);
                            /*
                             * Since we insert the node in the left child of the current node, the height of the
                             * left subtree increases, so the difference 
                             * height(left-subtree) - height(right-subtree) increases by 1.
                             */
                            InsertBalanceTree(currentNode, 1);
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.LeftChild;
                        }
                    }
                    else
                    {
                        currentNode.Value = value;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Czyszczenie drzewa
        /// </summary>
        public void Clear()
        {
            this.root = null;
        }

        /// <summary>
        /// Adjusts the balance factors for affected tree nodes.
        /// </summary>
        private void InsertBalanceTree(AVLNode<TKey, TValue> node, int addBalance)
        {
            while (node != null)
            {
                //Add the new balance value to the current node balance.
                node.Balance += addBalance;

                /*
                 * If the balance was -1 or +1, the tree is still balanced so
                 * we don't have to balanced it further
                */
                if (node.Balance == 0)
                {
                    break;
                }
                //If the height(left-subtree) - height(right-subtree) == 2
                else if (node.Balance == 2)
                {
                    if (node.LeftChild.Balance == 1)
                    {
                        RotateLeftLeft(node);
                    }
                    else
                    {
                        RotateLeftRight(node);
                    }
                    break;
                }

                //If the height(left-subtree) - height(right-subtree) == -2
                else if (node.Balance == -2)
                {
                    if (node.RightChild.Balance == -1)
                    {
                        RotateRightRight(node);
                    }
                    else
                    {
                        RotateRightLeft(node);
                    }
                    break;
                }

                if (node.Parent != null)
                {
                    /*
                     * If the current node is the left child of the parent node
                     * we need to increase the height of the parent node. 
                     * */
                    if (node.Parent.LeftChild == node)
                    {
                        addBalance = 1;
                    }
                    /*
                     * If it is the right child, 
                     * we decrease the height of the parent node
                     * */
                    else
                    {
                        addBalance = -1;
                    }
                }
                node = node.Parent;
            }
        }

        /// <summary>
        /// Makes right-right rotation.
        /// </summary>
        private void RotateRightRight(AVLNode<TKey, TValue> node)
        {
            AVLNode<TKey, TValue> rightChild = node.RightChild;
            AVLNode<TKey, TValue> rightLeftChild = null;
            AVLNode<TKey, TValue> parent = node.Parent;

            if (rightChild != null)
            {
                rightLeftChild = rightChild.LeftChild;
                rightChild.Parent = parent;
                rightChild.LeftChild = node;
                rightChild.Balance++;
                node.Balance = -rightChild.Balance;
            }

            node.RightChild = rightLeftChild;
            node.Parent = rightChild;

            if (rightLeftChild != null)
            {
                rightLeftChild.Parent = node;
            }
            if (node == this.root)
            {
                this.root = rightChild;
            }
            else if (parent.RightChild == node)
            {
                parent.RightChild = rightChild;
            }
            else
            {
                parent.LeftChild = rightChild;
            }
        }


        /// <summary>
        /// Makes left-left rotation.
        /// </summary>
        private void RotateLeftLeft(AVLNode<TKey, TValue> node)
        {
            AVLNode<TKey, TValue> leftChild = node.LeftChild;
            AVLNode<TKey, TValue> leftRightChild = null;
            AVLNode<TKey, TValue> parent = node.Parent;

            if (leftChild != null)
            {
                leftRightChild = leftChild.RightChild;
                leftChild.Parent = parent;
                leftChild.RightChild = node;
                leftChild.Balance--;
                node.Balance = -leftChild.Balance;
            }

            node.Parent = leftChild;
            node.LeftChild = leftRightChild;

            if (leftRightChild != null)
            {
                leftRightChild.Parent = node;
            }

            if (node == this.root)
            {
                this.root = leftChild;
            }
            else if (parent.LeftChild == node)
            {
                parent.LeftChild = leftChild;
            }
            else
            {
                parent.RightChild = leftChild;
            }

        }


        /// <summary>
        /// Makes right-left rotation.
        /// </summary>
        private void RotateRightLeft(AVLNode<TKey, TValue> node)
        {
            AVLNode<TKey, TValue> rightChild = node.RightChild;
            AVLNode<TKey, TValue> rightLeftChild = null;
            AVLNode<TKey, TValue> rightLeftRightChild = null;

            if (rightChild != null)
            {
                rightLeftChild = rightChild.LeftChild;
            }
            if (rightLeftChild != null)
            {
                rightLeftRightChild = rightLeftChild.RightChild;
            }

            node.RightChild = rightLeftChild;

            if (rightLeftChild != null)
            {
                rightLeftChild.Parent = node;
                rightLeftChild.RightChild = rightChild;
                rightLeftChild.Balance--;
            }

            if (rightChild != null)
            {
                rightChild.Parent = rightLeftChild;
                rightChild.LeftChild = rightLeftRightChild;
                rightChild.Balance--;
            }

            if (rightLeftRightChild != null)
            {
                rightLeftRightChild.Parent = rightChild;
            }

            RotateRightRight(node);
        }


        /// <summary>
        /// Makes left-right rotation.
        /// </summary>
        private void RotateLeftRight(AVLNode<TKey, TValue> node)
        {
            AVLNode<TKey, TValue> leftChild = node.LeftChild;
            AVLNode<TKey, TValue> leftRightChild = leftChild.RightChild;
            AVLNode<TKey, TValue> leftRightLeftChild = null;
            if (leftRightChild != null)
            {
                leftRightLeftChild = leftRightChild.LeftChild;
            }

            node.LeftChild = leftRightChild;

            if (leftRightChild != null)
            {
                leftRightChild.Parent = node;
                leftRightChild.LeftChild = leftChild;
                leftRightChild.Balance++;
            }

            if (leftChild != null)
            {
                leftChild.Parent = leftRightChild;
                leftChild.RightChild = leftRightLeftChild;
                leftChild.Balance++;
            }

            if (leftRightLeftChild != null)
            {
                leftRightLeftChild.Parent = leftChild;
            }


            RotateLeftLeft(node);
        }


        //Traverses the tree in pre-order.
        public IEnumerator<AVLNode<TKey, TValue>> GetEnumerator()
        {
            Queue<AVLNode<TKey, TValue>> queue = new Queue<AVLNode<TKey, TValue>>();
            queue.Enqueue(this.root);

            AVLNode<TKey, TValue> tmp;
            while (queue.Count > 0)
            {
                tmp = queue.Dequeue();

                if (tmp.LeftChild != null)
                {
                    queue.Enqueue(tmp.LeftChild);
                }
                if (tmp.RightChild != null)
                {
                    queue.Enqueue(tmp.RightChild);
                }

                yield return tmp;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder("");

            Stack<AVLNode<TKey, TValue>> stack = new Stack<AVLNode<TKey, TValue>>();
            if (this.root != null)
            {
                stack.Push(root);
                AVLNode<TKey, TValue> tmpNode;
                while (stack.Count > 0)
                {
                    tmpNode = stack.Pop();

                    if (tmpNode.Parent == null)
                    {
                        result.AppendLine(tmpNode + " is root.");
                    }
                    else if (tmpNode.Parent.RightChild == tmpNode)
                    {
                        result.AppendLine(tmpNode.Parent + " has right child: " + tmpNode);
                    }
                    else
                    {
                        result.AppendLine(tmpNode.Parent + " has left child: " + tmpNode);
                    }

                    if (tmpNode.RightChild != null)
                    {
                        stack.Push(tmpNode.RightChild);
                    }
                    if (tmpNode.LeftChild != null)
                    {
                        stack.Push(tmpNode.LeftChild);
                    }
                }
            }
            return result.ToString();
        }

    }
}
