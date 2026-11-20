// using UnityEngine;
//
// public class HatPickup : MonoBehaviour
// {
//     public GameObject Player;
//     public GameObject HatSprite;
//     
//     public float baseHeight = 1.0f;    // Height of the very first hat
//     public float heightPerHat = 0.4f;  // Extra height added for each hat already worn
//     public GameObject text;
//     
//     public void OnPickup()
//     {
//         Debug.Log("Picked up hat");
//         if (HatSprite == null || Player == null) return;
//
//         // 1. Count how many existing hats are already children of the Player
//         int existingHatCount = -1;
//         foreach (Transform child in Player.transform)
//         {
//             if (true || child.CompareTag("Hat"))
//             {
//                 existingHatCount++;
//             }
//         }
//         Debug.Log("existingHatCount "+ existingHatCount);
//
//         // 2. Instantiate the new hat as a child of the Player
//         GameObject hat = Instantiate(
//             HatSprite,
//             Player.transform.position,
//             Player.transform.rotation,
//             Player.transform
//         );
//
//         // 3. Calculate the stacked Y position and apply it
//         float stackedY = baseHeight + (existingHatCount * heightPerHat);
//         hat.transform.localPosition = new Vector3(0f, stackedY, 0f);
//         hat.SetActive(true);
//     }
// }

using UnityEngine;
using TMPro; // Required for TextMeshPro UI

public class HatPickup : MonoBehaviour
{
    public GameObject Player;
    public GameObject HatSprite;
    public TMP_Text hatCountText; // Drag your UI TextMeshPro object here

    public float baseHeight = 1.0f;
    public float heightPerHat = 0.4f;

    public void OnPickup()
    {
        if (HatSprite == null || Player == null) return;

        // 1. Count existing hats
        int existingHatCount = -1;
         foreach (Transform child in Player.transform)
         {
             if (true || child.CompareTag("Hat"))
             {
                 existingHatCount++;
             }
         }
         Debug.Log("existingHatCount "+ existingHatCount);

        // 2. Spawn and stack the new hat
        GameObject hat = Instantiate(
            HatSprite,
            Player.transform.position,
            Player.transform.rotation,
            Player.transform
        );

        float stackedY = baseHeight + (existingHatCount * heightPerHat);
        hat.transform.localPosition = new Vector3(0f, stackedY, 0f);
        hat.SetActive(true);

        // 3. Update the UI text (existing hats + the 1 just picked up)
        int totalHats = existingHatCount ;
        if (hatCountText != null)
        {
            hatCountText.text = "Hats: " + totalHats;
        }
    }
}
