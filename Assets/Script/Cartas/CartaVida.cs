using UnityEngine;

public class CartaVida : MonoBehaviour
{
    public void CartaVidA()
    {
        StatusCarta.Instance.numeroDeCartasVida++;
        Status.Instance.vidaMaxima += StatusCarta.Instance.statusCartaVida;
        BarraDeVida.Instance.TextoMuda();
        Destroy(SlotsDasCartas.Instance.Slot1.transform.gameObject);
        Destroy(SlotsDasCartas.Instance.Slot2.transform.gameObject);
        Destroy(SlotsDasCartas.Instance.Slot3.transform.gameObject);
    }
}
