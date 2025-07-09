using UnityEditor;
using UnityEngine;

public class StatusInimigo : MonoBehaviour
{
    public static StatusInimigo Instance;

    private void Awake()
    {
        Instance = this;
    }

    GameObject mana;

    public int danoBasico = 1;
    public float vidaAtual;
    public float vidaMaxima = 3; // Defina um valor m�ximo para a vida
    private void Start()
    {
        mana = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefab/OrbeDeMana.prefab");
        vidaAtual = vidaMaxima; // Inicializa a vida atual
    }

    void DropMana()
    {  
        Instantiate(mana, transform.position, transform.rotation);
    }

    public void MorteInimigo()
    {
        vidaAtual--;
        if (vidaAtual <= 0)
        {
            // Aqui voc� pode chamar a l�gica de fase, se necess�rio
            DropMana();
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
