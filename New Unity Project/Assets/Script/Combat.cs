using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    //private Animator anim;
    public float attackTime;
    public float startTimeAttack;

    public Transform player;
    Vector2 arrowstart;
    public float attackRange;
    public LayerMask enemies;

    private void Start()
    {
        //anim = GetComponent<Animator>();
        arrowstart = new Vector2(player.position.x,player.position.y);
    }

    void Update()
    {
        if( attackTime <= 0 )
        {
            if( Input.GetButton("Fire1"))
            {
                //anim.SetBool("Is_attacking", true);
                Collider2D[] damage = Physics2D.OverlapCircleAll( arrowstart = new Vector2(player.position.x,player.position.y), attackRange, enemies );
                Debug.Log("sword attack ");
                for (int i = 0; i < damage.Length; i++)
                {
                    Destroy( damage[i].gameObject );
                }
            }
            attackTime = startTimeAttack;
        }   else
        {
            attackTime -= Time.deltaTime;
            //anim.SetBool("Is_attacking", false);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(arrowstart, attackRange);
    }
}