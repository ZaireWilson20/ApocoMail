using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float move_speed;
    [SerializeField]
    private float diag_speed; 
    private Vector3 input;


    public GameObject interaction_bubble; 
    

    private CharacterController char_cont; 
    // Start is called before the first frame update
    void Start()
    {
        char_cont = this.GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);

    }

    private void FixedUpdate()
    {
        if (input.x != 0 && input.y != 0)
        {
            char_cont.Move(input * move_speed * (diag_speed / 100));
        }
        else
        {
            char_cont.Move(input * move_speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Character" || collision.tag == "PickUp")
        {
            interaction_bubble.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Character" || collision.tag == "PickUp")
        {
            interaction_bubble.SetActive(false);
        }
    }
}
