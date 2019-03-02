
namespace MacanimFSM
{
    public class TraceState : BaseState
    {
        protected override void OnStateUpdated()
        {
            m_brain.navMeshAgent.SetDestination(PlayerTransform.Player.position);
        }
    }
}