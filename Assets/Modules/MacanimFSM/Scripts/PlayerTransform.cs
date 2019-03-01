using UnityEngine;

public class PlayerTransform : MonoBehaviour
{
    public static Transform Player;

    private void Awake()
    {
        Player = transform;
    }
}
