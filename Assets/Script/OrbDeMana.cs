using Unity.VisualScripting;
using UnityEngine;

public class OrbDeMana : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Player") && Status.Instance.manaAtual <= Status.Instance.manaMaxima - 2)
        {
            Status.Instance.manaAtual += 2;
            BarraDaMana.Instance.tmManaAtul.text = ($"{Status.Instance.manaAtual}/{Status.Instance.manaMaxima}");
            Destroy(gameObject);
        }else if(c.CompareTag("Player") && Status.Instance.manaAtual == Status.Instance.manaMaxima - 1)
       {
            Status.Instance.manaAtual += 1;
            BarraDaMana.Instance.tmManaAtul.text = ($"{Status.Instance.manaAtual}/{Status.Instance.manaMaxima}");
            Destroy(gameObject);
        }
        return;
    }
    





    private void FixedUpdate()
    {
        Destroy(gameObject, 2);
    }
}
