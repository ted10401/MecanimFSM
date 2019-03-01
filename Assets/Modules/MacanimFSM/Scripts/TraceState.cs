using UnityEngine;

namespace MacanimFSM
{
    public class TraceState : BaseState
    {
        protected override void OnStateEntered()
        {
            if(PlayerTransform.Player == null)
            {
                m_animator.SetTrigger(m_brain.PATROL_STATE_HASH);
            }
        }

        protected override void OnStateUpdated()
        {
            if (PlayerTransform.Player == null)
            {
                m_animator.SetTrigger(m_brain.PATROL_STATE_HASH);
            }

            if(Vector3.Distance(m_brain.navMeshAgent.transform.position, PlayerTransform.Player.position) > m_brain.traceRange)
            {
                m_animator.SetTrigger(m_brain.PATROL_STATE_HASH);
            }
            else
            {
                m_brain.navMeshAgent.SetDestination(PlayerTransform.Player.position);
            }
        }
    }
}