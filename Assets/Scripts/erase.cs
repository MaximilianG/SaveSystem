using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class erase : MonoBehaviour
{
    public void EraseSave()
    {
        SaveSystem.EraseSave(0, 0, 0, 0, 0);

        GameManage.Instance.LoadPlayer();
        SceneManager.LoadScene(4);
    }
}
