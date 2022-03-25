using UnityEngine;

public class Spikes : ItemRamassable
{
    public GameObject RespawnPos;
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController.Instance.addDeath();         
            PlayerController.Instance.Respawn(collision.gameObject, RespawnPos);
        }
    }
}
