using UnityEngine;

public class MobController : MonoBehaviour {

    public Mob mob;

    int waypointIndex = 0;
    Transform nextWaypoint;
    public int speed = 1;


    void Start() {

        // Add sprite
        gameObject.GetComponent<SpriteRenderer>().sprite = mob.mobImage;

        // Add collider
        BoxCollider2D bc = gameObject.AddComponent<BoxCollider2D>();
        nextWaypoint = Waypoints.points[waypointIndex];
    }


    // Get the next Waypoint
    void GetNextWaypoint() {
        waypointIndex++;
        nextWaypoint = Waypoints.points[waypointIndex];
        Debug.Log("heading to position: " + nextWaypoint);
    }


    void Update() {
        Walk();
    }


    void Walk() {

        // face stuff.  TODO make this work
        //Vector3 directonToFace = nextWaypoint.position - transform.position;
        //Quaternion lookRotation = Quaternion.LookRotation(directonToFace);
        //Vector3 rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        //transform.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        // Pick direction and move
        Vector2 direction = nextWaypoint.transform.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (Vector2.Distance(transform.position, nextWaypoint.position) <= 0.2f) {
            GetNextWaypoint();
        }

    }


}
