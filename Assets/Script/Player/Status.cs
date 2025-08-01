using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    public static Status Instance;

    void Awake()
    {
        Instance = this;
    }

    public int vidaAtual;

    public int vidaMaxima = 25;

    //Status da MAGIA BASICA
    public int danoMagiaBasica = 2;
    //Status da MAGIA BASICA

    //Status de Mana
    public int manaMaxima;
    public int manaAtual;

    //Status de DEFESA
    public int defesaContraArmaDeMao = 1;
    public int defesaContraProjetius = 1;
    public int defesaContraVenenos = 1;
    public int defesaContraMaldicao = 1;
    //Status de DEFESA

    //Status de ATAQUE
    public int danoReal = 2;

    public void MortePlayer()
    {
        if(vidaAtual <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manaAtual = 20;
        manaMaxima = 20;
        vidaAtual = vidaMaxima;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
