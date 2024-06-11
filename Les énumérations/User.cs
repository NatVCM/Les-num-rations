using System;
namespace Les_énumérations
{
	public class User
	{

		public string Nom { get; set; }

		public string Prenom { get; set; }

		
		public ECouleurs Couleur { get; set; }




		public User(string nom, string prenom , ECouleurs couleur  )
		{

			Nom = nom;
			Prenom = prenom;
			Couleur = couleur;

		}
	}
}

