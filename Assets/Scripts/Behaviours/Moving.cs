using UnityEngine;

[CreateAssetMenu(fileName = "MoveState", menuName = "States/MoveState")]
public class Moving : State
{
    [SerializeField] private float _finishDistance;

    private Vector3 _targetPos;

    public override void Init(UFO ufo)
    {
        _ufo = ufo;
        _targetPos = Map.Instance.GetPoint();    
    }

    public override void Run()
    {
        if (_ufo.CalculateDistanceTo(_targetPos) <= _finishDistance)
        {
            IsFinished = true;
            return;
        }

        _ufo.Aim(_targetPos);
    }
}
