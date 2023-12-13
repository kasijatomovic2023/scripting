using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transorm target;
    public int playerDamage

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        transform.LookAt(target.position);

    {
    
    private void OnTriggerEnter(Collinder other)
            
    }

        {
            Player player = other.GetComponent<player>();

            player.TakeDamage(playerDamage); 
            
    }
}
