using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();

        if (player == null)
            return;

        player.Point += 10;
        UIManager.instance.ShowNotiText($"Get Coin +10\nPoint : {player.Point}");
        Destroy(gameObject);
    }
}
