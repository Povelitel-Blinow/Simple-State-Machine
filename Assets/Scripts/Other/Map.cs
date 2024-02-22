using UnityEngine;

public class Map : MonoBehaviour
{
    [SerializeField] private Transform[] _mapPoints;

    [SerializeField] private GameObject _tmp;

    public static Map Instance { get; private set; }

    public void Init()
    {
        if(Instance == null)
        {
            Instance = this;
            return;
        }
        Destroy(gameObject);
    }

    public Vector3 GetPoint()
    {
        Debug.Log("New Point");
        Transform point = _mapPoints[Random.Range(0, _mapPoints.Length)];

        _tmp.transform.position = point.position;
        return point.position;
    }
}
