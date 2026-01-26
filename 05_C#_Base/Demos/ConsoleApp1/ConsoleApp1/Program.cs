
using ConsoleApp1.entity;
using ConsoleApp1.repo;

User user = new User(null, "toto", "test@test.com", 30);

UserRepo.Insert(user);

Console.WriteLine(UserRepo.GetByName("toto"));
Console.WriteLine();
