namespace Core.VOs
{
    public class Phone
    {
        public string _number;
        
        private Phone(string number)
        {
            _number = number;
        }

        public static Phone Create(string number)
        {
            // TODO: Validate and return Result Pattern in case Error. EB 10/04/2025
            return new Phone(number);
        }

        public override bool Equals(object? obj)
        {
            return obj is Phone phone &&
                   _number == phone._number;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_number);
        }

        public override string ToString() => _number;
    }
}
