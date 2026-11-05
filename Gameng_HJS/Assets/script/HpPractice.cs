using UnityEngine;

public class HpPractice : MonoBehaviour
{
    public int currentHp = 7;
    public int maxHp = 10;
    
    
    [ContextMenu("체력")]
    void PrintHp()
    {
        Debug.Log("HP" + (100/maxHp*currentHp) +"%");
    }
}
