using UnityEngine;

public class Walls : MonoBehaviour
{
    private MeshRenderer rd;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.red;

        Player player = collision.gameObject.GetComponent<Player>();

        if (player == null)
            return;

        player.Hp -= 10;
        UIManager.instance.ShowNotiText($"Hurt -10\nHP : {player.Hp}");

        if (player.Hp <= 0)
        {
            player.Hp = 0;
            UIManager.instance.ShowNotiText($"Game Over\nPoint : {player.Point}");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(76, 135, 104, 255);
    }
}
