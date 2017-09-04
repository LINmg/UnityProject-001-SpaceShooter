using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerManage : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject go;
    private GameObject go_clone;
    public Transform shoot;
    public GameObject explosion;
    private AudioSource au;
    public float speed = 10f;
    public float x_min = -6.5f;
    public float x_max = 6.5f;
    public float z_min = -7f;
    public float z_max = 7f;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        shoot = GameObject.Find("shoot").GetComponent<Transform>();
        au = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            go_clone = Instantiate(go, shoot.position, Quaternion.identity);
            go_clone.GetComponent<Transform>().SetParent(shoot);
            au.PlayOneShot(au.clip, 0.5f);
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(h, 0f, v);
        rb.velocity = speed * move;
        rb.position = new Vector3(Mathf.Clamp(rb.position.x, x_min, x_max),
            0f, Mathf.Clamp(rb.position.z, z_min, z_max));
        if ( h != 0)
        {
            rb.angularVelocity = new Vector3(0,0,h * speed );
        }
    }
   

}
