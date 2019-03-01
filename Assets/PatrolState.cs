using UnityEngine;

public class PatrolState : BaseStateMachineBehaviour
{
    private Transform m_transform;
    private WaypointComponent m_waypointComponent;
    private Transform m_target;

    protected override void OnStateEntered()
    {
        if (m_waypointComponent == null)
        {
            m_transform = m_animator.transform;
            m_waypointComponent = m_animator.gameObject.GetComponent<WaypointComponent>();
            m_target = m_waypointComponent.GetRandomWaypoint();
        }
    }

    protected override void OnStateUpdated()
    {
        if(m_target == null)
        {
            return;
        }

        m_transform.position = Vector3.Lerp(m_transform.position, m_target.position, Time.deltaTime);

        if(Vector3.Distance(m_transform.position, m_target.position) < 0.5f)
        {
            m_target = m_waypointComponent.GetRandomWaypoint();
        }
    }
}
