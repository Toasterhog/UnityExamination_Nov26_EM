using UnityEngine;

public class HatPickup : MonoBehaviour
{
    public GameObject Player;

    public GameObject Hat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPickup()
    {
        GameObject hat = Instantiate(Hat, Player.transform.position, Player.transform.rotation);
        hat.SetActive(true);
    }
}
