using UnityEngine;

public class UFOStateMachine : MonoBehaviour
{
    [SerializeField] private State _moving;

    private State _currentState;
    private UFO _ufo;

    public void Init(UFO ufo)
    {
        _ufo = ufo;

        SetState(_moving);
    }

    public void UpdateState()
    {
        if(_currentState.IsFinished) SetState(_moving);

        _currentState.Run();
    }

    public void SetState(State state)
    {
        _currentState = Instantiate(state);
        _currentState.Init(_ufo);
    }
}
