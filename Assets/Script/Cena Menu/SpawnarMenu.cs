using UnityEditor;
using UnityEngine;

public class SpawnarMenu : MonoBehaviour
{
    public static SpawnarMenu Instance;
    public void Awake()
    {
        Instance = this;
    }

    public Transform SpawnMenu;

    public GameObject Prefabjogar;
    public GameObject Prefabclasses;
    public GameObject Prefabloja;
    public GameObject Prefabopicoes;
    public GameObject Prefabcreditos;

    public string nomeDoBotao;

    Canvas canvas;
    

    public void Start()
    {
        canvas = GetComponent<Canvas>();
    }

    public void MenuSpawn()
    {
        if(nomeDoBotao == "jogar")
        {
            GameObject menu = Instantiate(Prefabjogar , SpawnMenu.position, SpawnMenu.rotation);
            menu.transform.parent = SpawnMenu.parent;
            menu.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (nomeDoBotao == "classe")
        {
            GameObject menu = Instantiate(Prefabclasses, SpawnMenu.position, SpawnMenu.rotation);
            menu.transform.parent = SpawnMenu.parent;
            menu.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (nomeDoBotao == "loja")
        {
            GameObject menu = Instantiate(Prefabloja, SpawnMenu.position, SpawnMenu.rotation);
            menu.transform.parent = SpawnMenu.parent;
            menu.transform.localScale = new Vector3(1f,1f,1f);
        }
        if (nomeDoBotao == "opicaoes")
        {
            GameObject menu = Instantiate(Prefabopicoes, SpawnMenu.position, SpawnMenu.rotation);
            menu.transform.parent = SpawnMenu.parent;
            menu.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (nomeDoBotao == "creditos")
        {
            GameObject menu = Instantiate(Prefabcreditos, SpawnMenu.position, SpawnMenu.rotation);
            menu.transform.parent = SpawnMenu.transform.parent;
            Prefabopicoes.transform.localScale = new Vector3(1f, 1f, 1f);
        }

    }

}
