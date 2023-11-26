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
        private static readonly string[] StrDialogues =
   {
        "The path of the mighty is not easy. Show your strength to proceed.",
        "Only the strongest may pass through the gates of Valoria.",
        "Your muscles speak louder than words in the Arena of Titans."
    };

        private static readonly string[] DexDialogues =
        {
        "Agility is key. Can you move swiftly enough to evade the shadows?",
        "Only those with the swiftness of a panther can traverse the Silent Forest.",
        "The nimble and quick are favored by the spirits of the wind."
    };
        private static readonly string[] ConDialogues =
        {
        "Wisdom is the light in the darkness. Can you illuminate the path?",
        "The wise are revered in the Library of Echoes. What wisdom do you bring?",
        "Solve the riddle of the ancients to proceed on your journey."
    };

        private static readonly string[] ChaDialogues =
        {
        "A charming soul can open many doors. Will yours open the right one?",
        "In the Court of Whispers, your charisma is your best weapon.",
        "Win hearts and you shall win your path forward."
    };

        private static readonly string[] WisDialogues =
        {
        "Wisdom is the light in the darkness. Can you illuminate the path?",
        "The wise are revered in the Library of Echoes. What wisdom do you bring?",
        "Solve the riddle of the ancients to proceed on your journey."
    };

        private static readonly string[] IntDialogues =
        {
        "Intelligence is the key to unlocking the mysteries of the world.",
        "In the Tower of Logic, only the cleverest minds may ascend.",
        "A puzzle awaits you, requiring more than mere strength to solve."
    };

        public string Name { get; private set; }
        public string Dialogue { get; set; }
        private static readonly Random rand = new Random();

        public NPC()
        {
            Name = GetRandomName();
            Dialogue = GetRandomDialogue();
        }
        public string GetRandomDialogueBasedOnAttribute(string attributeType)
        {
            string[] selectedArray;
            switch (attributeType)
            {
                case "STR":
                    selectedArray = StrDialogues;
                    break;
                case "DEX":
                    selectedArray = DexDialogues;
                    break;
                case "CON":
                    selectedArray = ConDialogues;
                    break;
                case "CHA":
                    selectedArray = ChaDialogues;
                    break;
                case "WIS":
                    selectedArray = WisDialogues;
                    break;
                case "INT":
                    selectedArray = IntDialogues;
                    break;

                default:
                    selectedArray = RandomDialogues;
                    break;
            }

            return selectedArray[rand.Next(selectedArray.Length)];
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
