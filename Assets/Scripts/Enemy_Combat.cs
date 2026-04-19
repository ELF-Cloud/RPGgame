using Cinemachine.Utility;
using TreeEditor;
using UnityEngine;

public class Enemy_Combat : MonoBehaviour
{
    public Transform attackPoint;
    public float weaponRange;
    public float knockbackForce;
    public float stunTime;
    public LayerMask playerLayer;
    public int damage = 1;


    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.gameObject.tag == "Player")
    //     {
    //         collision.gameObject.GetComponent<PlayerHeaths>().changeHealth(-damage);
    //     }
    // }
    public void Attack()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll( attackPoint.position, weaponRange, playerLayer);

        if (hits.Length > 0)
        {
            hits[0].GetComponent<PlayerHeaths>().changeHealth(-damage);
            hits[0].GetComponent<PlayerMovement>().Knockback (transform, knockbackForce, stunTime);
        }
    }
}