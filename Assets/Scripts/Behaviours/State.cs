using UnityEngine;

public abstract class State : ScriptableObject
{
    public bool IsFinished { get; protected set; }

    protected UFO _ufo;

    public virtual void Init(UFO ufo) => _ufo = ufo;

    public abstract void Run();
}
