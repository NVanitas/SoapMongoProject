public class User
{
    public string Id { get; set; } = Guid.NewGuid().ToString();  // Alterado para string
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
