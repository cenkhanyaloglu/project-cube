using UnityEngine;
using UnityEngine.UI;

public class MenuColor : MonoBehaviour
{
    [SerializeField]
    private Image background;

    private float timeLeft;
    private Color tempColor;

    void Update()
    {
        if (timeLeft <= Time.deltaTime)
        {
            background.material.color = tempColor;
            tempColor = new Color(Random.value, Random.value, Random.value);
            timeLeft = 1.0f;
        }
        else
        {
            background.material.color = Color.Lerp(background.material.color, tempColor, Time.deltaTime / timeLeft);
            timeLeft -= Time.deltaTime;
        }
    }
}
