using UnityEngine;

public class Bala : MonoBehaviour
{
    public static Bala Instance;

    private void Awake()
    {
        Instance = this;
    }

    StatusInimigo statusInimigo;

    public float tempoDeVida;
    public float velocidade;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, tempoDeVida);
    }

    public void FixedUpdate()
    {
        transform.Translate(transform.up * velocidade * Time.deltaTime, Space.World);
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.collider.CompareTag("Inimigo"))
        {
            Destroy(gameObject);
        }
    }
}
