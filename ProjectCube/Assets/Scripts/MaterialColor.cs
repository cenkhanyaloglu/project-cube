using UnityEngine;

public class MaterialColor : MonoBehaviour
{
    [SerializeField]
    private Material material;

    private float timeLeft;
    private Color tempColor;

    void Update()
    {
        if (timeLeft <= Time.deltaTime)
        {
            material.color = tempColor;
            tempColor = new Color(Random.value, Random.value, Random.value);
            timeLeft = 1.0f;
        }
        else
        {
            material.color = Color.Lerp(material.color, tempColor, Time.deltaTime / timeLeft);
            timeLeft -= Time.deltaTime;
        }
    }
}
