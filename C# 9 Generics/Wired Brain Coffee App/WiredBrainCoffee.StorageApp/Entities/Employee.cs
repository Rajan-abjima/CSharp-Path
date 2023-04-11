namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Employee : EntitiyBase
    {
        public string? FirstName { get; set; }

        public override string ToString() => $"ID: {Id}, FirstName: {FirstName}";
    }
}
