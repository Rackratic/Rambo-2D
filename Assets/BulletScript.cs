using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 Direction;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //rb.velocity = Vector2.right * speed;
        rb.velocity = Direction * speed;
    }

    public void SetDirection(Vector2 direction) 
    {
        Direction = direction; // El valor Vector2 que te mande desde fuera, conviértelo en Direction y aplica la fórmuala de arriba 
    }
}
