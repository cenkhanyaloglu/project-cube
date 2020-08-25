using UnityEngine;
using PlayerAttributes;

public class EndTrigger : MonoBehaviour
{
    [SerializeField]
    private PlayerMovement movement;
    [SerializeField]
    private Score score;
    [SerializeField]
    private GameObject levelCompleteUI;
    [SerializeField]
    private GameObject sound;

    private void OnTriggerEnter(Collider other)
    {
        movement.enabled = false;
        score.enabled = false;
        sound.SetActive(false);

        levelCompleteUI.SetActive(true);
    }
}
