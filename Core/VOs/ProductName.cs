namespace Core.VOs
{
    public class ProductName
    {
        public string _name;

        private ProductName(string name)
        {
            _name = name;
        }

        public static ProductName Create(string name)
        {
            // TODO: Validate and return Result Pattern in case Error. EB 10/04/2025

            
            return new ProductName(name);
        }
        
        public override string ToString() => _name;

        public override int GetHashCode()
        {
            return HashCode.Combine(_name);
        }

        public override bool Equals(object? obj)
        {
            return obj is ProductName productName &&
                   _name == productName._name;
        }
    }
}
