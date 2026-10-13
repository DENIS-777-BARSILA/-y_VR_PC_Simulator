using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class TeleportationActivator : MonoBehaviour
{
    public XRRayInteractor teleportInteractor;
    public InputActionProperty teleportActivaorAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        teleportInteractor.gameObject.SetActive(false);
        teleportActivaorAction.action.performed += Action_performed;
    }

    private void Action_performed(InputAction.CallbackContext obj)
    {
        teleportInteractor.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (teleportActivaorAction.action.WasReleasedThisFrame())
        {
            teleportInteractor.gameObject.SetActive(false);
        }
    }
}
