using MongoDB.Driver;
using SoapMongoProject.Models;
using SoapMongoProject.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IMongoCollection<User> _users;

    public UserRepository(IMongoClient mongoClient)
    {
        var database = mongoClient.GetDatabase("SoapMongoDB");
        _users = database.GetCollection<User>("Users");

        AddTestUser();  // Chama o método ao inicializar o repositório
    }

    public List<User> GetUsers()
    {
        return _users.Find(user => true).ToList();
    }

    // Método para adicionar um usuário de teste
    public void AddTestUser()
    {
        var testUser = new User
        {
            Id = Guid.NewGuid().ToString(),  // Convertendo o Guid para string
            Name = "Test User",
            Email = "testuser@example.com"
        };

        _users.InsertOne(testUser);
    }

}
