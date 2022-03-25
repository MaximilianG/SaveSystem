using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    public int TotalDeaths;

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

    public void Respawn(GameObject _player, GameObject _target)
    {
        _player.transform.position = _target.transform.position;
    }

    public void addDeath()
    {
        TotalDeaths++;
    }

    public int getTotalDeaths()
    {
        return TotalDeaths;
    }

    public void resetDeaths()
    {
        TotalDeaths = 0;
    }
}
