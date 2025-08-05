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


    public int arma;

    public Transform locaArmaSpawn;

    //Local para colocar os prefab
    public GameObject prefabEspada;
    public Image iconeDaEspada;

    public GameObject prefabDaAdaga;
    public Image iconeDaAdaga;

    public GameObject prefabArco;
    public Image iconeArco;

    public void Classes()
    {
        if (StatusInimigo.Instance.nomeDaClasse == "Espada")
        {
            armaSpawn++;
            StatusInimigo.Instance.armaEscolhida = prefabEspada;
            imagemDasArma = iconeDaEspada;
            tempoDeAtaque = 1.5f;
            danoDaArma = 2.25f;


        }
        if (StatusInimigo.Instance.nomeDaClasse == "Adaga")
        {
            armaSpawn++;
            StatusInimigo.Instance.armaEscolhida = prefabDaAdaga;
            imagemDasArma = iconeDaEspada;
            tempoDeAtaque = 0.50f;
            danoDaArma = 1.25f;
            
        }
        if (StatusInimigo.Instance.nomeDaClasse == "Arco")
        {
            armaSpawn++;
            StatusInimigo.Instance.armaEscolhida = prefabArco;
            imagemDasArma = iconeArco;
            tempoDeAtaque = 1.2f;
            danoDaArma = 2f;
            

        }
        StatusInimigo.Instance.SpawnArmas();
        return;
    }

    public void EscolhaDeClasse()
    {
        arma = Random.Range(0, 4);
        if (arma == 1)
        {
            arma = Random.Range(0, 4);
            StatusInimigo.Instance.nomeDaClasse = "Adaga";
            
        }
        if (arma == 2)
        {
            arma = Random.Range(0, 4);
            StatusInimigo.Instance.nomeDaClasse = "Espada";
            
        }
        if(arma == 3)
        {
            arma = Random.Range(0, 4);
            StatusInimigo.Instance.nomeDaClasse = "Arco";
        }
        Classes();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
}
