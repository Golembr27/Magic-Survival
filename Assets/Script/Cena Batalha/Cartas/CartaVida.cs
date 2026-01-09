using UnityEngine;

public class CartaVida : MonoBehaviour
{
    public static CartaVida Instance;
    private void Awake()
    {
        Instance = this;
    }
    GameObject objeto1;

    public int numero;

    private void Start()
    {
        objeto1 = GameObject.Find("ObjetoPai(Clone)");
    }

    public void CartaVidA()
    {
        SlotsDasCartas.Instance.cartaAtiva = false;
        Spawn.Instance.faseIni = true;
        Spawn.Instance.quantIniAtual = Spawn.Instance.quantInMax;
        Spawn.Instance. fases--;
        Spawn.Instance.Fases();
        SlotsDasCartas.Instance.Finalizado();
        StatusCarta.Instance.numeroDeCartasVida++;
        int vidaSlide = Status.Instance.vidaMaxima += StatusCarta.Instance.statusCartaVida;
        BarraDeVida.Instance.slider.maxValue = vidaSlide;
        BarraDeVida.Instance.slider.value = vidaSlide;
        Status.Instance.vidaAtual = Status.Instance.vidaMaxima;
        BarraDeVida.Instance.TextoMuda();
        Destroy(objeto1);
        return;
    }
}
