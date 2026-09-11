using UnityEngine;

public class Change_color_For_limit : MonoBehaviour
{

    [SerializeField] private GameObject TopLimit;
    [SerializeField] private GameObject BottomLimit;
    [SerializeField] private GameObject playercolor;



    private void Awake()
    {
    }

    void Start()
    {
        
    }

        void OnCollisionStay2D(Collision2D collision)
        {
            if (collision.gameObject == TopLimit || collision.gameObject == BottomLimit)
            { 
                playercolor.GetComponent<Renderer>().material.color = Color.black;
            }
        }


        void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.gameObject == TopLimit || collision.gameObject == BottomLimit)
            {
                playercolor.GetComponent<Renderer>().material.color = Color.white;
            }
        }
   
    void Update()
    {
       
    }
}
