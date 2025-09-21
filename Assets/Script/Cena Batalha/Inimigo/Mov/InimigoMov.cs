using UnityEngine;
using UnityEngine.UIElements;

public class InimigoMov : MonoBehaviour
{
    public static InimigoMov Instance;
    private void Awake()
    {
        Instance = this;
    }

    GameObject player;
    public float velocidade = 2.5f;
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) return; // Evita erros se player não existir
        Vector2 direction = (Vector2)(player.transform.position - transform.position);
        direction.Normalize();
        // Movimento em direção ao player (mantido igual)
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, velocidade * Time.deltaTime);
        // Travar rotação: mantém em 0 (sem rotação para baixo ou qualquer direção)
        transform.rotation = Quaternion.identity; // Ou Quaternion.Euler(0, 0, 0);
        // Flip horizontal para simular direção esquerda/direita (sem rotacionar para baixo)

    }



}
