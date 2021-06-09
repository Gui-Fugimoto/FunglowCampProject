using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 
    public GameObject player;
     //public AudioClip[] audios;

   // AudioSource audio;
     

    private string moveInputAxis = "Vertical";
    private string turnInputAxis = "Horizontal";
    public float moveSpeed = 1;
    public float dashDuration = 1;



   

    void Start()
    {
        //GameObject child = player.transform.Find("Sound Esquiva").gameObject;
       
        //audio = player.Transform<AudioSource>(SoundEsquiva);
      
    }

    // Update is called once per frame
    void Update()
    {

        float moveAxis = Input.GetAxis(moveInputAxis);
        float turnAxis = Input.GetAxis(turnInputAxis);
       

        ApplyInput(moveAxis, turnAxis);
       
        if (Input.GetKeyUp("space"))
        {
            StartCoroutine(RollSpeed());
           
        }


        //  move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    
    IEnumerator RollSpeed()
    {
        GameObject child = player.transform.Find("Sound Esquiva").gameObject;
        child.GetComponent<AudioSource>().Play();
        moveSpeed = 0.3f;
        yield return new WaitForSeconds(dashDuration);
        moveSpeed = 0.1f;
    }

    private void ApplyInput(float moveInput,
                            float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
       
    }


    private void Move(float input)
    {
        transform.Translate(Vector3.forward * input * moveSpeed);

        GameObject child = player.transform.Find("Sound Footsteps").gameObject;
        child.GetComponent<AudioSource>().Play();
    }
    private void Turn(float input)
    {
        transform.Translate(Vector3.right * input * moveSpeed);
      
    }
}
