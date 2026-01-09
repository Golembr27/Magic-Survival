using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    public static Spawn Instance;

    private void Awake()
    {
        Instance = this;
    }

    public GameObject PrefabVazio;
    public GameObject vazio;

    public Transform objetoPai;

    public bool NAOPODEINICIAR;

    public float tempoDeSpawn;

    public int spawnContagemOrda;

    public int numeroAleatorioDeSpawn;

    public bool AtivarOrda = true;

    TextMeshProUGUI fasesText;
    BoxCollider2D play;
    public bool faseIni = false;
    public GameObject Prefabinimigo;
    public Transform spawnTR;
    public int quantInimigo = 0;
    public int quantIniAtual = 0;
    public int fases;
    public int quantInMax;

    public GameObject inimigosSpawn;

    int arma;

    

    public void spawn() //SPAWN INIMIGO
    {
        if(NAOPODEINICIAR == false)
        {
            quantIniAtual = 0;
            if (faseIni == true && quantInimigo < quantInMax && AtivarOrda == true)
            {
                quantInimigo++;
                inimigosSpawn = Instantiate(Prefabinimigo, spawnTR.position, spawnTR.rotation);
                inimigosSpawn.transform.SetParent(objetoPai);
                ArmasCorpoACorpo.Instance.EscolhaDeClasse();
                spawn();
                return;
            }
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
        
        objetoPai = GameObject.Find("ObjetoPai(Clone)").transform;
        if (Status.Instance.xp >= Status.Instance.xpMaximo)
        {
            Status.Instance.UPDeNivel();
            return;
        }
        if (SlotsDasCartas.Instance.cartaAtiva == false)
        {
            if (quantIniAtual == quantInMax)
            {
                
                numeroAleatorioDeSpawn = Random.Range(1, 4);
                quantIniAtual = 0;
                quantInMax += numeroAleatorioDeSpawn;
                quantInimigo = 0;
                //faseIni = false;
                fases++;
                fasesText.text = ($"{fases}");
                if (faseIni == true)
                {
                    spawn();
                }
            }
        }
    }

    private void Start()
    {
        vazio = Instantiate(PrefabVazio, spawnTR.position, spawnTR.rotation);
        objetoPai = GameObject.Find("ObjetoPai(Clone)").transform;
        Debug.Log(objetoPai);
        //play  = GameObject.Find("Play").transform.GetComponent<BoxCollider2D>();
        fasesText = GameObject.Find("Canvas").transform.Find("Fases").transform.Find("Fase").GetComponent<TextMeshProUGUI>();
        quantInMax = 2;
        quantIniAtual = 0;
        fases = 1;
        fasesText.text = ($"{fases}");
        faseIni = true;
        spawn();
    }
}
