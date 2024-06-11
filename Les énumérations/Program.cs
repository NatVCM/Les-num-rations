using System.Linq;
using Les_énumérations;

List<User> users = new List<User>();


User firstUser = new User("Campos", "Natacha", ECouleurs.ROUGE);

users.Add(firstUser);

User secondUser = new User("Machado", "Miguel", ECouleurs.BLUE);

users.Add(secondUser);



User thirdUser = new User("Carvalho", "Ruben", ECouleurs.JAUNE);

users.Add(thirdUser);

User fourthUser = new User("Gonçalves", "Maria", ECouleurs.VERT);

users.Add(fourthUser);


User fiftthUser = new User("Pereira", "Ana", ECouleurs.ROUGE);

users.Add(fiftthUser);





foreach (User user in users)
{
    Console.WriteLine("Nom: " + user.Nom + "\n" + "Prenom: " + user.Prenom + "\n" + "Couleur: " + user.Couleur.GetDescription() + "\n");

}






foreach (ECouleurs color in Enum.GetValues(typeof(ECouleurs)))
{




    Console.WriteLine(color);


}

