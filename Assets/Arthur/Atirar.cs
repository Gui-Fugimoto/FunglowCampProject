using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour
{
    float tirospeed = 1100;
    public GameObject bulletEs;
    public GameObject haveEs;

    AudioSource somTiro;
    void Start()
    {
        somTiro = GetComponent<AudioSource>();
    }

    void Atirou()
    {
        //Atirando
        GameObject tempBulletEs = Instantiate(bulletEs, transform.position, transform.rotation) as GameObject;
        Rigidbody tempRigidBodyBulletEs = tempBulletEs.GetComponent<Rigidbody>();
        tempRigidBodyBulletEs.AddForce(tempRigidBodyBulletEs.transform.right * tirospeed);
        Destroy(tempBulletEs , 0.5f);

        //Som do Tiro
        somTiro.Play();
    }
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && (haveEs.activeSelf == true))
        {
            Atirou();
        }
    }
}
