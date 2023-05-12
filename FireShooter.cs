using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireShooter : MonoBehaviour
{
    public GameObject fireball;
    public float timer;

    void Start()
    {
        timer = 10f;
    }
    
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 5) //f means float
        {
            if (Input.GetMouseButton(0))
            {
                GameObject spawnedFireball = Instantiate(fireball, gameObject.transform);
                spawnedFireball.GetComponent<Rigidbody>().AddForce(transform.forward * 10f, ForceMode.Impulse);
                timer = 0f;
            }


        }
    }
}