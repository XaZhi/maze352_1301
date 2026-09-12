using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();

        if (player == null)
            return;

        UIManager.instance.ShowNotiText($"You WIN!\nPoint : {player.Point}");
    }
}
