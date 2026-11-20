using UnityEngine;

public class HatPickup : MonoBehaviour
{
    public GameObject Player = default;

    public GameObject HatSprite = new GameObject();
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
        if (HatSprite is null || Player is null) return;
        GameObject hat = Instantiate(
            HatSprite,
            Player.transform.position,
            Player.transform.rotation,
            Player.transform
        );
        hat.transform.localPosition = new Vector3(0, 1, 0);
        hat.SetActive(true);
    }
}
