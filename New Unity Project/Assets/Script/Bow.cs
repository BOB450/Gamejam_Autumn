using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public GameObject arrow;
    public float attackTime;
    public float startTimeAttack;
    public Transform playerpos;
      public float speed = 1.0f;

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkedinput();
        move();
    }

    void checkedinput(){
        if(attackTime <= 0){
        if(Input.GetButton("Fire2"))
        {
            Debug.Log("bow attack ");
             Instantiate(arrow, new Vector3(playerpos.position.x,playerpos.position.y,-4), Quaternion.identity);
            move();
        }
        attackTime = startTimeAttack;
        }
        else{
            attackTime -= Time.deltaTime;
        }
    }

    void move(){
               float step =  speed * Time.deltaTime; // calculate distance to move
        arrow.transform.position = Vector3.MoveTowards(arrow.transform.position, target.position, step);
    }

}
