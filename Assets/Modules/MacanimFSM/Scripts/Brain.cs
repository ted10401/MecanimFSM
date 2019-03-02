using UnityEngine;
using UnityEngine.AI;

namespace MacanimFSM
{
    [RequireComponent(typeof(NavMeshAgent), typeof(WaypointComponent))]
    public class Brain : MonoBehaviour
    {
        public readonly int PATROL_STATE_HASH = Animator.StringToHash("PatrolState");
        private readonly int TARGET_DISTANCE_HASH = Animator.StringToHash("TargetDistance");
        private readonly int RESET_DISTANCE_HASH = Animator.StringToHash("ResetDistance");

        public NavMeshAgent navMeshAgent;
        public WaypointComponent waypointComponent;
        public Animator fsmAnimator;
        public Vector3 resetPosition;

        private Transform m_transform;

        private void Reset()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
            waypointComponent = GetComponent<WaypointComponent>();
        }

        private void Awake()
        {
            m_transform = transform;
        }

        private void Update()
        {
            fsmAnimator.SetFloat(TARGET_DISTANCE_HASH, Vector3.Distance(m_transform.position, PlayerTransform.Player.position));
            fsmAnimator.SetFloat(RESET_DISTANCE_HASH, Vector3.Distance(m_transform.position, resetPosition));
        }
    }
}