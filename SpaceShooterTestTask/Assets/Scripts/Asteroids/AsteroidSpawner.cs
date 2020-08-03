using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] private float _respawnRate = 5f;
    private float _respawnTime = 0f;

    private void Update()
    {
        _respawnTime += Time.deltaTime;
        if(_respawnTime > _respawnRate)
        {
            _respawnTime = 0f;
            Spawn();
        }
    }

    private void Spawn()
    {
        var asteroid = AsteroidPool.Instance.Get();
        asteroid.transform.position = new Vector3(Random.Range(-7.5f, 7.5f), 6f, 0f);
        asteroid.transform.rotation = Quaternion.identity;
        asteroid.gameObject.SetActive(true);
    }
}
