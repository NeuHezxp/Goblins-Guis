using Goblins_Guis.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goblins_Guis
{
    internal class DialogueController
    {
       
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

        // Add methods to interact with the Player object
        // For example, a method to check if a player can perform a certain action
        public bool CanPerformAction(int requiredStat)
        {
            // Logic to determine if the player can perform the action
            // This could be based on the player's STR, DEX, etc.
            return player.STR > requiredStat; 
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
    }
}
