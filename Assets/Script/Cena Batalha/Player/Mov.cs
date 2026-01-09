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
        if (rb == null)
        {
            Debug.LogWarning("Rigidbody não encontrado no objeto Player. Adicione um Rigidbody para que o movimento funcione.");
            return; // Sai do método se não houver Rigidbody
        }

        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");


        rb.linearVelocity = new Vector3(movX * velocidade, movZ * velocidade);
    }
}
