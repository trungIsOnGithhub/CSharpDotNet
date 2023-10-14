using System;
using System.Collections.Generic;

namespace Chapter5.Library
{
	public class Person : Object //explicitly inheritance - alias : object
	{
		private readonly string name;
		private readonly DateTime birthDate;
		public List<Person> Children;
		
		public Person(string _name, DateTime _birthDate)
		{
			this.name = _name;
			this.birthDate = _birthDate;
			this.Children = new List<>();
		}

		public string FavoriteFood{ get; set; }
		
		// <= C#5 Syntax Properties
		public string NameProp
		{
			get { return this.name; }
		}
		
		// > C#5 Syntax Properties
		public DateTime BirthDateProp
		{
			get => this.birthDate;
		}
		public int AgeProp
		{
			get => (System.DateTime.Today.Year - this.birthDate.Year);
		}

		public void Greeting()
		{
			Console.WriteLine( String.Format("Hello Everyone, I was born on {0: dd MM yyy}", arg0: this.birthDate) );
		}
		
		public override string ToString()
		{
			return String.Format(format: "I am {0}", arg0: this.name);	
		}
	}
}
