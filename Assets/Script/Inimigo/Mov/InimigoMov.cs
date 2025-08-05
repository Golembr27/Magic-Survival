using UnityEngine;

public class InimigoMov : MonoBehaviour
{
    public static InimigoMov Instance;
    private void Awake()
    {
        Instance = this;
    }

    public float velocidade;

    Transform player;

    float distaociaMaxima = 5f;

    public bool inicoArco = false;

    Vector2 seguirPlayer;

    public int Spawnou = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player").transform.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(inicoArco == true)
        {
            float distancia = Vector2.Distance(player.transform.position, transform.position);
            if(distancia <= distaociaMaxima)
            {
                seguirPlayer = (player.position + transform.position).normalized;
            }
        }
        seguirPlayer = (player.position - transform.position).normalized;
        transform.Translate(seguirPlayer * velocidade * Time.deltaTime);
    }
}
