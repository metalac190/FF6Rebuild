using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> where T : Component
{
    T _prefabToPool;
    Transform _parent;
    int _startSize;

    protected Queue<T> Pool = new Queue<T>();

    public ObjectPool(T prefabToPool, Transform parent, int startSize)
    {
        _prefabToPool = prefabToPool;
        _parent = parent;
        _startSize = startSize;

        CreateStartingPool();
    }

    public T GetObject()
    {
        if (Pool.Count == 0)
            CreateNewPoolObject();

        T newPoolObject = Pool.Dequeue();
        newPoolObject.gameObject.SetActive(true);

        return newPoolObject;
    }

    public void ReturnObject(T poolObject)
    {
        poolObject.gameObject.SetActive(false);
        Pool.Enqueue(poolObject);
    }

    void CreateStartingPool()
    {
        for (int i = 0; i < _startSize; i++)
        {
            CreateNewPoolObject();
        }
    }

    void CreateNewPoolObject()
    {
        T newObject = GameObject.Instantiate(_prefabToPool);

        newObject.transform.SetParent(_parent);
        newObject.gameObject.name = _prefabToPool.gameObject.name;
        newObject.gameObject.SetActive(false);
        Pool.Enqueue(newObject);
    }
}
