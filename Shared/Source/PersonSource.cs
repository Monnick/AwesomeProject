using Shared.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Shared.Source
{
	public sealed class PersonSource
	{
		private List<Person> _personSource;
		private static Lazy<PersonSource> _instance = new Lazy<PersonSource>(() => new PersonSource());

		public static PersonSource Instance { get { return _instance.Value; } }

		private PersonSource()
		{
			_personSource = new List<Person>();

			Initialise();
		}

		private void Initialise()
		{
			EntityLoaded = null;

			var storage = File.ReadAllText(".\\Ressources\\storage_person.json");

			_personSource = new List<Person>(Newtonsoft.Json.JsonConvert.DeserializeObject<Person[]>(storage));
		}

		public Action<Person> EntityLoaded;

		public IEnumerable<Person> People
		{
			get
			{
				for (int i = 0; i < _personSource.Count; i++)
				{
					EntityLoaded?.Invoke(_personSource[i]);

					yield return _personSource[i];
				}
			}
		}
	}
}
