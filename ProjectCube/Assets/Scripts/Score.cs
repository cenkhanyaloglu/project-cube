using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Text timeText;
    [SerializeField]
    private Text distanceText;
    [SerializeField]
    private Transform playerCollider;
    [SerializeField]
    private GameManager gameManager;

    void Update()
    {
        if (gameManager.isGameEnded == false)
        {
            timeText.text = Time.time.ToString("00.00");
            distanceText.text = playerCollider.position.z.ToString("0");
        }
    }
}
