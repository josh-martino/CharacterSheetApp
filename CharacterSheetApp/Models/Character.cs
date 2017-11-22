using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterSheetApp.Models
{
    public class Character
    {
        public string Name;
        //made static so we don't have to instantiate the class first.
        public static void Create(string characterName)
        {
            var character = new Character();
            character.Name = characterName;

            GlobalVariables.Characters.Add(character);
        }

        public static List<Character> GetAll()
        {
            //return a list of characters from the globalvariables character list.
            return GlobalVariables.Characters;
        }
    }
}