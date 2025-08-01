using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    public static BarraDeVida Instance;

    void Awake()
    {
        Instance = this;
    }

    public TextMeshProUGUI tmVidaAtul;

    [SerializeField]Image BarraDaVidaUI;
    
    //A variavel bool "PodeDarDano", faz se o Player colidir vai receber dano.
    public bool PodeDarDano = false;

    //Tempo da skill dar dano de novo
    public float TempoDeSkill = 0f;

    public bool AtivarTempo = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
            BarraDaVidaUI.fillAmount = Status.Instance.vidaAtual / Status.Instance.vidaMaxima;
            Debug.Log(BarraDaVidaUI.fillAmount);
            Status.Instance.vidaAtual -= InimigoAtaque.instance.Dano;
            tmVidaAtul.text = ($"{Status.Instance.vidaAtual}/{Status.Instance.vidaMaxima}");
            Status.Instance.MortePlayer();
            AtivarTempo = true;
            TempoDeSkill = 3f;
        }
    }

    private void OnTriggerExit2D(Collider2D c)
    {
        AtivarTempo = false;
        PodeDarDano = false;
        Debug.Log($"{PodeDarDano}, Player Atacado");
    }

    public void TextoMuda()
    {
        tmVidaAtul.text = ($"{Status.Instance.vidaAtual}/{Status.Instance.vidaMaxima}");
    }
}
