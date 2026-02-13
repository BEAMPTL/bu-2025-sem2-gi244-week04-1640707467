using UnityEngine;

public class Food : MonoBehaviour
{
    public int attackPoint = 5;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit" + other.gameObject);
        var health = other.gameObject.GetComponent<HeealthV1>();
        health.TakeDamage(attackPoint);
    }
}
