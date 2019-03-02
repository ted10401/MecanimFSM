
namespace MacanimFSM
{
    public class TraceState : BaseState
    {
        protected override void OnStateEntered()
        {
            m_brain.resetPosition = m_brain.transform.position;
        }

        protected override void OnStateUpdated()
        {
            m_brain.navMeshAgent.SetDestination(PlayerTransform.Player.position);
        }
    }
}