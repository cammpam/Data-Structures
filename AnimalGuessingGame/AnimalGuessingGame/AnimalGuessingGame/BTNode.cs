using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGuessingGame
{
    [Serializable]
    class BTNode
    {
        string message;
        BTNode noNode;
        BTNode yesNode;

        public BTNode(string nodeMessage)
        {
            message = nodeMessage;
            noNode = null;
            yesNode = null;
        }

        public bool isQuestion()
        {
            if (noNode == null && yesNode == null)
                return false;
            else
                return true;
        }

        private char getYesOrNo()
        {
            char inputCharacter = ' ';
            while (inputCharacter != 'y' && inputCharacter != 'n')
            {
                inputCharacter = Console.ReadLine().ElementAt(0);
                inputCharacter = Char.ToLower(inputCharacter);
            }
            return inputCharacter;
        }

        public void onQueryObject()
        {
            Console.WriteLine("Are you thinking of a(n) " + this.message + "?");
            Console.WriteLine("Y/N");
            char input = getYesOrNo(); //y or n
            if (input == 'y')
                Console.Write("The Computer Wins\n");
            else
                updateTree();
        }

        private void updateTree()
        {
            Console.Write("You win! What were you thinking of?");
            string userObject = Console.ReadLine();
            Console.Write("Please enter a question to distinguish a(n) "
                + this.message + " from " + userObject + ": ");
            string userQuestion = Console.ReadLine();
            Console.Write("If you were thinking of a(n) " + userObject
                + ", what would the answer to that question be?");
            char input = getYesOrNo(); //y or n
            if (input == 'y')
            {
                this.noNode = new BTNode(this.message);
                this.yesNode = new BTNode(userObject);
            }
            else
            {
                this.yesNode = new BTNode(this.message);
                this.noNode = new BTNode(userObject);
            }
            Console.Write("Thank you my knowledge has been increased");
            this.setMessage(userQuestion);
        }
        public void query()
        {
            if (this.isQuestion())
            {
                Console.WriteLine(this.message);
                Console.Write("y/n");
                char input = getYesOrNo(); //y or n
                if (input == 'y')
                {

                    yesNode.query();
                }
                else
                {
                    noNode.query();
                }

            }
            else
            {
                this.onQueryObject();
            }
        }

        public void setMessage(string nodeMessage)
        {
            message = nodeMessage;
        }
        public string getMessage()
        {
            return message;
        }
        public void setNoNode(BTNode node)
        {
            noNode = node;
        }
        public BTNode getNoNode()
        {
            return noNode;
        }
        public void setYesNode(BTNode node)
        {
            yesNode = node;
        }
        public BTNode getYesNode()
        {
            return yesNode;
        }
    }
}
