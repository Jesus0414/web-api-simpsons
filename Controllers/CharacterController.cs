using web_api_simpsons.Dependencies;
using System.Collections.Generic;
using web_api_simpsons.Modules; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace web_api_simpsons.Controllers
{
    [Route("simpsons/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class CharacterController : ICharacter
    {
        List<Character> characterList => new List<Character>
        {
            new Character
            {
                FirstName = "Homero",
                SecondName = "Jay",
                LastName = "Simpson",
                Age = 34,
                Description = "Esposo de Marge y padre de Bart, Lisa y Maggie."
            },
            new Character
            {
                FirstName = "Bartolomeo",
                SecondName = "Jay",
                LastName = "Simpson",
                Age = 10,
            },
            new Character
            {
                FirstName = "Margory",
                LastName = "Simpson",
                Age = 34,
            },
            new Character
            {
                FirstName = "Lisa",
                LastName = "Simpson",
                Age = 8,
            }
        };

        [HttpGet]
        public List<Character> GetCharacterList()
        {
            return characterList;
        }

        [HttpGet("{id}")]
        public Character GetCharacter(int id)
        {
            return characterList[id];
        }
    }
}