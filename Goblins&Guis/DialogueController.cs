using Goblins_Guis.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Goblins_Guis
{
    internal class DialogueController
    {
        private static readonly Random rand = new Random();
        private NPC currentNPC;
        private Player player;




        public DialogueController(Player player)
        {
            this.player = player;
            currentNPC = new NPC();
        }

        public Player GetPlayer()
        {
            return player;
        }
        public string GetDialogueForAttribute(string attributeType)
        {
            return currentNPC.GetRandomDialogueBasedOnAttribute(attributeType);
        }
        //actions for the player to take
        public bool CanPerformStrAction(int requiredStr)
        {
            return player.STR >= requiredStr;
        }

        public bool CanPerformDexAction(int requiredDex)
        {
            return player.DEX >= requiredDex;
        }

        public bool CanPerformChaAction(int requiredCha)
        {
            return player.CHA >= requiredCha;
        }

        public bool CanPerformConAction(int requiredCon)
        {
            return player.CON >= requiredCon;
        }

        public bool CanPerformIntAction(int requiredInt)
        {
            return player.INT >= requiredInt;
        }

        public bool CanPerformWisAction(int requiredWis)
        {
            return player.WIS >= requiredWis;
        }


        public string GetNPCName()
        {
            return currentNPC.Name;
        }
        public string GetNPCDialogue()
        {
            return currentNPC.Dialogue;
        }
        public string GetNewNPCDialogue()
        {
            return currentNPC.GetRandomDialogue();
        }
        public string GetRandomMidDialogue()
        {
            return currentNPC.GetRandomMidDialogue();
        }
        public string GetRandomEndDialogue()
        {
            return currentNPC.GetRandomEndDialogue();
        }
    }
}
