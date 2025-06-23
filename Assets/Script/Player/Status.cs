using UnityEngine;

public class Status : MonoBehaviour
{
    public static Status instance;

    void Awake()
    {
        instance = this;
    }

    public float vidaAtual;

    public float vidaMaxima = 25f;

    public void MortePlayer()
    {
        if(vidaAtual <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vidaAtual = vidaMaxima;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
