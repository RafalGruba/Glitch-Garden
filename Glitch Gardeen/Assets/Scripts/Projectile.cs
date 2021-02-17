using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float speedOfSpin = -180f;
    [SerializeField] float damage = 50f;


    void Update()
    {
        transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        transform.Rotate(0, 0, speedOfSpin * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var health = otherCollider.GetComponent<Health>();
        var attacker = otherCollider.GetComponent<Attacker>();
        if(attacker && health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
    }

}
