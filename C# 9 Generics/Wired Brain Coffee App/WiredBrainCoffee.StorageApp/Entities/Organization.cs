namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Organization : EntitiyBase
    {
        public string? Name { get; set; }

        public override string ToString() => $"ID: {Id}, Name: {Name}";
    }
}
