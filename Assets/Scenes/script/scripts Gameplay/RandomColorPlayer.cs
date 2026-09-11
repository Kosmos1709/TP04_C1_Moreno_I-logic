
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RandomColorPlayer : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private SpriteRenderer player;
   

    private void Awake()
    {
        player.AddComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == ball)
        {
            ChangeColor();
        }
    }
    void Start()
    {
        
    }
    private void ChangeColor()
    {
        float r = Random.value;
        float g = Random.value;
        float b = Random.value;
        player.color = new Color(r, g, b);
    }
    void Update()
    {
        
    }
}
