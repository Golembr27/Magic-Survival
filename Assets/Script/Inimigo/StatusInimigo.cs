using UnityEngine;

public class StatusInimigo : MonoBehaviour
{
    public static StatusInimigo Instance;

    private void Awake()
    {
        Instance = this;
    }

    public float vidaAtual;
    public float vidaMaxima = 3; // Defina um valor m�ximo para a vida
    private void Start()
    {
        vidaAtual = vidaMaxima; // Inicializa a vida atual
    }
    public void MorteInimigo()
    {
        vidaAtual--;
        if (vidaAtual <= 0)
        {
            // Aqui voc� pode chamar a l�gica de fase, se necess�rio
            Spawn.instance.quantIniAtual++;
            Spawn.instance.Fases();
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.collider.CompareTag("Projetiu"))
        {

            MorteInimigo();
            return;
        }
    }
}
