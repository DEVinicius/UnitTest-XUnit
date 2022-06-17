using System.Collections.Generic;
using CloudCostumers.API.Models;

namespace CloudCostumers.UnitTests.Fixtures;

public static class UsersFixture
{
    public static List<User> GetTestUsers() => new List<User>()
    {
        new User()
        {
            Name = "Vinicius",
            Address = new Address()
            {
                City = "Teste Endereco",
                Street = "Teste",
                ZipCode = "04836400"
            },
            Email = "teste@gmail.comm",
            Id = 1
        },
        new User()
        {
            Name = "Marcos",
            Address = new Address()
            {
                City = "Teste Endereco Marcos",
                Street = "Teste Marcos",
                ZipCode = "04836400"
            },
            Email = "marcos@gmail.comm",
            Id = 2
        },
        new User()
        {
            Name = "Diego",
            Address = new Address()
            {
                City = "Teste Endereco Diego",
                Street = "Teste Diego",
                ZipCode = "04836400"
            },
            Email = "diego@gmail.comm",
            Id = 3
        }
    };
}