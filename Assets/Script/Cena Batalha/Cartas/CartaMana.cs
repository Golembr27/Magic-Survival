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
        StatusCarta.Instance.numeroDeCartasMana++;
        Status.Instance.manaMaxima += StatusCarta.Instance.statusCartaMana;
        BarraDaMana.Instance.TextoMuda();
        Destroy(objeto1);
        return;
    }
}