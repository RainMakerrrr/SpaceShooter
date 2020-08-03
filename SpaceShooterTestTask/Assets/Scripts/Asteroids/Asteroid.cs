using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 6f;
    private GameScore _gameScore;
    private float _lifeTime;
    private float _maxLifeTime = 5f;

    private void Start()
    {
        _gameScore = FindObjectOfType<GameScore>();
    }
    private void OnEnable()
    {
        _lifeTime = 0f;
    }

    private void Update()
    {
        transform.Translate(Vector3.down * _moveSpeed * Time.deltaTime);

        _lifeTime += Time.deltaTime;
        if (_lifeTime > _maxLifeTime)
            AsteroidPool.Instance.ReturnToPool(this);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<PlayerStats>())
        {
            Debug.Log("Player was damaging");

            AudioManager.Instance.Play(1);
            AsteroidPool.Instance.ReturnToPool(this);

            other.gameObject.GetComponent<PlayerStats>().TakeDamage();
        }
        if (other.gameObject.GetComponent<Bullet>())
        {
            if(_gameScore.PlayerData.CountOfAsteroids < _gameScore.MaxCountForLevel) _gameScore.PlayerData.CountOfAsteroids++;
            _gameScore.UpdateScore();

            AudioManager.Instance.Play(1);

            ShotPool.Instance.ReturnToPool(other.gameObject.GetComponent<Bullet>());
            AsteroidPool.Instance.ReturnToPool(this);
        }
    }
}
