using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    public static BarraDeVida Instance;

    void Awake()
    {
        Instance = this;
    }

    public Slider slider;

    public TextMeshProUGUI tmVidaAtul;
    
    //A variavel bool "PodeDarDano", faz se o Player colidir vai receber dano.
    public bool PodeDarDano = false;

    //Tempo da skill dar dano de novo
    public float TempoDeSkill = 0f;

    public bool AtivarTempo = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tmVidaAtul.gameObject.SetActive(false);
        slider.maxValue = Status.Instance.vidaMaxima;
        slider.value = Status.Instance.vidaMaxima;
        AtivarTempo = false;
        PodeDarDano = false;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (AtivarTempo == true)
        {
            TempoDeSkill -= Time.deltaTime;
            if (TempoDeSkill == 0f)
            {
                TempoDeSkill = 3f;
                AtivarTempo = false;
            }
        }
        if (PodeDarDano == true && TempoDeSkill <= 0f)
        {   
            Status.Instance.vidaAtual -= InimigoAtaque.instance.Dano;
            
            tmVidaAtul.text = ($"{Status.Instance.vidaAtual}/{Status.Instance.vidaMaxima}");
            Status.Instance.MortePlayer();
            AtivarTempo = true;
            TempoDeSkill = 3f;
        }
        
        slider.value = Status.Instance.vidaAtual;
    }

    private void OnTriggerExit2D(Collider2D c)
    {
        AtivarTempo = false;
        PodeDarDano = false;
        
    }

    public void TextoMuda()
    {
        tmVidaAtul.text = ($"{Status.Instance.vidaAtual}/{Status.Instance.vidaMaxima}");
    }

    public void OnMouseEnter()
    {
        tmVidaAtul.gameObject.SetActive(true);
    }

    public void OnMouseExit()
    {
        tmVidaAtul.gameObject.SetActive(false);
    }

}
