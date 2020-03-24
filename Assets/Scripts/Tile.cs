using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Transform _nextPosition;

    public Transform GetSpawnPosition() 
    {
        return _nextPosition;
    }
}
