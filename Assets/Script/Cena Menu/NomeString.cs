using UnityEngine;

public class NomeString : MonoBehaviour
{
    public static NomeString Instance;
    public void Awake()
    {
        Instance = this;
    }

    public void AlterarNomeDoMenu()
    {
        SpawnarMenu.Instance.nomeDoBotao = nome;
        SpawnarMenu.Instance.MenuSpawn();
    }

    public void AlterarCena()
    {
        LoadCena.Instance.nomeCena = nomeDaCena;
        LoadCena.Instance.CarregarMenu();
    }

    public string nomeDaCena = "";
    public string nome = "";
}
