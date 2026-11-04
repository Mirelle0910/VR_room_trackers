using UnityEngine;
using UnityEngine.InputSystem;

public class ActionEnabler : MonoBehaviour
{
    [SerializeField] private InputActionAsset actions;

    void OnEnable() { actions.FindActionMap("Trackers").Enable(); }
    void OnDisable() { actions.FindActionMap("Trackers").Disable(); }
}