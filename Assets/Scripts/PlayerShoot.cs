
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public float bulletRate = 0.2f;
    public Transform shootingPoint;
    public GameObject tiroestPrefab;

    float timeUntilFire;
    PlayerController pc;
    public GameObject haveest;
    public AudioClip fire;

    private void Start()
    {
        pc = gameObject.GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) && timeUntilFire<Time.time)
        {
            if(haveest.activeSelf==true)
            Shoot();
            timeUntilFire = Time.time + bulletRate;
            AudioSource.PlayClipAtPoint(fire, transform.position);
        }
    }

    void Shoot()
    {
        float angle = pc.isFacingRight ? 0f : 180f;
        Instantiate(tiroestPrefab, shootingPoint.position, Quaternion.Euler(new Vector3(0f, 0f, angle)));
    }
}
