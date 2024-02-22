using UnityEngine;

[RequireComponent(typeof(UFOMove))]
[RequireComponent(typeof(UFOStateMachine))]
public class UFO : MonoBehaviour
{
    [SerializeField] private UFOMove _move;
    [SerializeField] private UFOStateMachine _stateMachine;

    public void Init()
    {
        _stateMachine.Init(this);
    }

    private void Update()
    {
        _stateMachine.UpdateState();
        Move();
    }

    public void Move() => _move.Move();
    public void Aim(Vector3 target) => _move.Aim(target);

    public float CalculateDistanceTo(Vector3 pos) => _move.CalculateDistanceTo(pos);

    private void OnValidate()
    {
        _move ??= GetComponent<UFOMove>();
        _stateMachine ??= GetComponent<UFOStateMachine>();
    }
}
