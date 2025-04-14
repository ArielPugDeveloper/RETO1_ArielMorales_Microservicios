namespace CleanArchitecture.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }

        public User(string name, string email)
        {
            if (!email.Contains("@"))
                throw new ArgumentException("Email inválido");

            Id = Guid.NewGuid();
            Name = name;
            Email = email;
        }
    }
}
