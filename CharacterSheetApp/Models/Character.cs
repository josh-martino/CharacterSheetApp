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
            //make sure character list isn't null. If it is it will be a new list of characters.
            if (GlobalVariables.Characters == null)
            {
                GlobalVariables.Characters = new List<Character>();
            }
            GlobalVariables.Characters.Add(character);
        }

        public static List<Character> GetAll()
        {
            //handle the nulls
            if (GlobalVariables.Characters == null)
            {
                GlobalVariables.Characters = new List<Character>();
            }
            //return a list of characters from the globalvariables character list.
            return GlobalVariables.Characters;
        }
    }
}