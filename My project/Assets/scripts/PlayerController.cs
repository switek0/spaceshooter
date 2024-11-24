using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{ public Transform
    public Transform

    public GameObject bulletPrefab;
    public Transform gunPosition;

    // Start is called before the first frame update
    void Start()
    {





    }

    // Update is called once per frame
    void Update()
    {




      
    }

    void Shoot()
    {
        Instatiate(bulletPrefab, GunEndposition, Quaternion.identity);
    }
}
