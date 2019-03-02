
namespace MacanimFSM
{
    public class ResetState : BaseState
    {
        protected override void OnStateEntered()
        {
            m_brain.navMeshAgent.SetDestination(m_brain.resetPosition);
        }

        protected override void OnStateUpdated()
        {
            if(m_brain.navMeshAgent.remainingDistance < 0.5f)
            {
                m_animator.SetTrigger(m_brain.PATROL_STATE_HASH);
            }
        }
    }
}