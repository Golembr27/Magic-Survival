using NUnit.Framework.Constraints;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.GPUSort;

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

    public GameObject PrefabVida;
    public GameObject PrefabDano;
    public GameObject PrefabMana;

    GameObject PrefabEscolhido;

    [SerializeField] int objetoMaximo = 4;
    public int objetoSpawnado = 1;

    public int totalNumeros = 0;

    public int numeroAleatorio;

    Vector2 posicaoObjecto;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void Finalizado()
    {
        if(objetoSpawnado == objetoMaximo)
        {
            objetoSpawnado = 1;
        }
    }

    public void CartaAleatoria()
    {
        objetoSpawnado++;
        numeroAleatorio = Random.Range(1, 4);
        Debug.Log($"Número aleatorio é: {numeroAleatorio}");
        Debug.Log($"Número do obejetoSpawn é: {objetoSpawnado}");
        if (objetoSpawnado <= objetoMaximo)
        {
            if (numeroAleatorio == 1)
            {
                PrefabEscolhido = PrefabVida;
                
                if (objetoSpawnado == 1)
                {
                    GameObject Slot = Instantiate(PrefabEscolhido, Slot1.position, Slot1.rotation);
                    Slot.transform.parent = Slot1.transform;
                    Slot.transform.localScale = new Vector3(1f, 1f, 1f);
                    CartaAleatoria();
                }
                if (objetoSpawnado == 2)
                {
                    GameObject Slot = Instantiate(PrefabEscolhido, Slot2.position, Slot2.rotation);
                    Slot.transform.parent = Slot2.transform;
                    Slot.transform.localScale = new Vector3(1f, 1f, 1f);
                    CartaAleatoria();
                }
                if (objetoSpawnado == 3)
                {
                    GameObject Slot = Instantiate(PrefabEscolhido, Slot3.position, Slot3.rotation);
                    Slot.transform.parent = Slot3.transform;
                    Slot.transform.localScale = new Vector3(1f, 1f, 1f);
                    CartaAleatoria();
                }
                return;
            }
            if (numeroAleatorio == 2)
            {
                PrefabEscolhido = PrefabDano;
                
                if (objetoSpawnado == 1)
                {
                    GameObject Slot = Instantiate(PrefabEscolhido, Slot1.position, Slot1.rotation);
                    Slot.transform.parent = Slot1.transform;
                    Slot.transform.localScale = new Vector3(1f, 1f, 1f);
                    CartaAleatoria();
                }
                if (objetoSpawnado == 2)
                {
                    GameObject Slot = Instantiate(PrefabEscolhido, Slot2.position, Slot2.rotation);
                    Slot.transform.parent = Slot2.transform;
                    Slot.transform.localScale = new Vector3(1f, 1f, 1f);
                    CartaAleatoria();
                }
                if (objetoSpawnado == 3)
                {
                    GameObject Slot = Instantiate(PrefabEscolhido, Slot3.position, Slot3.rotation);
                    Slot.transform.parent = Slot3.transform;
                    Slot.transform.localScale = new Vector3(1f, 1f, 1f);
                    CartaAleatoria();
                }
                return;
            }
            if (numeroAleatorio == 3)
            {
                PrefabEscolhido = PrefabMana;
                
                if (objetoSpawnado == 1)
                {
                    GameObject Slot = Instantiate(PrefabEscolhido, Slot1.position, Slot1.rotation);
                    Slot.transform.parent = Slot1.transform;
                    Slot.transform.localScale = new Vector3(1f, 1f, 1f);
                    CartaAleatoria();
                }
                if (objetoSpawnado == 2)
                {
                    GameObject Slot = Instantiate(PrefabEscolhido, Slot2.position, Slot2.rotation);
                    Slot.transform.parent = Slot2.transform;
                    Slot.transform.localScale = new Vector3(1f, 1f, 1f);
                    CartaAleatoria();
                }
                if (objetoSpawnado == 3)
                {
                    
                    GameObject Slot =Instantiate(PrefabEscolhido, Slot3.position, Slot3.rotation);
                    Slot.transform.parent = Slot3.transform;
                    Slot.transform.localScale = new Vector3(1f, 1f, 1f);
                    CartaAleatoria();
                    return;
                }
                Finalizado();
            }
        }
    }
}
