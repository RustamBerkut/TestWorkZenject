using UnityEngine;

public interface IEnemyFactorio
{
    void Load();
    void Create(GameObject gameObject, Vector3 spawnPoint);
}
