using Chapter5.Library;

using System;
using static System.Console;

Person person = new( "Trung", new DateTime(1969, 6, 9) );
person.FavoriteFood = "Plain Water";
Console.WriteLine(person.AgeProp);
