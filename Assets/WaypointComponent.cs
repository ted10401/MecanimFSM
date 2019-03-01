using UnityEngine;

public class WaypointComponent : MonoBehaviour
{
    [SerializeField] private Transform[] m_waypoints;

    public Transform GetRandomWaypoint()
    {
        if(m_waypoints == null || m_waypoints.Length == 0)
        {
            return null;
        }

        return m_waypoints[Random.Range(0, m_waypoints.Length)];
    }
}
