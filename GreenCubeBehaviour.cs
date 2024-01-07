using UnityEngine;
using Zenject;

public class GreenCubeBehaviour : MonoBehaviour
{
    public GameObject _redCube;

    [Inject]
    private void Construct(RedCubeBehaviour redCubeBehaviour)
    {
        _redCube = redCubeBehaviour.gameObject;
    }
    private void FixedUpdate()
    {
        transform.LookAt(_redCube.transform.position);
    }
}
