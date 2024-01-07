using UnityEngine;
using Zenject;

public class CubeInstaller : MonoInstaller
{
    [SerializeField] private GameObject _redCubePrefab;
    [SerializeField] private GameObject _greenCubePrefab;
    public InventoryDisplay inventoryDisplay;

    public override void InstallBindings()
    {
        BindInventoryDisplay();
        OnCubesSetup();
    }
    private void BindInventoryDisplay()
    {
        Container
            .Bind<InventoryDisplay>()
            .FromInstance(inventoryDisplay)
            .AsSingle();
    }
    private void OnCubesSetup()
    {
        Container
            .Bind<RedCubeBehaviour>()
            .FromComponentInNewPrefab(_redCubePrefab)
            .AsSingle();

        Container
            .Bind<GreenCubeBehaviour>()
            .FromComponentInNewPrefab(_greenCubePrefab)
            .AsSingle();
    }
}