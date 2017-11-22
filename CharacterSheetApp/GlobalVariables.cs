using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CharacterSheetApp.Models;

namespace CharacterSheetApp
{
    public static class GlobalVariables
    {
        //by using get; set it lets us create a new list if Characters property is null.
        public static List<Character> Characters { get; set; }
        = new List<Character>();
    }
}