using UnityEngine;

public class StatusInimigo : MonoBehaviour
{
    public static StatusInimigo Instance;

    private void Awake()
    {
        Instance = this;
    }

    public float vidaAtual;
    public float vidaMaxima = 3; // Defina um valor máximo para a vida
    private void Start()
    {
        vidaAtual = vidaMaxima; // Inicializa a vida atual
    }
    public void MorteInimigo()
    {
        vidaAtual--;
        if (vidaAtual <= 0)
        {
            // Aqui você pode chamar a lógica de fase, se necessário
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
