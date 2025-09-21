using UnityEngine;

public class InimigoMov : MonoBehaviour
{
    public static InimigoMov Instance;
    private void Awake()
    {
        Instance = this;
    }

    public float velocidade;
    public float multiplicadorDeDiminuirVelocidade = 1.5f;

    Transform player;

    public float distaociaMaxima = 1f;

    public bool inicoArco = false;

    public bool inimigoEntroEmColisaoComOCenario = false;

    
    Vector2 seguirPlayer;
    public float velocidadePerto = 1.5f;
    public float velocidadeLonge = 3f;
    public float distanciaMaximaParaDiminuirVelocidade = 1.5f;

    public int Spawnou = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player").transform.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {



        float distanciaDoInimigoAoPlayer = Vector2.Distance(player.position, transform.position);
        Vector2 direcao = (player.position - transform.position).normalized;
        if (distanciaDoInimigoAoPlayer <= distanciaMaximaParaDiminuirVelocidade)
        {
            transform.Translate(direcao * velocidadePerto * Time.deltaTime);
        }
        else
        {
            transform.Translate(direcao * velocidadeLonge * Time.deltaTime);
        }
    }

    

}
