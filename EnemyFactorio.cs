using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemyFactorio : IEnemyFactorio
{
    private readonly DiContainer diContainer;
    private GameObject _sphere;

    public void Load()
    {
        _sphere = Resources.Load("Sphere") as GameObject;
    }

    public void Create(GameObject _enemySphere, Vector3 spawnPoint)
    {
        diContainer.InstantiatePrefab(_sphere, spawnPoint, Quaternion.identity, null);
    }

    

    /*public override void InstallBindings()
    {
        OnEnemyFactory();
    }
    private void OnEnemyFactory()
    {
        for (int i = 0; i < _enemySphere.Capacity; i++)
        {
            int valueHor = Random.Range(-5, 5);
            int valueVer = Random.Range(-5, 5);
            Container.InstantiatePrefab(_enemySphere[i], 
                _enemyPoint.position + new Vector3(valueHor, 0 , valueVer), Quaternion.identity, null);
        }
    }*/
}