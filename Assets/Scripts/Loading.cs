using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Loading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(wait());
    }

    public IEnumerator wait()
    {
        Debug.Log("Je change de scene dans 3secondes");
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
