using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Transform pivot;
    [SerializeField] private Transform spawnPosition;
    [SerializeField] private Fruits fruitPrefab;

    [SerializeField] private float speedRotation = 100;
    [SerializeField] private float cannonForce = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Control del cañon
        pivot.Rotate(Vector3.up, Input.GetAxis("Horizontal") * Time.deltaTime * speedRotation, Space.World);
        pivot.Rotate(Input.GetAxis("Vertical") * Time.deltaTime * speedRotation * Vector3.back);
        Debug.DrawRay(pivot.position, pivot.up * 10, Color.yellow);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Fruits fruit = Instantiate(fruitPrefab, spawnPosition.position, Quaternion.identity);
            Vector3 shootDirection = spawnPosition.position - pivot.position;
            fruit.myRigidBody.AddForce(shootDirection * cannonForce);
        }
    }
}
