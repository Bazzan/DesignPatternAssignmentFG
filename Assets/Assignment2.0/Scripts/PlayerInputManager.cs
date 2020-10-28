using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{


    //public Vector3 ClickedPosition;
    public LayerMask layerMask;
    
    private Camera camera;
    private Ray ray;
    private RaycastHit rayHit;
    private void Awake()
    {
        camera = StaticRefrences.instance.camera;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("hello");
            ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out rayHit, 100000f, layerMask, QueryTriggerInteraction.Ignore))
            {
                //ClickedPosition = rayHit.point;
                StaticRefrences.instance.playerCommandInvoker.AddCommand(new MoveCommand(rayHit.point));
                
            }
        
        }
    }


}
