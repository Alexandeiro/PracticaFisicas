using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10;
    public Vector3 startingPosition = new Vector3(9.31f, 2.21f, -18.29f);
    [System.NonSerialized]
    public Rigidbody myRigidBody;
    private Vector3 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        transform.position = startingPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        myRigidBody.AddForce(direction * movementSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {
        print("Has ganado!");
    }
}
