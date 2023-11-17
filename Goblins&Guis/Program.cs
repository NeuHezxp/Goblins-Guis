namespace Goblins_Guis
{
    internal static class Program
    {
        /// <summary>
        /// Goblins and gungeons
        /// RPG style Game
        /// 
        /// Game Logic
        /// 
        /// _______
        /// Player Character
        /// stats 
        /// design
        /// ------
        /// Shops
        ///     Money
        ///     Places to spend money
        ///         purchase items
        ///         upgrade items
        ///         repair items
        ///         train skills?
        /// Combat
        ///     Enemy Encounters triggered
        ///     Possibly more enemy encounters
        /// Npcs
        ///     Dialogue
        ///         trees that branch off/maybe a graph
        ///     
        /// 
        /// Build game logic first
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration

            ApplicationConfiguration.Initialize();
            Application.Run(new CharacterCreationForm());
            //FormManager formMangaer = new FormManager();
            //Application.run(formManager.Current);

        }
    }
}