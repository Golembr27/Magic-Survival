using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Magia : MonoBehaviour
{
    public static Magia Instance;

    private void Awake()
    {
        Instance = this;
    }

    private BarraDaMana barraDaMana;

    Vector2 mousePos;
    Vector2 dirArma;

    float angle;

    public SpriteRenderer srGun;

    public float tempoentretiros;

    public bool podeAtirar = true;

    public Transform pontoDeFogo;
    public GameObject tiro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Obtém a posição do mouse em pixels
        Vector3 mouseScreenPos = Input.mousePosition;
        // Verifica se a posição do mouse está dentro da tela
        if (mouseScreenPos.x >= 0 && mouseScreenPos.x <= Screen.width &&
            mouseScreenPos.y >= 0 && mouseScreenPos.y <= Screen.height)
        {
            // Converte a posição do mouse para coordenadas do mundo
            mousePos = Camera.main.ScreenToWorldPoint(mouseScreenPos);
        }

        if (Input.GetMouseButtonDown(0) && podeAtirar == true)
        {
            if(BarraDaMana.instance.manaAtul >= 0)
            {
                BarraDaMana.instance.magiaAcionada = true;
            }
            podeAtirar = false;
            Instantiate(tiro, pontoDeFogo.position, pontoDeFogo.rotation);
            Invoke("CDTiro", tempoentretiros);
        }else BarraDaMana.instance.magiaAcionada = false;

    }

    private void FixedUpdate()
    {
        dirArma = mousePos - new Vector2(transform.position.x, transform.position.y);
        angle = Mathf.Atan2(dirArma.y, dirArma.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(0, 0, angle);

        if(angle >-180 && angle < 0)
        {
            srGun.flipX = false;
        }
        else srGun.flipX = true;
    }

    void CDTiro()
    {
        podeAtirar = true;
    }
}
