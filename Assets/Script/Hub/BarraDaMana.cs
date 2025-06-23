using TMPro;
using UnityEngine;

public class BarraDaMana : MonoBehaviour
{
    public static BarraDaMana instance;

    private void Awake()
    {
        instance = this;
    }

    Bala bala;
    Magia magia;

    public int gastoDaMagia;
    public int manaAtul;
    public int manaMaxima = 20;
    public bool magiaAcionada;
    public TextMeshProUGUI tmManaAtul;

    bool balaAtirada;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manaAtul = manaMaxima;
    }

    // Update is called once per frame
    void Update()
    {
        if (manaAtul <= 0) 
        {
            Magia.Instance.podeAtirar = false;
        }else Magia.Instance.podeAtirar = true;
        if (magiaAcionada == true)
        {
            Debug.Log($"magiaAcionada = {magiaAcionada}");
            gastoDaMagia = Bala.Instance.gastoDeMana;
            manaAtul -= gastoDaMagia;
            tmManaAtul.text = ($"{manaAtul}/{manaMaxima}");
        }
    }
}
