using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCommander : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigitbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DestroyAfterLeftScreen()
    {
        if (transform.position.y > 6f )
        {
            Destroy(gameObject);
        }
    }


}


