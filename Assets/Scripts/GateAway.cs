using UnityEngine;
using UnityEngine.SceneManagement;

public class GateAway : ItemRamassable
{
    public int level_id;

    protected override void Comportement()
    {               
        if (level_id == 1 && Inventory.Instance.getTotalCoins() > GameManage.Instance.getLevel1Record())
        {
            GameManage.Instance.setLevel1Record(Inventory.Instance.getTotalCoins());
        }
        else if (level_id == 2 && Inventory.Instance.getTotalCoins() > GameManage.Instance.getLevel2Record())
        {
            GameManage.Instance.setLevel2Record(Inventory.Instance.getTotalCoins());
        }
        else if (level_id == 3 && Inventory.Instance.getTotalCoins() > GameManage.Instance.getLevel3Record())
        {
            GameManage.Instance.setLevel3Record(Inventory.Instance.getTotalCoins());
        }

        GameManage.Instance.addTotalDeath(PlayerController.Instance.getTotalDeaths());

        GameManage.Instance.SavePlayer();

        SceneManager.LoadScene(0);
        Inventory.Instance.resetCoins();
        PlayerController.Instance.resetDeaths();
    }

}
