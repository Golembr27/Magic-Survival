using UnityEngine;

public class CartaMana : MonoBehaviour
{
    public void CartaManA()
    {
        StatusCarta.Instance.numeroDeCartasMana++;
        Status.Instance.manaMaxima += StatusCarta.Instance.statusCartaMana;
        BarraDaMana.Instance.TextoMuda();
        Destroy(SlotsDasCartas.Instance.Slot1.transform.gameObject);
        Destroy(SlotsDasCartas.Instance.Slot2.transform.gameObject);
        Destroy(SlotsDasCartas.Instance.Slot3.transform.gameObject);
    }
}