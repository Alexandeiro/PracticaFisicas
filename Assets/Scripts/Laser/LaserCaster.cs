using UnityEngine;

public class LaserCaster : MonoBehaviour
{
    [SerializeField] private Player player;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 100 * Time.deltaTime, 0);
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward, Color.black);
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Debug.DrawLine(transform.position, hit.point, Color.red);
            if (hit.collider.tag == "Player")
            {
                print("Detectado!");
                player.transform.position = player.startingPosition;
            }
        }

    }
}
