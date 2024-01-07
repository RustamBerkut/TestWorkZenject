using System;
using UnityEngine;
using Zenject;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RedCubeBehaviour : MonoBehaviour
{
    public GameObject _greenCube;
    public float _distance;
    public static Action CubesSoClose;
    public static Action CubesFarAway;

    private Text value;
    private bool _cubesClose = false;

    [Inject]
    private void Construct(GreenCubeBehaviour greenCubeBehaviour)
    {
        _greenCube = greenCubeBehaviour.gameObject;
    }
    [Inject]
    private void Construct(InventoryDisplay inventoryDisplay)
    {
        value = inventoryDisplay._distanceText;
    }
    private void FixedUpdate()
    {
        transform.LookAt(_greenCube.transform.position);
        _distance = Vector3.Distance(transform.position, _greenCube.transform.position);
        OnTextDistanceSetup();
        if (_distance > 3 && !_cubesClose) OnCubesAwaySetup();

        else if (_distance < 3 && _cubesClose) OnCubesCloseSetup();

        if (_distance < 2) OnNextSceneLoading();
    }
    private void OnTextDistanceSetup()
    {
        string formattedString = string.Format("Дистанция между кубами: {0:0.0} метров", _distance);
        value.text = formattedString;
    }
    private void OnCubesCloseSetup()
    {
        _cubesClose = false;
        CubesSoClose?.Invoke();
    }
    private void OnCubesAwaySetup()
    {
        _cubesClose = true;
        CubesFarAway?.Invoke();
    }
    private void OnNextSceneLoading() 
    {
        SceneManager.LoadScene(1);
    }
}
