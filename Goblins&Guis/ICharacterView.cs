using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goblins_Guis
{
    internal interface ICharacterView
    {
        string PlayerName { get; set; }
        string PlayerGender { get; set; }
        Character.CharacterClass PlayerClass { get; set; }
        int PlayerStrength { get; set; }
        int PlayerDexterity { get; set; }
        int PlayerConstitution { get; set; }
        int PlayerIntelligence { get; set; }
        int PlayerWisdom { get; set; }
        int PlayerCharisma { get; set; }
       
        event EventHandler DataBindingsComplete; // Event raised when all data bindings are complete

        void BindPlayer(Player player);
        void DisplayPlayerInfo();
    }
}
