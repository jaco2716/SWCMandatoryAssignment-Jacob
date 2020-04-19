namespace GameFramework.Items
{
    internal class Shield : Item
    {
        public Shield() : base(ItemType.shield, 30)
        {
            DefenceValue = Value;
        }


        public int DefenceValue { get; set; }
    }
}