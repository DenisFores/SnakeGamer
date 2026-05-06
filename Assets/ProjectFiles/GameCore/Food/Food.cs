using UnityEngine;

public class Food : MonoBehaviour
{
    public Color foodColor;

    private void OnTriggerEnter(Collider other)
    {
        SnakeTail tail = other.GetComponent<SnakeTail>();
        SnakeColor snake = other.GetComponent<SnakeColor>();

        if (snake == null) return;

        if (snake.currentColor == foodColor)
        {
            tail.AddSegment();
            Destroy(gameObject);
        }
        else
        {
            snake.GameOver();
        }
    }
}