using Goblins_Guis.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goblins_Guis
{
    internal class NPC
    {
        private static readonly string[] RandomNames =
 {
    "Eldrin Stormcloak",
    "Lia Sunwhisper",
    "Tharok Bloodaxe",
    "Ilyana Starbreeze",
    "Morgar Ironfist",
    "Sylthia Moonshadow",
    "Gorim Flamebeard",
    "Ariella Lightfoot",
    "Drazzak the Sly",
    "Zephyra Skydancer"
};
        private static readonly string[] RandomDialogues =
{
    "Welcome to the Drunken Dragon! What can I get for you on this fine evening?",
    "Ah, a new face in the Armory of Iron Might! Looking for a sword or a shield today?",
    "Greetings, traveler! The Mystic's Emporium has potions and scrolls for all your needs.",
    "Step into the Enchanted Garden, where rare herbs and magical plants await your perusal.",
    "Hail, adventurer! The Archive of Ancient Lore is open to those who seek knowledge.",
    "Welcome to the Silver Serpent Inn. Rest your weary feet and enjoy a warm meal.",
    "The Forge of Fiery Fates greets you! Need your weapon tempered or a new armor forged?",
    "Enter the Emporium of Exotic Curiosities, where wonders from across the lands are gathered.",
    "Well met, traveler! The Bazaar of Bountiful Baubles offers trinkets and treasures galore.",
    "Step right up to the Wandering Wizard's Wagon, filled with magical marvels and arcane artifacts."
};


        public string Name { get; private set; }
        public string Dialogue { get; set; }
        private static readonly Random rand = new Random();

        public NPC()
        {
            Name = GetRandomName();
            Dialogue = GetRandomDialogue();
        }

        private string GetRandomName()
        {
            return RandomNames[rand.Next(RandomNames.Length)];
        }

        public string GetRandomDialogue()
        {
            return RandomDialogues[rand.Next(RandomDialogues.Length)];
        }
    }

}
