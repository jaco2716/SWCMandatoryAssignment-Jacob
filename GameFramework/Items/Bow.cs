namespace GameFramework.Items
{
    internal class Bow : Weapons
    {
        private int damage;
        public Bow() : base(ItemType.bow, 15, 2)
        {
            damage = 15;
        }

        public override int GetDamage()
        {
            return base.GetDamage();
        }
    }
}