using TMPro;
using Unity.Burst.Intrinsics;
using UnityEditor;
using UnityEngine;

public class StatusInimigo : MonoBehaviour
{
    public static StatusInimigo Instance;

    private void Awake()
    {
        Instance = this;
    }

    public int idInimigo;


    public int ID;
    public int quantidadeDeNumerosParaOIdMaximo = 8;
    public int quantidadeDeNumerosParaOId;

    public TextMeshProUGUI PontosTM;

    public int pontos;

    public int arma;

    public string nomeDaClasse;

    GameObject mana;

    public GameObject armaEscolhida;

    public GameObject armaSpawnada;

    public int xp;

    public int danoBasico = 1;
    public float vidaAtual;
    public float vidaMaxima = 2; // Defina um valor máximo para a vida

    public bool morteAtiva = false;

    private void Start()
    {
        calculoDeIDInimigo();
        morteAtiva = false;
        //PontosTM = gameObject.transform.Find("Canvas").transform.Find("Pontuacao").transform.Find("pontos").GetComponent<TextMeshProUGUI>();
        mana = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefab/OrbeDeMana.prefab");
        vidaAtual = vidaMaxima; // Inicializa a vida atual
    }

    public void SpawnArmas()
    {
        if(ArmasCorpoACorpo.Instance.armaSpawn <= Spawn.Instance.quantInMax)
        {
            armaSpawnada = Instantiate(armaEscolhida, transform.Find("SpawnArma").transform.position, transform.rotation);
            armaSpawnada.transform.parent = transform.Find("SpawnArma").transform;
        }
    }

    public void calculoDeIDInimigo()
    {
        if (quantidadeDeNumerosParaOId <= quantidadeDeNumerosParaOIdMaximo)
        {
            quantidadeDeNumerosParaOId++;
            int numeroAleatorioParaOId = Random.Range(0, 99999999);
            ID = numeroAleatorioParaOId;
            calculoDeIDInimigo();
        }
        return;
    }

    void DropMana()
    {
        Instantiate(mana, transform.position, transform.rotation);
    }

    public void MorteInimigo()
    {
        if(morteAtiva == false){
            Spawn.Instance.ListInimigo.Clear();
            morteAtiva = true;
            Spawn.Instance.quantIniAtual = Spawn.Instance.quantIniAtual + 1;
            vidaAtual -= Status.Instance.danoReal;
            if (vidaAtual <= 0)
            {
                Status.Instance.pontos += StatusInimigo.Instance.pontos;
                Status.Instance.xp += xp;
                Status.Instance.UPDeNivel();
                ArmasCorpoACorpo.Instance.armaSpawn = 0;
                DropMana();

                Spawn.Instance.Fases();
                if (vidaAtual <= 0)
                {
                    Destroy(gameObject);
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.collider.CompareTag("Projetiu"))
        {
            MorteInimigo();
            //return;
        }
    }
}
