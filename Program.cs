Console.WriteLine("Digite seu nome");
string name = Console.ReadLine();
Console.WriteLine ($"Olá {name}!");

Console.WriteLine("Digite o ano do seu nascimento:");
int year = int.Parse(Console.ReadLine());
int age = 2022-year;
Console.WriteLine($"Sua idade é {age} anos");

if (age>=18) {

    Console.WriteLine("Portanto você é maior de idade!");
}
else if (age == 17) {
   
    Console.WriteLine("Você está quase lá, mas ainda é de menor");
}
else {
    
    Console.WriteLine("Portanto você é menor de idade!");
}

