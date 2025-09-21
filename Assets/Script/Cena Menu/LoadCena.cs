using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCena : MonoBehaviour
{
    public static LoadCena Instance;
    public void Awake()
    {
        Instance = this;
    }

    public string nomeCena = "";

    public void CarregarMenu()
    {
        if(nomeCena == "survival")
        {
            SceneManager.LoadScene(nomeCena);
            
        }
        if (nomeCena == "dungeon")
        {
            SceneManager.LoadScene(nomeCena);
        }
        if (nomeCena == "boss")
        {
            SceneManager.LoadScene(nomeCena);
        }
    }
}
