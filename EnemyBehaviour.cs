using UnityEngine;
using Zenject;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject _player;

    [Inject]
    private void Construct(RedCubeBehaviour redCubeBehaviour)
    {
        _player = redCubeBehaviour.gameObject;
    }
    private void OnEnable()
    {
        RedCubeBehaviour.CubesSoClose += OnCubesEnable;
        RedCubeBehaviour.CubesFarAway += OnCubesDisables;
    }
    private void OnDisable()
    {
        RedCubeBehaviour.CubesSoClose -= OnCubesEnable;
        RedCubeBehaviour.CubesFarAway -= OnCubesDisables;
    }
    private void OnCubesEnable()
    {
        GetComponent<MeshRenderer>().enabled = true;
    }
    private void OnCubesDisables()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }
}
