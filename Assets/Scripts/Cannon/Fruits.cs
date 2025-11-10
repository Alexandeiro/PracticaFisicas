using UnityEngine;

public class Fruits : MonoBehaviour
{

    [System.NonSerialized]
    public Rigidbody myRigidBody;
    private void Awake()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }

}
