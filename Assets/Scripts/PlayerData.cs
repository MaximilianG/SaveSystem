using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int TotalCoins;
    public int TotalDeaths;

    public int Level1_recordCoins;
    public int Level2_recordCoins;
    public int Level3_recordCoins;

    public PlayerData (GameManage _gameManager)
    {
        TotalCoins = _gameManager.gameTotalCoins;
        TotalDeaths = _gameManager.gameTotalDeaths;
        Level1_recordCoins = _gameManager.Level1Record;
        Level2_recordCoins = _gameManager.Level2Record;
        Level3_recordCoins = _gameManager.Level3Record;
    }

    public PlayerData (int un, int deux, int trois, int quatre, int cinq)
    {
        TotalCoins = un;
        TotalDeaths = deux;
        Level1_recordCoins = trois;
        Level2_recordCoins = quatre;
        Level3_recordCoins = cinq;
    }
}
