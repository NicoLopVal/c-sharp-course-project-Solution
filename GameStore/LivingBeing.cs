namespace TheGame
{
    public abstract class LivingBeing
    {
        public string Name;
        public int Level;
        public int Health;
        public int Attack;
        public int ArmorClass;
        public string Technique;

        public void takeDamage(int DamageAmount)
        {
            this.Health -= DamageAmount;
        }
        public int getArmorClass()
        {
            return this.ArmorClass;
        }
    }
}
