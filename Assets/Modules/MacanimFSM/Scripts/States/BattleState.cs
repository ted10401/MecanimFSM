
namespace MacanimFSM
{
    public class BattleState : BaseState
    {
        protected override void OnStateEntered()
        {
            m_brain.navMeshAgent.SetDestination(m_brain.transform.position);
        }
    }
}