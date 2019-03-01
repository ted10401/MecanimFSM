using UnityEngine;

namespace MacanimFSM
{
    public class WaypointComponent : MonoBehaviour
    {
        public Transform[] waypoints;

        public Transform GetRandomWaypoint()
        {
            if (waypoints == null || waypoints.Length == 0)
            {
                return null;
            }

            return waypoints[Random.Range(0, waypoints.Length)];
        }
    }
}