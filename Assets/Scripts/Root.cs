using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField] private UFO _ufo;
    [SerializeField] private Map _map;

    private void Awake()
    {
        _map.Init();

        _ufo.Init();
    }
}
