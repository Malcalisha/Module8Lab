//Using directives - these import existing code from the .NET framework
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

// //Create a new Pokemon class (this is a blueprint for a object)
class Pokemon
{
     //Declare the attributes for the class
 public int Id {get; set;}
public string Name {get; set;}
public string Type {get; set;}
public int Level {get; set;}
} // end class

// This class contains the main method (the main method is called when the program runs)
class PokemonLINQLab {
    static void Main() {
        // Sample data: list of Pokemon
        var pokemons = new List<Pokemon>
        {
            new Pokemon { Id =1, Name = "Bulbasaur", Type = "Grass", Level = 15},
            new Pokemon { Id = 2, Name = "Charmander",Type ="Fire", Level =36},
            new Pokemon { Id = 3, Name = "Squirtle", Type = "Water", Level = 10},
            new Pokemon { Id= 4, Name = "Pikachu", Type = "Electric", Level = 22},
            new Pokemon { Id =5, Name = "Eevee", Type = "Normal", Level = 25},
        };

        //LINQ Query to find the Pokemon to evovle
        var readyToEvolveQuery = from p in pokemons
                                where p.Level >=16
                                orderby p.Level
                                select p;
                            
        // Execute te query & display the results
        Console.WriteLine("Pokemon Ready to Evolve:");

        //Loop through the resultset of objects that the query returned
        foreach (var pokemon in readyToEvolveQuery){
            Console.WriteLine($"Name: {pokemon.Name}, Type: {pokemon.Type}, Level: {pokemon.Level}");
        } //end for each loop
        

        }
}
