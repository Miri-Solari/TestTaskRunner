using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float MoneySum {  get => _moneySum;}
    private float _moneySum;

    private void Awake()
    {
        Instance = this;
    }

    public void ChangeSum(float money)
    {
        _moneySum += money;
    }
}
