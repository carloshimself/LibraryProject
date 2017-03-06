using System;

namespace LibraryProject.Domain.Entities
{
    public class Customer
    {
        public Customer(string firstName, string lastName, DateTime? birthDate, string email, User user)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Email = email;
            User = user;

            //Validações
        }

        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime? BirthDate { get; private set; }
        public string Email { get; private set; }
        public User User { get; private set; }

        public override string ToString()
        {
            return $"{FirstName}{LastName}";
        }
    }
}
