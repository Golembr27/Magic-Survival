using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BarraDaMana : MonoBehaviour
{
    public static BarraDaMana Instance;

    private void Awake()
    {
        Instance = this;
    }

    public Slider slider;

    public int gastoDaMagia;

    public bool magiaAcionada;
    public TextMeshProUGUI tmManaAtul;

    bool balaAtirada;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tmManaAtul.gameObject.SetActive(false);
        slider.maxValue = Status.Instance.manaMaxima;
        slider.value = Status.Instance.manaAtual;
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
        slider.value = Status.Instance.manaAtual;
    }

    public void TextoMuda()
    {
        tmManaAtul.text = ($"{Status.Instance.manaAtual}/{Status.Instance.manaMaxima}");
    }

    public void OnMouseEnter()
    {
        tmManaAtul.gameObject.SetActive(true);
    }

    public void OnMouseExit()
    {
        tmManaAtul.gameObject.SetActive(false);
    }

}
