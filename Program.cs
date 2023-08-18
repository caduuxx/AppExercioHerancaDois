using AppExercioHerancaDois.Dominio;
using System.Runtime.CompilerServices;

Animal animal = new Animal();
Cachorro cachorro = new Cachorro();
Gato gato = new Gato();

Console.WriteLine("qual a raça do seu cachorro");
cachorro.Raça = Console.ReadLine();
Console.WriteLine("qual o nome do seu Cachorro");
cachorro.Nome = Console.ReadLine();

Console.WriteLine("qual a raça do seu gato");
gato.Raça = Console.ReadLine();
Console.WriteLine("qual o nome do seu gato");
gato.Nome = Console.ReadLine();

