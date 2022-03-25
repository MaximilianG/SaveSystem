using UnityEngine;
using Unity.IO;
using System.IO;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManage : MonoBehaviour
{
    public static GameManage Instance;

    public int gameTotalCoins;
    public int gameTotalDeaths;
    public int Level1Record;
    public int Level2Record;
    public int Level3Record;


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

        LoadPlayer();
    }

    private void Start()
    {
        LoadPlayer();
    }

    public int getTotalCoins()
    {
        return gameTotalCoins;
    }

    public void addTotalDeath(int _nb)
    {
        gameTotalDeaths += _nb;
    }

    public int getTotalDeaths()
    {
        return gameTotalDeaths;
    }

    public void setLevel1Record(int _nb)
    {
        Level1Record = _nb;
    }

    public int getLevel1Record()
    {
        return Level1Record;
    }

    public void setLevel2Record(int _nb)
    {
        Level2Record = _nb;
    }

    public int getLevel2Record()
    {
        return Level2Record;
    }

    public void setLevel3Record(int _nb)
    {
        Level3Record = _nb;
    }

    public int getLevel3Record()
    {
        return Level3Record;
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        gameTotalCoins = data.TotalCoins;
        gameTotalDeaths = data.TotalDeaths;
        Level1Record = data.Level1_recordCoins;
        Level2Record = data.Level2_recordCoins;
        Level3Record = data.Level3_recordCoins;
    }

       
}
