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

    public int quantidadeDeNumerosParaOIdMaximo = 8;
    public int quantidadeDeNumerosParaOId;

    public int arma;

    public string nomeDaClasse;

    GameObject mana;

    public GameObject armaEscolhida;

    public int danoBasico = 1;
    public float vidaAtual;
    public float vidaMaxima = 2; // Defina um valor máximo para a vida
    private void Start()
    {
        ArmasCorpoACorpo.Instance.EscolhaDeClasse();
        calculoDeIDInimigo();
        mana = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefab/OrbeDeMana.prefab");
        vidaAtual = vidaMaxima; // Inicializa a vida atual
    }

    public void SpawnArmas()
    {
        GameObject arma = Instantiate(armaEscolhida, transform.Find("SpawnArma").transform.position, transform.rotation);
        arma.transform.parent = transform.Find("SpawnArma").transform;
    }

    public void calculoDeIDInimigo()
    {
        if(Spawn.Instance.quantInimigo < Spawn.Instance.quantInMax)
        {
            if (quantidadeDeNumerosParaOId <= quantidadeDeNumerosParaOIdMaximo)
            {
                int numeroAleatorioParaOId = Random.Range(0, 9);
                idInimigo += numeroAleatorioParaOId;
                calculoDeIDInimigo();
            }
        }
    }

    void DropMana()
    {
        Instantiate(mana, transform.position, transform.rotation);
    }

    public void MorteInimigo()
    {
        vidaAtual-= Status.Instance.danoReal;
        if (vidaAtual <= 0)
        {
            // Aqui você pode chamar a lógica de fase, se necessário
            DropMana();
            Spawn.Instance.quantIniAtual++;
            Spawn.Instance.Fases();
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.collider.CompareTag("Projetiu"))
        {
            MorteInimigo();
            return;
        }
    }
}
