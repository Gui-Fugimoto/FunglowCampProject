using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator anim;
    public IACogumelo iastar;

    public int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health < 1)
        {
            iastar.Dead();
            StartCoroutine(RebornTime());
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("inimigo levou dano");
        iastar.Damage();
    }
    IEnumerator RebornTime()
    {
        yield return new WaitForSeconds(25f);
        health = 3;
        iastar.RebornState();
    }
}
