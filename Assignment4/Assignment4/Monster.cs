using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class Monster
    {
        public string Name { get; private set; }
        public EElementType ElementType { get; private set; }
        public int Health { get; private set; }
        public int AttackStat { get; private set; }
        public int DefenseStat { get; private set; }

        public Monster(string name, EElementType elementType, int health, int attack, int defense)
        {
            Name = name;
            ElementType = elementType;
            Health = health;
            AttackStat = attack;
            DefenseStat = defense;
        }
        public void TakeDamage(int amount)
        {
            Health -= amount;
            if (Health < 0)
            {
                Health = 0;
            }
        }
        public void Attack(Monster otherMonster)
        {
            int damage = AttackStat - otherMonster.DefenseStat;
            int incompatibility = GetIncompatibility(ElementType, otherMonster.ElementType);
            if (incompatibility == 1)
            {
                damage = (int)(damage * 1.5);
            }
            else if (incompatibility == -1)
            {
                damage = (int)(damage * 0.5);
            }
            if (damage < 1)
            {
                damage = 1;
            }
            otherMonster.TakeDamage(damage);

        }

        public static int GetIncompatibility(EElementType eElementType, EElementType eElementTypeOther)
        {
            int result = 0;
            byte b = (byte)(int)eElementType;
            byte bOther = (byte)(int)eElementTypeOther;
            int flag = b | bOther;
            if (b == 1)
            {
                if (flag == 5)
                {
                    result++;
                }
                else if (flag == 9 || flag == 3)
                {
                    result--;
                }
            }
            else if (b == 2)
            {
                if (flag == 3)
                {
                    result++;
                }
                else if (flag == 6)
                {
                    result--;
                }
            }
            else if (b == 4)
            {
                if (flag == 12 || flag == 6)
                {
                    result++;
                }
                else if (flag == 5)
                {
                    result--;
                }
            }
            else if (b == 8)
            {
                if (flag == 9)
                {
                    result++;
                }
                else if (flag == 12)
                {
                    result--;
                }
            }
            return result;
        }
    }
    
}
