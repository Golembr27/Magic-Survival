using UnityEngine;

public class CartaDano : MonoBehaviour
{
    public static CartaDano Instance;
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

    public void CartaDanO()
    {
        SlotsDasCartas.Instance.Finalizado();
        StatusCarta.Instance.numeroDeCartasDano++;
        Status.Instance.danoReal += StatusCarta.Instance.statusCartaDano;
        Destroy(objeto1);
        return;
    }
}
