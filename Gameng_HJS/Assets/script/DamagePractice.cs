using UnityEngine;

public class DamagePractice : MonoBehaviour
{

     public int attack = 10;
        public int defense = 5;
        public bool isCritical = true;
        public bool targetIsBoss = true;
        public int height = 3;

    
    [ContextMenu("데미지")]
    void Calc()
    {
       

        int DAtt = (attack-defense);

        if (DAtt < 1)
        {
            DAtt = 1;
        }



        if (isCritical)
        {
            DAtt = DAtt * 2;
        }
        if (targetIsBoss)
        {
            DAtt = DAtt / 2;
        }

        Debug.Log(DAtt);
    }

    [ContextMenu("계단")]
    void Stairs()
    {
        int height = 3;
        string result = "";
        for (int row = 1; row <= height; row++)
        {
            for (int col = 0; col < row ; col++)
            {
                result += "*";
            }
            result += "\n";
        }
        Debug.Log(result);
    }

}
