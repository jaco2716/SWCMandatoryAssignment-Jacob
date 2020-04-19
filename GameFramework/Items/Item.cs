namespace GameFramework.Items
{
    public abstract class Item
    {
        public Item(ItemType type, int value)
        {
            Type = type;

            Value = value;
        }

        public ItemType Type { get; set; }
        public int Value { get; set; }
    }
}