using UnityEngine;

public class Coin : ItemRamassable
{
    protected override void Comportement()
    {
        Inventory.Instance.addCoin();
        Destroy(gameObject);
    }
}
