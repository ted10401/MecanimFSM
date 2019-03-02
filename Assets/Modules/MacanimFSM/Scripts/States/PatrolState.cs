using UnityEngine;

namespace MacanimFSM
{
    public class PatrolState : BaseState
    {
        private Transform m_target;

        protected override void OnStateEntered()
        {
            m_target = m_brain.waypointComponent.GetRandomWaypoint();
            m_brain.navMeshAgent.SetDestination(m_target.position);
        }

        protected override void OnStateUpdated()
        {
            if (m_brain.navMeshAgent.remainingDistance < 0.5f)
            {
                OnStateEntered();
            }
        }
    }

}