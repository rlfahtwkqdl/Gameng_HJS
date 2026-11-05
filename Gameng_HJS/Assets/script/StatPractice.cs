using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string playerName = "김두한";
    public int level = 1972;
    public float attack = 1121f;
    public bool isBoss = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [ContextMenu("오늘 널 단죄하러 왔다")]
    void Sayname()
    {
        Debug.Log(playerName);

         Debug.Log(level);

         Debug.Log(attack);

         Debug.Log(isBoss);
    }


    [ContextMenu("김두한은 쓰러졌다")]
    void Level()
    {
        Debug.Log(level);
    }

    [ContextMenu("발터38 발사")]
    void Attack()
    {
        Debug.Log(attack);
    }

    [ContextMenu("여기가 어디오")]
    void Isboos()
    {
        Debug.Log(isBoss);
    }
}
