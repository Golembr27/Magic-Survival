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
        objeto1 = GameObject.Find("PREFABVAZIO(Clone)");
    }

    public void CartaVidA()
    {
        SlotsDasCartas.Instance.Finalizado();
        StatusCarta.Instance.numeroDeCartasVida++;
        Status.Instance.vidaMaxima += StatusCarta.Instance.statusCartaVida;
        Status.Instance.vidaAtual = Status.Instance.vidaMaxima;
        BarraDeVida.Instance.TextoMuda();
        Destroy(objeto1);
        return;
    }
}
