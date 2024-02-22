using UnityEngine;

public class UFOMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;

    /// <summary>
    /// Add it to an angle to look straight forward on a target
    /// </summary>
    private const float StraightOffset = -90;

    /// <summary>
    /// Add it to an angle to be parallel to a target
    /// </summary>
    private const float ParallelOffset = 0;

    public float CalculateDistanceTo(Vector3 targetPos)
    {
        return (targetPos - transform.position).magnitude;
    }

    public void Move()
    {
        transform.position += transform.up * _moveSpeed * Time.deltaTime;
    }

    public void Aim(Vector3 targetPos)
    {
        Vector2 direction = targetPos - transform.position;

        if (direction != Vector2.zero)
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.Slerp
                (
                transform.rotation,
                Quaternion.AngleAxis(angle + StraightOffset, Vector3.forward),
                _rotateSpeed * Time.deltaTime
                );
        }
    }
}
