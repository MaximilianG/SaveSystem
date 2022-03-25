using UnityEngine;

public abstract class ItemRamassable : MonoBehaviour
{
    protected UIManager uiManager;
    protected GameUpdate gameUpdate;
    protected virtual void Comportement()
    {
        Debug.Log("New comportement");
    }

    private void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
        gameUpdate = FindObjectOfType<GameUpdate>();
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Comportement();
        }
    }
}
