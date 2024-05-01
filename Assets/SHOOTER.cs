using UnityEngine;

public class shooter : MonoBehaviour
{
    public float ballspeed = 20f;

   
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Kick(other.gameObject);
        }
    }

    void Kick(GameObject ball)
    {
        
        Vector3 kickDirection = (ball.transform.position - transform.position).normalized;

       
        if (kickDirection.y < 0)
        {
            kickDirection.y = 0; 
            kickDirection.Normalize(); 
        }

        
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.velocity = kickDirection * ballspeed;
    }
}
