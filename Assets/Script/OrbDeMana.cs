using UnityEngine;

public class OrbDeMana : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Player"))
        {
            Status.Instance.manaAtual += 2;
            BarraDaMana.Instance.tmManaAtul.text = ($"{Status.Instance.manaAtual}/{Status.Instance.manaMaxima}");
            Destroy(gameObject);
        }
    }
}
