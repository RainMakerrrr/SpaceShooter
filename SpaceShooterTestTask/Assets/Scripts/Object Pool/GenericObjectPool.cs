using System.Collections.Generic;
using UnityEngine;

public abstract class GenericObjectPool<T> : MonoBehaviour where T : Component
{
    [SerializeField] private T _prefab;
    [SerializeField] private T[] _prefabs;
    private Queue<T> _objects = new Queue<T>();

    public static GenericObjectPool<T> Instance;

    private void Awake()
    {
        Instance = this;
    }

    public T Get()
    {
        if (_objects.Count == 0)
        {
            _prefab = _prefabs[Random.Range(0, _prefabs.Length)];
            AddObjects();
        }
        return _objects.Dequeue();
    }

    public void ReturnToPool(T objectToReturn)
    {
        objectToReturn.gameObject.SetActive(false);
        _objects.Enqueue(objectToReturn);
    }

    private void AddObjects()
    {
        var newObject = Instantiate(_prefab);
        newObject.gameObject.SetActive(false);
        _objects.Enqueue(newObject);
    }
}
