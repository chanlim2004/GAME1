using UnityEngine;

public class Ally:MonoBehaviour
{
    public GameLogic logic = new GameLogic();
    protected int AllyHealth;
    protected int AllyAttack;
    protected string AllyName;

    protected virtual void Awake()
    {
        // logic 안에 있는 데이터를 내 변수에 복사
        this.AllyHealth = logic.allyHP.basicAllyHP;
        this.AllyAttack = logic.allyAttack.basicAllyAttack;
        this.AllyName = logic.allyName.basicAllyName;
    }
    protected virtual void Start()
    {
        Debug.Log($"아군 이름: {AllyName}, 체력: {AllyHealth}, 공격력: {AllyAttack}");
    }
}
