using UnityEngine;

public class Mov : MonoBehaviour
{

    public float velocidade;
    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");


        rb.linearVelocity = new Vector3(movX * velocidade, movZ * velocidade);
    }
}
