using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUpdate : MonoBehaviour
{
    [SerializeField] TMP_Text CoinText;
    [SerializeField] TMP_Text DeathText;

    public void setCoinText(int _coinNumber)
    {
        CoinText.text = "Total Coins : " + _coinNumber.ToString();
    }

    public void setDeathText(int _deathNumber)
    {
        DeathText.text = "Total Deaths : " + _deathNumber.ToString();
    }

    private void Start()
    {
        setCoinText(Inventory.Instance.getTotalCoins());
        setDeathText(PlayerController.Instance.getTotalDeaths());
    }

    private void Update()
    {
        setDeathText(PlayerController.Instance.getTotalDeaths());
        setCoinText(Inventory.Instance.getTotalCoins());
    }
}
