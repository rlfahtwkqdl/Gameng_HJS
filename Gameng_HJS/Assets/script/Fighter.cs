using UnityEngine;

public class Fighter
{
    public string name;
    public int hp;
    public int attack;
    public int defense;

    public Fighter(string name, int hp, int attack, int defense)
    {
        this.name = name;
        this.hp = hp;
        this.attack = attack;
        this.defense = defense;
    }

    public int GetDamageTo(Fighter target)
    {
        if (attack <= target.defense)
        {
            int damage = 1;
            return damage;
        }
        else
        {
            int damage = (int) (attack - target.defense);
            return damage;
        }
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0) { hp = 0;}

    }

    public bool IsDead()
    {
        if (hp <= 0) return true;

        return false;
    }

}
