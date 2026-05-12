using UnityEngine;
using UnityEngine.InputSystem;

public class StoreManager:MonoBehaviour
{
    public GameObject allyPrefab; 
    public Transform spawnPoint;  
    private int unitCount = 0;

    // GameManager나 다른 곳에서 관리하는 로직 연결
    private GameLogic logic = new GameLogic();

    void Update()
    {
        // 'B' 키를 누르면 아군 구매 시도
        if (Keyboard.current.bKey.wasPressedThisFrame)
        {
            BuyAlly();
        }
    }

    void BuyAlly()
    {
        if (logic.TryBuyAlly())
        {
            // 아군 소환
            GameObject newAlly = Instantiate(allyPrefab, spawnPoint.position, Quaternion.identity);
            // 2. 이름을 유니크하게 바꿔줍니다.
            unitCount++;
            newAlly.name = $"Ally_{unitCount}"; // 결과: Ally_1, Ally_2...
            Debug.Log($"아군 구매 성공! 남은 돈: {logic.moneyManagement.money}");
        }
        else
        {
            Debug.Log("돈이 부족합니다!");
        }
    }
}
