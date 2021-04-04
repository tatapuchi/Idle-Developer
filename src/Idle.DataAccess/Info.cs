using Idle.Core.Fields;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.DataAccess
{
    public class Info
    {

        public Language GetLanguage(FieldDTO dto)
        {
            switch (dto.Name)
            {
                case "HTML":
                    return new Language(dto, "HTML", 10,
                        "Truly, the hardest of all known programming languages. Only a few have gained competence in this craft");
                case "CSS":
                    return new Language(dto, "CSS", 10,
                        "Make your HTML stuff look not shit with this rudimentary style sheet language");
                case "JavaScript":
                    return new Language(dto, "JavaScript", 250,
                        "Very widely used. Big good!");
                case "PHP":
                    return new Language(dto, "PHP", 20,
                        "Language for backend stuff I guess. The logo is funny so thats a plus.");
                case "Python":
                    return new Language(dto, "Python", 300,
                        "Snek. What more do you need? It's also everywhere.");
                case "Ruby":
                    return new Language(dto, "Ruby", 150,
                        "Python's sister language. Shiny ruby.");

                case "Java":
                    return new Language(dto, "Java", 200,
                        "This is not the same as JavaScript, stop calling it JavaScript!");
                case "Kotlin":
                    return new Language(dto, "Kotlin", 300,
                        "You make android apps with this I guess.");
                case "Objective C":
                    return new Language(dto, "Objective C", 75,
                        "Is this outdated?");
                case "Swift":
                    return new Language(dto, "Swift", 250,
                        "Apple language.");

                default:
                    return new Language();
            }
        }

    }
}
