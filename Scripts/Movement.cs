
using TMPro;
using UnityEngine;

public class Movement : MonoBehaviour
{   
    [SerializeField] private float jumpPower;
   

    private Rigidbody2D body;
    private SpriteRenderer sr;
    public string currentColor;
     
    public Color red;
    public Color blue;
    public Color yellow;
    public Color Pink;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }
  
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.velocity = new Vector2(body.velocity.x, jumpPower);
        }
      

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ColorChangerRed")
        {
            currentColor = "red";
            sr.color = red;
     
        }
        if (collision.tag == "ColorChangerBlue")
        {
            currentColor = "blue";
            sr.color = blue;
           
        }
        if (collision.tag == "ColorChangerYellow")
        {
            currentColor = "Yellow";
            sr.color = yellow;
           
        }
        if (collision.tag == "ColorChangerPink")
        {
            currentColor = "Pink";
            sr.color = Pink;
            
        }
       
    }

}
