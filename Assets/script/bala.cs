using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public int force;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DoShoot();
        }
    }

    void DoShoot()
    {
        GameObject instanciatedBullet = Instantiate(bullet, this.transform.position, this.transform.rotation);
        instanciatedBullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
    }
}