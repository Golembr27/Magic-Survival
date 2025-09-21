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
        foreach (GameObject obj in Spawn.Instance.ListInimigo)
        {
            Destroy(obj);
        }
        Spawn.Instance.ListInimigo.Clear();

        SlotsDasCartas.Instance.cartaAtiva = false;
        Spawn.Instance.faseIni = true;
        Spawn.Instance.quantIniAtual = Spawn.Instance.quantInMax;
        Spawn.Instance.fases--;
        Spawn.Instance.Fases();
        SlotsDasCartas.Instance.Finalizado();
        StatusCarta.Instance.numeroDeCartasDano++;
        Status.Instance.danoReal += StatusCarta.Instance.statusCartaDano;
        Destroy(objeto1);
        return;
    }
}
