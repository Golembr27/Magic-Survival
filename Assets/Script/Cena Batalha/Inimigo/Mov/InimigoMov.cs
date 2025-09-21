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
        if (player == null) return; // Evita erros se player n�o existir
        Vector2 direction = (Vector2)(player.transform.position - transform.position);
        direction.Normalize();
        // Movimento em dire��o ao player (mantido igual)
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, velocidade * Time.deltaTime);
        // Travar rota��o: mant�m em 0 (sem rota��o para baixo ou qualquer dire��o)
        transform.rotation = Quaternion.identity; // Ou Quaternion.Euler(0, 0, 0);
        // Flip horizontal para simular dire��o esquerda/direita (sem rotacionar para baixo)

    }



}
