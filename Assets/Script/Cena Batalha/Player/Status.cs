using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    public static Status Instance;

    void Awake()
    {

        Instance = this;
    }
    //Status de Nivel
    public int nivelProximo = 1;
    public int nivelAtual = 0;
    public float xp;
    public float xpMaximo;
    public float levelDificuldade = 1.0f;


    //Status da MAGIA BASICA
    public int danoMagiaBasica = 2;

    //Status Vida
    public int vidaAtual;
    public int vidaMaxima = 25;

    //Status de Mana
    public int manaMaxima = 20;
    public int manaAtual;

    //Status de DEFESA
    public int defesaContraArmaDeMao = 1;
    public int defesaContraProjetius = 1;
    public int defesaContraVenenos = 1;
    public int defesaContraMaldicao = 1;
    //Status de DEFESA

    //Status de ATAQUE
    public int danoReal = 2;

    //Status de Pontos
    public int pontos;

    public void MortePlayer()
    {
        if (vidaAtual <= 0)
        {
            pontos += StatusInimigo.Instance.pontos;
            Destroy(gameObject);
        }
    }

    public void UPDeNivel()
    {
        if(xp >= xpMaximo){
            if (nivelAtual <= nivelProximo)
            {
                xpMaximo += xp + nivelAtual * levelDificuldade;
            }
            xp = 0;
            nivelAtual++;
            nivelProximo++;
            levelDificuldade += 0.2f;
            SlotsDasCartas.Instance.prefabVazioSpawn = true;
            SlotsDasCartas.Instance.Finalizado();
            SlotsDasCartas.Instance.CartaAleatoria();
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
       xpMaximo = 50;
       manaAtual = 20;
       manaMaxima = 20;
       vidaAtual = vidaMaxima;
       nivelProximo++;
    }
}