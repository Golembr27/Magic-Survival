using UnityEngine;

public class InimigoMov : MonoBehaviour
{
    public static InimigoMov Instance;
    private void Awake()
    {
        Instance = this;
    }

    public float velocidade;
    Transform player;
    
    public int Spawnou = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player").transform.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player);
        Vector2 seguirPlayer = (player.position - transform.position).normalized;

        transform.Translate(seguirPlayer * velocidade * Time.deltaTime);
    }
}
