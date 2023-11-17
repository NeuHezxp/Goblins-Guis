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
        private NPC npc;

        public DialogueController()
        {
            // Initialize with a default NPC
            npc = new NPC();
        }
        
        public string GetNPCName()
        {
            return npc.Name;
        }
        public string GetNPCDialogue()
        {
            return npc.Dialogue;
        }
        public string GetNewNPCDialogue()
        {
            return npc.GetRandomDialogue();
        }
    }
}
