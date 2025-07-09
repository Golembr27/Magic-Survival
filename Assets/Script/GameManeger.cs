using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    public static GameManeger Instance;
    private void Awake()
    {
        Instance = this;
    }

    public Transform Inimigo;
    public GameObject mana;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void DropMana()
    {
        if (StatusInimigo.Instance.vidaAtual <= 0)
        {
            Instantiate(mana, Inimigo.position, Inimigo.rotation);
        }
    }


}
