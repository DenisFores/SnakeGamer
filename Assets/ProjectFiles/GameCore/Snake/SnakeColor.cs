using UnityEngine;

public class SnakeColor : MonoBehaviour
{
    public Color currentColor;
    public Renderer rend;
    public GameManager gameManager;

    void Start()
    {
        ApplyColor();
    }

    public void SetColor(Color newColor)
    {
        currentColor = newColor;
        ApplyColor();
    }

    void ApplyColor()
    {
        rend.material.color = currentColor;
    }

    public void Grow()
    {
        GetComponent<SnakeTail>().AddSegment();
    }

    public void GameOver()
    {
        gameManager.GameOver();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            GameOver();
        }
    }
}