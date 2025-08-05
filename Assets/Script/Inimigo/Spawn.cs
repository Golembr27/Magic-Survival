using TMPro;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    public static Spawn Instance;

    private void Awake()
    {
        Instance = this;
    }

    public float tempoDeSpawn;

    public int spawnContagemOrda;

    public int numeroAleatorioDeSpawn;

    public bool AtivarOrda = true;

    TextMeshProUGUI fasesText;
    BoxCollider2D play;
    public bool faseIni = false;
    public GameObject inimigo;
    public Transform spawnTR;
    public int quantInimigo = 0;
    public int quantIniAtual = 0;
    public int fases;
    public int quantInMax;

    int arma = 1;

    void spawn()
    {
        if (faseIni == true && quantInimigo < quantInMax && AtivarOrda == true)
        {
            quantInimigo++;
            Instantiate(inimigo, spawnTR.position, spawnTR.rotation);
            ArmasCorpoACorpo.Instance.EscolhaDeClasse();
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
            SlotsDasCartas.Instance.prefabVazioSpawn = true;
            SlotsDasCartas.Instance.Finalizado();
            SlotsDasCartas.Instance.CartaAleatoria();
            quantIniAtual = 0;
            quantInMax += numeroAleatorioDeSpawn;
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
}
