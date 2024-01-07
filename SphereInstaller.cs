using UnityEngine;
using Zenject;

public class SphereInstaller : MonoInstaller
{
    [SerializeField] private GameObject[] _enemySphere;
    [SerializeField] private Transform _enemyPoint;
    
    public override void InstallBindings()
    {
        OnEnemyFactory();
    }
    private void OnEnemyFactory()
    {
        for (int i = 0; i < _enemySphere.Length; i++)
        {
            int valueHor = Random.Range(-5, 5);
            int valueVer = Random.Range(-5, 5);
            Container.InstantiatePrefab(_enemySphere[i], 
                _enemyPoint.position + new Vector3(valueHor, 0 , valueVer), Quaternion.identity, null);
        }
    }
}