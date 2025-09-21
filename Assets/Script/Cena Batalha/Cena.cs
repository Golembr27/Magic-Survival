using UnityEngine;
using UnityEngine.SceneManagement;

public class Cena : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void carregarCena()
    {
        SceneManager.LoadScene("Jogatina");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
