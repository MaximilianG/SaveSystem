using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;
    public int TotalCoins;

    private void Awake()
    {
        if (Instance)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void addCoin()
    {
        TotalCoins++;
    }

    public int getTotalCoins()
    {
        return TotalCoins;
    }

    public void resetCoins()
    {
        TotalCoins = 0;
    }
}
