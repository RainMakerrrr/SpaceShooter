using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;
    private float _lifeTime;
    private float _maxLifeTime = 3f;

    private void OnEnable()
    {
        _lifeTime = 0f;
    }
    private void Update()
    {
        transform.Translate(Vector3.up * _moveSpeed * Time.deltaTime);

        _lifeTime += Time.deltaTime;
        if (_lifeTime > _maxLifeTime)
            ShotPool.Instance.ReturnToPool(this);  
    }

  
}
