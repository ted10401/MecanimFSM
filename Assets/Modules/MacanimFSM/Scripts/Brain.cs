using UnityEngine;
using UnityEngine.AI;

namespace MacanimFSM
{
    [RequireComponent(typeof(NavMeshAgent), typeof(WaypointComponent))]
    public class Brain : MonoBehaviour
    {
        private readonly int PLAYER_DISTANCE_HASH = Animator.StringToHash("TargetDistance");

        public NavMeshAgent navMeshAgent;
        public WaypointComponent waypointComponent;
        public Animator fsmAnimator;

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
            fsmAnimator.SetFloat(PLAYER_DISTANCE_HASH, Vector3.Distance(m_transform.position, PlayerTransform.Player.position));
        }
    }
}