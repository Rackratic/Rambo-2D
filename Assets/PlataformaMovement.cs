using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovement : MonoBehaviour
{
    public Transform Target;
    public float speed;

    private Vector3 start, end;
    // Start is called before the first frame update
    void Start()
    {
        if (Target != null) 
        {
            Target.parent = null;
            start = transform.position;
            end = Target.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(Target != null) // Siempre tendremos un Target por lo que siempre entraremos aquí y siempre se moverá la plataforma
        {
            float fixedSpeed = speed * Time.deltaTime; // A una velocidad determinada y tiempo constante, poco a poco avanza
            transform.position = Vector3.MoveTowards(transform.position, Target.position, fixedSpeed); // Ve desde donde estés al Target
        }

        if (transform.position == Target.position) 
        {
            Target.position = (Target.position == start) ? end : start;
        }
    }
}
