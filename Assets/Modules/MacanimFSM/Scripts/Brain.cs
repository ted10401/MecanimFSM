using UnityEngine;
using UnityEngine.AI;

namespace MacanimFSM
{
    [RequireComponent(typeof(NavMeshAgent), typeof(WaypointComponent))]
    public class Brain : MonoBehaviour
    {
        public readonly int PATROL_STATE_HASH = Animator.StringToHash("PatrolState");
        public readonly int TRACE_STATE_HASH = Animator.StringToHash("TraceState");

        public NavMeshAgent navMeshAgent;
        public WaypointComponent waypointComponent;
        public float patrolRange = 5f;
        public float traceRange = 10f;

        private void Reset()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
            waypointComponent = GetComponent<WaypointComponent>();
        }
    }
}