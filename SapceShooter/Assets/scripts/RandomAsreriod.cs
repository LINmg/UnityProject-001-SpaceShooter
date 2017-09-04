using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAsreriod : MonoBehaviour {
    private Rigidbody rb;
    private Transform ts;
    private GameManage gm;
    public GameObject explosion;
    public GameObject explosion_player;
    public float speed = 2;
	// Use this for initialization
	void Start () {
        ts = gameObject.GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * 5;
        rb.velocity = -ts.forward * 5;
        gm = GameObject.Find("UI").GetComponent<GameManage>();
	}
   
    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "Bolt") {
            Destroy(Other.gameObject);
            Destroy(this.gameObject);
            Instantiate(explosion, ts.position, Quaternion.identity);
            gm.AddScore(1);
        }else if (Other.gameObject.tag == "Player")
        {
            Destroy(Other.gameObject);
            Destroy(this.gameObject);
            Instantiate(explosion_player, ts.position, Quaternion.identity);
            gm.End();
        }
    }
}
