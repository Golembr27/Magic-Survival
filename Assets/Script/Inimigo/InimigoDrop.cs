using UnityEngine;

public class InimigoDrop : MonoBehaviour
{
    Transform Inimigo;
    public GameObject mana;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Inimigo = GameObject.Find("Inimigo(Clone)").transform.GetComponent<Transform>();
    }

    void DropMana()
    {
        if(StatusInimigo.Instance.vidaAtual <= 0)
        {
            Instantiate(mana, Inimigo.position, Inimigo.rotation);
        }
    }
}
