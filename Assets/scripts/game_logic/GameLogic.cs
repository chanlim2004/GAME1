using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class GameLogic // 게임로직 클라스
{
    //Money 관리
    public struct MoneyManagement
    {
        public int money;
        public int allyPrice;
    }
    
    //Enemy 관리
    public struct EnemyHP
    {
        public int basicEnemyHP; // 기본 몹 체력
        public int bossEnemyHP;  // 보스 몹 체력(필요하면)
    }
    public struct EnemyName
    {
        public string basicEnemyName;
        public string bossName;
    }
    public struct EnemyAttack
    {
        public int basicEnemyAttack;
    }
    //Ally 관리
    public struct AllyHP
    {
        public int basicAllyHP;
    }
    public struct AllyName
    {
        public string basicAllyName;
    }
    public struct AllyAttack
    {
        public int basicAllyAttack;
    }

    //실제로 사용할 변수를 선언합니다
    public EnemyHP enemyHP;
    public EnemyName enemyName;
    public EnemyAttack enemyAttack;

    public AllyHP allyHP;
    public AllyName allyName;
    public AllyAttack allyAttack;

    public MoneyManagement moneyManagement;

    public void EnemyManager()
    {
        this.enemyHP.basicEnemyHP = 100;
        this.enemyName.basicEnemyName = "BasicEnemy";
        this.enemyAttack.basicEnemyAttack = 25;
    }
    public void AllyManager()
    {
        this.allyHP.basicAllyHP = 100;
        this.allyName.basicAllyName = "BasicAlly";
        this.allyAttack.basicAllyAttack = 25;
    }
    public void MoneyManager() 
    {
        this.moneyManagement.money = 1000;
        this.moneyManagement.allyPrice = 100;
    }
    public GameLogic()
    { 
        AllyManager();
        EnemyManager();
        MoneyManager();
    }
    public bool TryBuyAlly()
    {
        if (moneyManagement.money >= moneyManagement.allyPrice)
        {
            moneyManagement.money -= moneyManagement.allyPrice ;
            return true; // 구매 성공
        }
        return false; // 돈 부족
    }
}

