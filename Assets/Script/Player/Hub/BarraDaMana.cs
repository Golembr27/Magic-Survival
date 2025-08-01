using TMPro;
using UnityEngine;

public class BarraDaMana : MonoBehaviour
{
    public static BarraDaMana Instance;

    private void Awake()
    {
        Instance = this;
    }

    public int gastoDaMagia;

    public bool magiaAcionada;
    public TextMeshProUGUI tmManaAtul;

    bool balaAtirada;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Status.Instance.manaAtual <= 0) 
        {
            Magia.Instance.podeAtirar = false;
        }else Magia.Instance.podeAtirar = true;
        if (magiaAcionada == true)
        {
            Status.Instance.manaAtual -= gastoDaMagia;
            tmManaAtul.text = ($"{Status.Instance.manaAtual}/{Status.Instance.manaMaxima}");
        }
    }

    public void TextoMuda()
    {
        tmManaAtul.text = ($"{Status.Instance.manaAtual}/{Status.Instance.manaMaxima}");
    }
}
