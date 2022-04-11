namespace TheGame
{
    public abstract class LivingBeing
    {
        public string Name;
        public int Level;
        public int maxHealth;
        public int currentHealth;
        public string Attack;
        public int ArmorClass;
        public string Technique;
        public int attackRollModifier;

        public void takeDamage(int DamageAmount)
        {
            this.currentHealth -= DamageAmount;
        }
        public int getArmorClass()
        {
            return this.ArmorClass;
        }
        public int getHP()
        {
            return this.currentHealth;
        }

        public string getAttackRoll()
        {
            return this.Attack;
        }

        public int getAttackRollModifier()
        {
            return this.attackRollModifier;
        }
    }
}
