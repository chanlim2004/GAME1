using UnityEngine;

public class Enemy:MonoBehaviour
{
    public GameLogic logic = new GameLogic();
    protected int enemyHealth;
    protected int enemyAttack;
    protected string enemyName;

    // 유니티에서는 생성자 대신 Awake나 Start에서 값을 할당합니다.
    protected virtual void Awake()
    {
        // logic 안에 있는 데이터를 내 변수에 복사
        this.enemyHealth = logic.enemyHP.basicEnemyHP;
        this.enemyAttack = logic.enemyAttack.basicEnemyAttack;
        this.enemyName = logic.enemyName.basicEnemyName;
    }
    protected virtual void Start()
    {
        Debug.Log($"적 이름: {enemyName}, 체력: {enemyHealth}, 공격력: {enemyAttack}");
    }

}
