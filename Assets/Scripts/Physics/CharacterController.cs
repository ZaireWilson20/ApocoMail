using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Rigidbody2D rb; 

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(Vector3 veloc)
    {
        rb.velocity = new Vector3(veloc.x + rb.velocity.x, veloc.y + rb.velocity.y, 0) * Time.deltaTime;

    }

}
