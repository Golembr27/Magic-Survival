using NUnit.Framework.Constraints;
using System.Collections.Generic;
using UnityEngine;

public class SlotsDasCartas : MonoBehaviour
{
    public static SlotsDasCartas Instance;
    private void Awake()
    {
        Instance = this;
    }
    public Transform Slot1;
    public Transform Slot2;
    public Transform Slot3;

    public Transform canva;

    [SerializeField] GameObject Slot;

    public int cartaDeVida;
    public int cartaDeDano;
    public int cartaDeMana;

    public GameObject PrefabVida;
    public GameObject PrefabDano;
    public GameObject PrefabMana;

    GameObject PrefabEscolhido;
    public GameObject PrefabVazio;
    public bool prefabVazioSpawn = true;
    GameObject GDestroi;

    [SerializeField] int objetoMaximo = 4;
    public int objetoSpawnado = 1;

    public int totalNumeros = 0;

    public int numeroAleatorio;

    Vector2 posicaoObjecto;

    public int numeroDeContagemDoSpawn;
    public bool cartaAtiva = false;

    [Header("Configurações")]
    public List<GameObject> listaDeCartas = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        prefabVazioSpawn = true;
    }

    public void Finalizado()
    {
        objetoSpawnado = 0;
    }

    public void CartaAleatoria()
    {
        cartaAtiva = true;
        Spawn.Instance.quantIniAtual = 0;
        Spawn.Instance.faseIni = false;
        if (prefabVazioSpawn == true)
        {
            prefabVazioSpawn = false;
            GDestroi = Instantiate(PrefabVazio, canva.position, Quaternion.identity);
            GDestroi.transform.parent = canva.transform;
            GDestroi.transform.localScale = new Vector3(1f, 1f, 1f);
        }
            objetoSpawnado++;
            numeroAleatorio = Random.Range(1, 4);
        
        if (objetoSpawnado <= objetoMaximo)
        {
            Destroy(Spawn.Instance.vazio);
            if (numeroAleatorio == 1) //Carta de vida
            {
                PrefabEscolhido = PrefabVida; 
                PrefabEscolhido.name = ($"card1");

                if (objetoSpawnado == 1)
                {
                    cartaDeVida++;
                    
                    GameObject Slot = Instantiate(PrefabEscolhido, Slot1.position, Slot1.rotation);
                    Slot.transform.parent = GDestroi.transform;
                    Slot.transform.localScale = new Vector3(1f, 1f, 1f);
                    CartaAleatoria();
                    return;
                }
                if (objetoSpawnado == 2)
                {
                    cartaDeVida++;
                    
                    GameObject Slot = Instantiate(PrefabEscolhido, Slot2.position, Slot2.rotation);
                    Slot.transform.parent = GDestroi.transform;
                    Slot.transform.localScale = new Vector3(1f, 1f, 1f);
                    CartaAleatoria();
                    return;
                }
                if (objetoSpawnado == 3)
                {
                    cartaDeVida++;
                    
                    GameObject Slot = Instantiate(PrefabEscolhido, Slot3.position, Slot3.rotation);
                    Slot.transform.parent = GDestroi.transform;
                    Slot.transform.localScale = new Vector3(1f, 1f, 1f);
                    CartaAleatoria();
                    return;
                }
                return;
            }
            if (numeroAleatorio == 2)//Carta de Dano
            {
                PrefabEscolhido = PrefabDano;
                PrefabEscolhido.name = ($"card2");
                
                if (objetoSpawnado == 1)
                {
                    cartaDeDano++;
                    
                    GameObject Slot = Instantiate(PrefabEscolhido, Slot1.position, Slot1.rotation);
                    Slot.transform.parent = GDestroi.transform;
                    Slot.transform.localScale = new Vector3(1f, 1f, 1f);
                    CartaAleatoria();
                    return;
                }
                if (objetoSpawnado == 2)
                {
                    cartaDeDano++;
                    
                    GameObject Slot = Instantiate(PrefabEscolhido, Slot2.position, Slot2.rotation);
                    Slot.transform.parent = GDestroi.transform;
                    Slot.transform.localScale = new Vector3(1f, 1f, 1f);
                    CartaAleatoria();
                    return;
                }
                if (objetoSpawnado == 3)
                {
                    cartaDeDano++;
                    
                    GameObject Slot = Instantiate(PrefabEscolhido, Slot3.position, Slot3.rotation);
                    Slot.transform.parent = GDestroi.transform;
                    Slot.transform.localScale = new Vector3(1f, 1f, 1f);
                    CartaAleatoria();
                    return;
                }
                return;
            }
            if (numeroAleatorio == 3)//Carte de Mana
            {
                PrefabEscolhido = PrefabMana;
                PrefabEscolhido.name = ($"card3");

                if (objetoSpawnado == 1)
                {
                    cartaDeMana++;
                    
                    GameObject Slot = Instantiate(PrefabEscolhido, Slot1.position, Slot1.rotation);
                    Slot.transform.parent = GDestroi.transform;
                    Slot.transform.localScale = new Vector3(1f, 1f, 1f);
                    CartaAleatoria();
                    
                }
                if (objetoSpawnado == 2)
                {
                    cartaDeMana++;
                    
                    GameObject Slot = Instantiate(PrefabEscolhido, Slot2.position, Slot2.rotation);
                    Slot.transform.parent = GDestroi.transform;
                    Slot.transform.localScale = new Vector3(1f, 1f, 1f);
                    CartaAleatoria();
                    
                }
                if (objetoSpawnado == 3)
                {
                    cartaDeMana++;
                    
                    GameObject Slot =Instantiate(PrefabEscolhido, Slot3.position, Slot3.rotation);
                    Slot.transform.parent = GDestroi.transform;
                    Slot.transform.localScale = new Vector3(1f, 1f, 1f);
                    CartaAleatoria();
                    
                }
                Destroy(Spawn.Instance.vazio);
                return;
            }
        }
    }
}
