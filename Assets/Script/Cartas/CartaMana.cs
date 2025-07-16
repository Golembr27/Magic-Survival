using Unity.VisualScripting;
using UnityEngine;

public class CartaMana : MonoBehaviour
{
    public static CartaMana Instance;
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

    public void CartaManA()
    {
        SlotsDasCartas.Instance.Finalizado();
        StatusCarta.Instance.numeroDeCartasMana++;
        Status.Instance.manaMaxima += StatusCarta.Instance.statusCartaMana;
        BarraDaMana.Instance.TextoMuda();
        Destroy(objeto1);
        return;
    }
}