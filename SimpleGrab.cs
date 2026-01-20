using Photon.Voice;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
[RequireComponent(typeof(XRGrabInteractable))]
public class SimpleGrab : MonoBehaviour
{
    [Header("SimpleGrab | GitHub: unitzdevz")]
    Collider _collider;
    XRGrabInteractable _interactable;
    private void OnEnable()
    {
        _collider = GetComponent<Collider>();
        _interactable.selectEntered.AddListener(OnGrab);
        _interactable.selectExited.AddListener(OnRelease);
    }
    void OnGrab(SelectEnterEventArgs args)
    {
        _collider.enabled = false;
    }
    void OnRelease(SelectExitEventArgs args)
    {
        _collider.enabled = true;
    }
}