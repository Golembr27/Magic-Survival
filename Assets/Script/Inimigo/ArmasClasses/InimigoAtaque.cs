using TMPro;
using UnityEngine;

public class InimigoAtaque : MonoBehaviour
{
 
    public static InimigoAtaque instance;

    void Awake()
    {
        instance = this;
    }

    TextMeshProUGUI tm;

    //Dano que a magia vai dar
    public int Dano;
    //A variavel bool "PodeDarDano", faz se o Player colidir vai receber dano.
    public bool PodeDarDano = false;

    //Tempo da skill dar dano de novo
    public float TempoDeSkill = 0f;

    public bool AtivarTempo = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tm = GameObject.Find("Canvas").transform.Find("BarraDeVida").transform.Find("VidaAtual").GetComponent<TextMeshProUGUI>();
        Dano = StatusInimigo.Instance.danoBasico;
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
            Debug.Log($"Perdeu {Status.Instance.vidaAtual} de Vida");
            CalculoDaDefesa();
            Status.Instance.vidaAtual -= Dano;
            tm.text = ($"{Status.Instance.vidaAtual}/{Status.Instance.vidaMaxima}");
            Status.Instance.MortePlayer();
            AtivarTempo = true;
            TempoDeSkill = 3f;
        }
    }

    public void CalculoDaDefesa()
    {

    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Player"))
        {
            
            Debug.Log("DarDano Ativado");
            PodeDarDano = true;
            AtivarTempo = true;
            Debug.Log($"{PodeDarDano}, Player Atacado");
        }
    }

    private void OnTriggerExit2D(Collider2D c)
    {
        AtivarTempo = false;
        PodeDarDano = false;
        Debug.Log($"{PodeDarDano}, Player Atacado");
    }
}