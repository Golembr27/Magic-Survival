using UnityEngine;

public class CartaDano : MonoBehaviour
{
    public void CartaDanO()
    {
        StatusCarta.Instance.numeroDeCartasDano++;
        Status.Instance.danoReal += StatusCarta.Instance.statusCartaDano;
        Destroy(SlotsDasCartas.Instance.Slot1.transform.gameObject);
        Destroy(SlotsDasCartas.Instance.Slot2.transform.gameObject);
        Destroy(SlotsDasCartas.Instance.Slot3.transform.gameObject);
    }
}
