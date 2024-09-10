using UnityEngine;

public class PaddleSizeAndColour : MonoBehaviour
{
    
    [Header("Colour Change")]
    [SerializeField] private KeyCode colourChange = KeyCode.R;

    private SpriteRenderer spriteRenderer;


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        ChangeColour();
    }
    public void SetPaddleHeight(float xNewScale)
    {
        /*Se hace una ida y vuelta al objeto Vector3 para poder setearle el nuevo valor.
        Primero se lo crea y se le asigna su getter(?), es decir, su estado actual.
        Luego se llama al eje x del objeto vector y se iguala este al parámetro.
        Finalmente, se asigna al valor actual, el nuevo vector con las modificaciones. 
        Se obtiene un nuevo status actual con los valores modificados*/
        Vector3 newVector = transform.localScale;
        newVector.x = xNewScale;
        transform.localScale = newVector;
        /*float xSize;
        xSize = transform.localScale.x + xNewScale;*/

        /*Vector3 xSizeChange = new Vector3(ySize, xNewScale, zSize);*/

        /*Vector3 xSizeChange = new Vector3(xSize, ySize, zSize);
        xSizeChange = transform.localScale.Set(xNewScale, ySize, zSize);*/
    }

    private void ChangeColour()
    {
        if (Input.GetKeyDown(colourChange) || Input.GetKey(colourChange))
        {
            GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }
}
