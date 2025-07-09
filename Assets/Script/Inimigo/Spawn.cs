using TMPro;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    public static Spawn instance;

    private void Awake()
    {
        instance = this;
    }

    TextMeshProUGUI fasesText;
    BoxCollider2D play;
    public bool faseIni = false;
    public GameObject inimigo;
    public Transform spawnTR;
    public int quantInimigo = 0;
    public int quantIniAtual = 0;
    public int fases;
    public int quantInMax;

    void spawn()
    {
        if (faseIni == true && quantInimigo < quantInMax)
        {
            quantInimigo++;
            Instantiate(inimigo, spawnTR.position, spawnTR.rotation);
            spawn();
            return;
        }
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Player"))
        {
            faseIni = true;
            spawn();
        }
    }

    public void Fases()
    {
        if (quantIniAtual == quantInMax)
        {
            Status.Instance.vidaAtual = Status.Instance.vidaMaxima;
            Status.Instance.manaAtual = Status.Instance.manaMaxima;
            //SlotsDasCartas.Instance.objetoSpawnado = 1;
            SlotsDasCartas.Instance.CartaAleatoria();
            quantIniAtual = 0;
            quantInMax += 2;
            quantInimigo = 0;
            faseIni = false;
            fases++;
            fasesText.text = ($"{fases}");
        }
    }

    private void Start()
    {
        play  = GameObject.Find("Play").transform.GetComponent<BoxCollider2D>();
        fasesText = GameObject.Find("Canvas").transform.Find("Fases").transform.Find("Fase").GetComponent<TextMeshProUGUI>();
        quantInMax = 2;
        quantIniAtual = 0;
        fases = 1;
        fasesText.text = ($"{fases}");
    }

    private void FixedUpdate()
    {
        
    }
}
