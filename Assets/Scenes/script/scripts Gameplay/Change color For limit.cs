using UnityEngine;

// Warning: el archivo se llama 'Change color For limit.cs' y la clase Change_color_For_limit. En Gameplay.unity los dos componentes que lo usan todavía guardan m_EditorClassIdentifier: Assembly-CSharp::NewMonoBehaviourScript, que es el nombre viejo del archivo.
// Abrí la escena en Unity y verificá que los dos componentes no aparezcan como Missing Script. Renombrá archivo y clase a ChangeColorForLimit, desde el Project de Unity.
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
                // Warning: OnCollisionStay2D se ejecuta en cada frame de física mientras la paleta toque el límite, y en cada uno pedís GetComponent<Renderer>() y accedés a .material, que la primera vez clona el material.
                // Cacheá el SpriteRenderer en el Awake y usá .color, no .material.color.
                playercolor.GetComponent<Renderer>().material.color = Color.black;
            }
        }


        void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.gameObject == TopLimit || collision.gameObject == BottomLimit)
            {
                // Bug: al salir del límite el color vuelve a blanco fijo, así que se pierde el color aleatorio que RandomColorPlayer le puso a la paleta al golpear la pelota (y también el que el jugador eligió con los botones de SLiderRGB).
                // Guardá el color que tenía antes de pintar de negro y restaurá ese, en vez de asumir blanco. Ojo también con que este script usa Renderer.material.color y RandomColorPlayer usa SpriteRenderer.color: son dos caminos distintos para lo mismo.
                playercolor.GetComponent<Renderer>().material.color = Color.white;
            }
        }
   
    void Update()
    {
       
    }
}
