using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IABoss : MonoBehaviour
{
    public GameObject moeda;
    public GameObject target;
    public NavMeshAgent agent;
    public Animator anim;
    public Vector3 patrolposition;
    public SkinnedMeshRenderer render;
    bool isCreated;
    public float stoppedTime;
    public float patrolDistance = 10;
    public float timetowait = 3;
    public float distancetotrigger = 18;
    public float distancetoattack = 5;
    Transform t;
    public float fixedRotation = 5;
    public GameObject Hitbox;
    public enum States
    {
        pursuit,
        atacking,
        stoped,
        dead,
        damage,
        patrol,
        reborn,
    }

    public States state;

    // Start is called before the first frame update
    void Start()
    {
        Hitbox.SetActive(false);
        t = transform;
        patrolposition = new Vector3(transform.position.x + Random.Range(-patrolDistance, patrolDistance), transform.position.y, transform.position.z + Random.Range(-patrolDistance, patrolDistance));
    }

    // Update is called once per frame
    void Update()
    {
        t.eulerAngles = new Vector3(t.eulerAngles.x, fixedRotation, t.eulerAngles.z);
        StateMachine();
        anim.SetFloat("WalkCogu", agent.velocity.magnitude);

    }

    void StateMachine()
    {
        switch (state)
        {
            case States.pursuit:
                PursuitState();
                break;
            case States.atacking:
                AttackState();
                break;
            case States.stoped:
                StoppedState();
                break;
            case States.dead:
                DeadState();
                for (int i = 0; i < 1; i++)// dropa somente 1 item após morrer
                {
                    if (!isCreated)
                    {
                        Instantiate(moeda, transform.position, Quaternion.identity);
                        isCreated = true;
                    }

                }
                break;
            case States.damage:
                DamageState();
                break;

            case States.patrol:
                PatrolState();
                break;
            case States.reborn:
                RebornState();
                break;
        }
    }

    void ReturnPursuit()
    {
        state = States.pursuit;

    }
    public void Damage()
    {
        state = States.damage;
        Invoke("ReturnPursuit", 1);
        StartCoroutine(ReturnDamage());
    }
    IEnumerator ReturnDamage()
    {
        for (int i = 0; i < 4; i++)
        {
            render.material.EnableKeyword("_EMISSION");
            yield return new WaitForSeconds(0.05f);
            render.material.DisableKeyword("_EMISSION");
            yield return new WaitForSeconds(0.05f);
        }

    }

    public void Dead()
    {
        state = States.dead;
    }

    public void RebornState()
    {
        anim.SetBool("CoguReborn", true);
        anim.SetBool("CoguDead", false);
        state = States.patrol;
    }
    void PursuitState()
    {
        agent.isStopped = false;
        agent.destination = target.transform.position;
        anim.SetBool("CoguWalk", true);
        anim.SetBool("CoguAttack", false);
        anim.SetBool("CoguDano", false);
        if (Vector3.Distance(transform.position, target.transform.position) < distancetoattack)
        {
            state = States.atacking;
        }
        if (Vector3.Distance(transform.position, target.transform.position) > distancetotrigger)
        {
            state = States.patrol;
        }
    }

    void AttackState()
    {
        agent.isStopped = true;
        StartCoroutine(HitboxSpawn());
        anim.SetBool("CoguDano", false);
        if (Vector3.Distance(transform.position, target.transform.position) > distancetoattack + 1)
        {
            state = States.pursuit;
        }
    }

    void StoppedState()
    {
        agent.isStopped = true;
        anim.SetBool("CoguWalk", false);
        anim.SetBool("CoguAttack", false);
        anim.SetBool("CoguDano", false);

    }

    void DeadState()
    {
        agent.isStopped = true;
        anim.SetBool("CoguDead", true);
        anim.SetBool("CoguWalk", false);
        anim.SetBool("CoguAttack", false);
        anim.SetBool("CoguDano", false);
    }

    void DamageState()
    {
        agent.isStopped = true;
        anim.SetBool("CoguDano", true);
        anim.SetBool("CoguWalk", false);
        anim.SetBool("CoguDano", true);
    }

    void PatrolState()
    {
        agent.isStopped = false;
        agent.SetDestination(patrolposition);
        anim.SetBool("CoguAttack", false);
        //tempo parado
        if (agent.velocity.magnitude < 0.1f)
        {
            stoppedTime += Time.deltaTime;
            anim.SetBool("CoguWalk", false);
        }
        //se for mais q timetowait segundos
        if (stoppedTime > timetowait)
        {
            stoppedTime = 0;
            patrolposition = new Vector3(transform.position.x + Random.Range(-patrolDistance, patrolDistance), transform.position.y, transform.position.z + Random.Range(-patrolDistance, patrolDistance));
        }
        //ditancia do jogador for menor q distancetotrigger
        if (Vector3.Distance(transform.position, target.transform.position) < distancetotrigger)
        {
            state = States.pursuit;
        }
    }
    IEnumerator HitboxSpawn()
    {
        anim.SetBool("CoguAttack", true);
        yield return new WaitForSeconds(0.8f);
        Hitbox.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Hitbox.SetActive(false);
    }

}
