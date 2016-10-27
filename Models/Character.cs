using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MVCMaby.Models 
{
    public class Character
    {
        public string Name;
        public static void Create(string CharacterName)
        {
            var character = new Character();
            character.Name = CharacterName;
            if (GlobalVariables.Characters ==null)
                GlobalVariables.Characters = new List<Character>();
            GlobalVariables.Characters.Add(character);
        }
        public static List<Character> GetAll()
        {
            if (GlobalVariables.Characters == null)
                GlobalVariables.Characters = new List<Character>();
            return GlobalVariables.Characters;
        }
    }
}