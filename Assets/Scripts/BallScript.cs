using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] float speedMultiplier;
    [SerializeField] Material m1;
    [SerializeField] Material m2;
    TrailRenderer StarTrail;
    Rigidbody rb;

    private int directie;
    Vector3 lastVelocity;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        StarTrail = GetComponent<TrailRenderer>();


        directie = Random.Range(0, 2);
        if (directie == 0)
        {
            directie = -1;
        }
    }
    void Start()
    {
        rb.AddForce(new Vector2(directie, 0) * 1200f);
    }

    private void Update()
    {
        lastVelocity = rb.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal) * lastVelocity.magnitude;

        if (collision.collider.tag == "wall")
        {
            Debug.Log("+1 point player");
        }

        else if (collision.collider.tag == "Player")
        {
            rb.velocity *= 1.08f;
            Debug.Log("speed = " + rb.velocity.magnitude);

            if (collision.collider.name == "Player")
            {
                StarTrail.material = m1;

            }
            else if (collision.collider.name == "Opponent")
            {
                StarTrail.material = m2;
            }
        }
    }
}
