using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class movetotarget : MonoBehaviour
{

    private Transform target;
    public float maxspeed = 5.0f;
    public float CloseEnough = 0.5f;
    public float acceleration = 3.0f;
    Vector3 velocity = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Target").transform;
    }

    // Update is called once per frame
    void Update()
    {

        // Mover segueix target quan arribi al target para - si cambies el comentari es fa al reves, fugeix del mover
           
        Vector3 direction = transform.position - target.position;
        //Vector3 direction = target.position - transform.position;

        if (direction.magnitude > CloseEnough )
        {
            transform.position += direction.normalized * maxspeed * Time.deltaTime;
        }
        

        //Mover segueix target amb acceleració
        /*
        Vector3 direction = target.position - transform.position ;

        velocity += direction.normalized * acceleration *Time.deltaTime;
        if(velocity.magnitude>maxspeed)
        { velocity = direction.normalized * maxspeed; }

        target.position += velocity * Time.deltaTime;
        */
    }
}
