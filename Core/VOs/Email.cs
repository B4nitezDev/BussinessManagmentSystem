namespace Core.VOs
{
    public class Email
    {
        public string _email;


        private Email(string email)
        {
            _email = email;
        }

        public static Email Create(string email)
        {
            // TODO: Validate and return Result Pattern in case Error. EB 10/04/2025
            
            
            return new Email(email);
        }
        
        public override string ToString() => _email;
        
        public override int GetHashCode()
        {
            return HashCode.Combine(_email);
        }
        
        public override bool Equals(object? obj)
        {
            return obj is Email email &&
                   _email == email._email;
        }
    }
}
