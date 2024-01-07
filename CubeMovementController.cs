using UnityEngine;

public class CubeMovementController : MonoBehaviour
{
    public float Speed = 10f;

    private string _horizontal, _vertical;
    public enum myEnum
    {
        WASDController,
        ARROWController
    };
    public myEnum DropDown = myEnum.WASDController;

    private void Start()
    {
        SystemControllerChoise();
    }

    private void SystemControllerChoise()
    {
        switch (DropDown)
        {
            case myEnum.WASDController:
                _horizontal = "Horizontalwasd";
                _vertical = "Verticalwasd";
                break;
            case myEnum.ARROWController:
                _horizontal = "HorizontalArrow";
                _vertical = "VerticalArrow";
                break;
            default:
                break;
        }
    }

    private void FixedUpdate()
    {
        MovementLogic();
    }

    private void MovementLogic()
    {
        float moveHorizontal = Input.GetAxis(_horizontal);
        float moveVertical = Input.GetAxis(_vertical);
        
        Vector3 movement = new(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(Speed * Time.fixedDeltaTime * movement, Space.World);
    }
}
