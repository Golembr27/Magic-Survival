using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.UI;


public class ArmasCorpoACorpo : MonoBehaviour
{
    public static ArmasCorpoACorpo Instance;
    public void Awake()
    {
        Instance = this;
    }

    public int armaSpawn = 0;
    public string nomeDaClasse = null;
    public GameObject prefabDaArma;
    public float danoDaArma;
    public float tempoDeAtaque;
    public Image imagemDasArma;
    BoxCollider2D tamanhoDaColisao;

    public int arma = 1;

    public Transform locaArmaSpawn;

    public GameObject prefabEspada;
    public Image iconeDaEspada;

    public GameObject prefabDaAdaga;
    public Image iconeDaAdaga = null;

    public void Classes()
    {
        if (StatusInimigo.Instance.nomeDaClasse == "Espada")
        {
            armaSpawn++;
            StatusInimigo.Instance.armaEscolhida = prefabEspada;
            iconeDaEspada = imagemDasArma;
            tempoDeAtaque = 1.5f;
            danoDaArma = 2.25f;
            StatusInimigo.Instance.SpawnArmas();
        }
        if (StatusInimigo.Instance.nomeDaClasse == "Adaga")
        {
            armaSpawn++;
            StatusInimigo.Instance.armaEscolhida = prefabDaAdaga;
            iconeDaEspada = imagemDasArma;
            tempoDeAtaque = 0.50f;
            danoDaArma = 1.25f;
            StatusInimigo.Instance.SpawnArmas();
        }
    }

    public void EscolhaDeClasse()
    {
        if (arma == 1)
        {
            arma = 2;
            StatusInimigo.Instance.nomeDaClasse = "Adaga";
            Classes();
        }
        else if (arma == 2)
        {
            arma = 1;
            StatusInimigo.Instance.nomeDaClasse = "Espada";
            Classes();
        }
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        arma = 1;
    }
}
