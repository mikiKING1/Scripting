using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;

    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        transform.LookAt(target.position) ;
    {

        private void OnTriggerEnter(Collider other)
    }
        Player player = other.GetComponent.<player>();

        player.TakeDamege(playerDamege);
    }
}





