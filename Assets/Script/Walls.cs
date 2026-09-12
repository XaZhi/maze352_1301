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
    }

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(76, 135, 104, 255);
    }
}
