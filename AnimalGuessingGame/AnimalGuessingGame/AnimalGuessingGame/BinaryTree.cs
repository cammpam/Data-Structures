using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGuessingGame
{
    [Serializable]
    class BinaryTree
    {
        BTNode rootNode;
        public BinaryTree(string question, string yesGuess, string noGuess)
        {
            rootNode = new BTNode(question);
            rootNode.setYesNode(new BTNode(yesGuess));
            rootNode.setNoNode(new BTNode(noGues s));
        }

        public void query()
        {
            rootNode.query();
        }
    }

}
