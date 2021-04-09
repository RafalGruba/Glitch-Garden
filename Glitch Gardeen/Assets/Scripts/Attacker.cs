using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range (0f, 5f)] float currentSpeed = 1f;
    GameObject currentTarger;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }

    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarger = target;
    }
}
