using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    TMP_Text CoinText, DeathText, RecordLevel1Text, RecordLevel2Text, RecordLevel3Text;

    public Button[] ButtonTab;

    public void setCoinText(int _coinNumber)
    {
        CoinText.text = "Total Coins : " + _coinNumber.ToString();
    }

    public void setDeathText(int _deathNumber)
    {
        DeathText.text = "Total Deaths : " + _deathNumber.ToString();
    }

    public void setRecord1Text(int _recordValue)
    {
        RecordLevel1Text.text = "Record : " + _recordValue.ToString();
    }

    public void setRecord2Text(int _recordValue)
    {
        RecordLevel2Text.text = "Record : " + _recordValue.ToString();
    }

    public void setRecord3Text(int _recordValue)
    {
        RecordLevel3Text.text = "Record : " + _recordValue.ToString();
    }

    private void Start()
    {
        GameManage.Instance.gameTotalCoins = GameManage.Instance.getLevel1Record() + GameManage.Instance.getLevel2Record() + GameManage.Instance.getLevel3Record();

        setCoinText(GameManage.Instance.getTotalCoins());
        setDeathText(GameManage.Instance.getTotalDeaths());
        setRecord1Text(GameManage.Instance.getLevel1Record());
        setRecord2Text(GameManage.Instance.getLevel2Record());
        setRecord3Text(GameManage.Instance.getLevel3Record());
    }


    private void Update()
    {
        for (int i = 0; i < ButtonTab.Length; i++)
        {
            if (GameManage.Instance.getTotalCoins() > 5 && i==1)
                ButtonTab[1].interactable = true;

            if (GameManage.Instance.getTotalCoins() > 11 && i==2)
                ButtonTab[2].interactable = true;

        }
    }

}
