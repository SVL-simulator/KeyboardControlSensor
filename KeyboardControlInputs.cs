// GENERATED AUTOMATICALLY FROM 'Assets/External/Sensors/KeyboardControlSensor/KeyboardControlInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @KeyboardControlInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @KeyboardControlInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""KeyboardControlInputs"",
    ""maps"": [
        {
            ""name"": ""VehicleKeyboard"",
            ""id"": ""a7c84f6e-a555-4bc5-905a-357e97a77b4c"",
            ""actions"": [
                {
                    ""name"": ""Direction"",
                    ""type"": ""Value"",
                    ""id"": ""a4c84d4e-ab73-4109-b6d3-87cef0688a48"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HeadLights"",
                    ""type"": ""Button"",
                    ""id"": ""2da8992e-466b-42bd-9300-0854e7aba0df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""IndicatorLeft"",
                    ""type"": ""Button"",
                    ""id"": ""be797ba1-c73a-41a4-ac0a-7269a1f21865"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""IndicatorRight"",
                    ""type"": ""Button"",
                    ""id"": ""456e0d9b-1590-495a-a810-22068dde68ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""IndicatorHazard"",
                    ""type"": ""Button"",
                    ""id"": ""949c9a20-2be9-4a66-99b8-fb9c720a3c89"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FogLights"",
                    ""type"": ""Button"",
                    ""id"": ""6ebbb86e-7e78-4e78-8238-8f12e931443d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftFirst"",
                    ""type"": ""Button"",
                    ""id"": ""e216bb61-1dbf-4936-8963-26a8cb3d4fde"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShiftReverse"",
                    ""type"": ""Button"",
                    ""id"": ""e5606c54-98ab-4c0a-95ba-47e452129b1c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ParkingBrake"",
                    ""type"": ""Button"",
                    ""id"": ""11cc056b-8dec-44d6-a5af-c41873912c49"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ignition"",
                    ""type"": ""Button"",
                    ""id"": ""546e7144-7b87-4a19-b456-b3edf510c512"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""InteriorLight"",
                    ""type"": ""Button"",
                    ""id"": ""ee3edbee-7490-48da-91aa-1426cbb4e154"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""4a3944ef-8c2c-447c-bc20-2765dd295ca9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""dec83688-608f-4659-ab71-6f83cf44a947"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": ""Hold,Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8c7b7735-c16e-4c0c-827a-18e37bb9d7c6"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": ""Hold,Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""af310a91-e63e-475e-94a0-d754a765b3d8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": ""Hold,Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""aa75c26c-86ae-46cc-89b0-2d7eb13035e2"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": ""Hold,Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4e90a450-ce78-4ddb-8e50-c199db820746"",
                    ""path"": ""<Keyboard>/#(H)"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeadLights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""975ef4d1-cdbe-4cc3-81c4-512cd70c11fa"",
                    ""path"": ""<Keyboard>/#(,)"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IndicatorLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40b6b649-1dae-456c-b067-630619715b18"",
                    ""path"": ""<Keyboard>/#(.)"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IndicatorRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7946afeb-995e-4933-b7bf-5fe4ea1df09f"",
                    ""path"": ""<Keyboard>/#(M)"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IndicatorHazard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43be803b-bfc1-425e-837e-bc0b586d82dd"",
                    ""path"": ""<Keyboard>/#(F)"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FogLights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e6f878e-765f-4ca8-84b8-ecab778a16ae"",
                    ""path"": ""<Keyboard>/pageUp"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftFirst"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bc2ba47-4a58-4cad-97d2-228ab460619f"",
                    ""path"": ""<Keyboard>/pageDown"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShiftReverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec8cc402-0c57-4804-9c5a-38663a225ea2"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ParkingBrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""133d24b4-434c-42f3-993e-d4c5456e7ca4"",
                    ""path"": ""<Keyboard>/end"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ignition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2d4dbb8-8282-444f-8af1-c8405b87e322"",
                    ""path"": ""<Keyboard>/#(I)"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InteriorLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // VehicleKeyboard
        m_VehicleKeyboard = asset.FindActionMap("VehicleKeyboard", throwIfNotFound: true);
        m_VehicleKeyboard_Direction = m_VehicleKeyboard.FindAction("Direction", throwIfNotFound: true);
        m_VehicleKeyboard_HeadLights = m_VehicleKeyboard.FindAction("HeadLights", throwIfNotFound: true);
        m_VehicleKeyboard_IndicatorLeft = m_VehicleKeyboard.FindAction("IndicatorLeft", throwIfNotFound: true);
        m_VehicleKeyboard_IndicatorRight = m_VehicleKeyboard.FindAction("IndicatorRight", throwIfNotFound: true);
        m_VehicleKeyboard_IndicatorHazard = m_VehicleKeyboard.FindAction("IndicatorHazard", throwIfNotFound: true);
        m_VehicleKeyboard_FogLights = m_VehicleKeyboard.FindAction("FogLights", throwIfNotFound: true);
        m_VehicleKeyboard_ShiftFirst = m_VehicleKeyboard.FindAction("ShiftFirst", throwIfNotFound: true);
        m_VehicleKeyboard_ShiftReverse = m_VehicleKeyboard.FindAction("ShiftReverse", throwIfNotFound: true);
        m_VehicleKeyboard_ParkingBrake = m_VehicleKeyboard.FindAction("ParkingBrake", throwIfNotFound: true);
        m_VehicleKeyboard_Ignition = m_VehicleKeyboard.FindAction("Ignition", throwIfNotFound: true);
        m_VehicleKeyboard_InteriorLight = m_VehicleKeyboard.FindAction("InteriorLight", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // VehicleKeyboard
    private readonly InputActionMap m_VehicleKeyboard;
    private IVehicleKeyboardActions m_VehicleKeyboardActionsCallbackInterface;
    private readonly InputAction m_VehicleKeyboard_Direction;
    private readonly InputAction m_VehicleKeyboard_HeadLights;
    private readonly InputAction m_VehicleKeyboard_IndicatorLeft;
    private readonly InputAction m_VehicleKeyboard_IndicatorRight;
    private readonly InputAction m_VehicleKeyboard_IndicatorHazard;
    private readonly InputAction m_VehicleKeyboard_FogLights;
    private readonly InputAction m_VehicleKeyboard_ShiftFirst;
    private readonly InputAction m_VehicleKeyboard_ShiftReverse;
    private readonly InputAction m_VehicleKeyboard_ParkingBrake;
    private readonly InputAction m_VehicleKeyboard_Ignition;
    private readonly InputAction m_VehicleKeyboard_InteriorLight;
    public struct VehicleKeyboardActions
    {
        private @KeyboardControlInputs m_Wrapper;
        public VehicleKeyboardActions(@KeyboardControlInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Direction => m_Wrapper.m_VehicleKeyboard_Direction;
        public InputAction @HeadLights => m_Wrapper.m_VehicleKeyboard_HeadLights;
        public InputAction @IndicatorLeft => m_Wrapper.m_VehicleKeyboard_IndicatorLeft;
        public InputAction @IndicatorRight => m_Wrapper.m_VehicleKeyboard_IndicatorRight;
        public InputAction @IndicatorHazard => m_Wrapper.m_VehicleKeyboard_IndicatorHazard;
        public InputAction @FogLights => m_Wrapper.m_VehicleKeyboard_FogLights;
        public InputAction @ShiftFirst => m_Wrapper.m_VehicleKeyboard_ShiftFirst;
        public InputAction @ShiftReverse => m_Wrapper.m_VehicleKeyboard_ShiftReverse;
        public InputAction @ParkingBrake => m_Wrapper.m_VehicleKeyboard_ParkingBrake;
        public InputAction @Ignition => m_Wrapper.m_VehicleKeyboard_Ignition;
        public InputAction @InteriorLight => m_Wrapper.m_VehicleKeyboard_InteriorLight;
        public InputActionMap Get() { return m_Wrapper.m_VehicleKeyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VehicleKeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IVehicleKeyboardActions instance)
        {
            if (m_Wrapper.m_VehicleKeyboardActionsCallbackInterface != null)
            {
                @Direction.started -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnDirection;
                @Direction.performed -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnDirection;
                @Direction.canceled -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnDirection;
                @HeadLights.started -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnHeadLights;
                @HeadLights.performed -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnHeadLights;
                @HeadLights.canceled -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnHeadLights;
                @IndicatorLeft.started -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnIndicatorLeft;
                @IndicatorLeft.performed -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnIndicatorLeft;
                @IndicatorLeft.canceled -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnIndicatorLeft;
                @IndicatorRight.started -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnIndicatorRight;
                @IndicatorRight.performed -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnIndicatorRight;
                @IndicatorRight.canceled -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnIndicatorRight;
                @IndicatorHazard.started -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnIndicatorHazard;
                @IndicatorHazard.performed -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnIndicatorHazard;
                @IndicatorHazard.canceled -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnIndicatorHazard;
                @FogLights.started -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnFogLights;
                @FogLights.performed -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnFogLights;
                @FogLights.canceled -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnFogLights;
                @ShiftFirst.started -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnShiftFirst;
                @ShiftFirst.performed -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnShiftFirst;
                @ShiftFirst.canceled -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnShiftFirst;
                @ShiftReverse.started -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnShiftReverse;
                @ShiftReverse.performed -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnShiftReverse;
                @ShiftReverse.canceled -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnShiftReverse;
                @ParkingBrake.started -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnParkingBrake;
                @ParkingBrake.performed -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnParkingBrake;
                @ParkingBrake.canceled -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnParkingBrake;
                @Ignition.started -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnIgnition;
                @Ignition.performed -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnIgnition;
                @Ignition.canceled -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnIgnition;
                @InteriorLight.started -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnInteriorLight;
                @InteriorLight.performed -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnInteriorLight;
                @InteriorLight.canceled -= m_Wrapper.m_VehicleKeyboardActionsCallbackInterface.OnInteriorLight;
            }
            m_Wrapper.m_VehicleKeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Direction.started += instance.OnDirection;
                @Direction.performed += instance.OnDirection;
                @Direction.canceled += instance.OnDirection;
                @HeadLights.started += instance.OnHeadLights;
                @HeadLights.performed += instance.OnHeadLights;
                @HeadLights.canceled += instance.OnHeadLights;
                @IndicatorLeft.started += instance.OnIndicatorLeft;
                @IndicatorLeft.performed += instance.OnIndicatorLeft;
                @IndicatorLeft.canceled += instance.OnIndicatorLeft;
                @IndicatorRight.started += instance.OnIndicatorRight;
                @IndicatorRight.performed += instance.OnIndicatorRight;
                @IndicatorRight.canceled += instance.OnIndicatorRight;
                @IndicatorHazard.started += instance.OnIndicatorHazard;
                @IndicatorHazard.performed += instance.OnIndicatorHazard;
                @IndicatorHazard.canceled += instance.OnIndicatorHazard;
                @FogLights.started += instance.OnFogLights;
                @FogLights.performed += instance.OnFogLights;
                @FogLights.canceled += instance.OnFogLights;
                @ShiftFirst.started += instance.OnShiftFirst;
                @ShiftFirst.performed += instance.OnShiftFirst;
                @ShiftFirst.canceled += instance.OnShiftFirst;
                @ShiftReverse.started += instance.OnShiftReverse;
                @ShiftReverse.performed += instance.OnShiftReverse;
                @ShiftReverse.canceled += instance.OnShiftReverse;
                @ParkingBrake.started += instance.OnParkingBrake;
                @ParkingBrake.performed += instance.OnParkingBrake;
                @ParkingBrake.canceled += instance.OnParkingBrake;
                @Ignition.started += instance.OnIgnition;
                @Ignition.performed += instance.OnIgnition;
                @Ignition.canceled += instance.OnIgnition;
                @InteriorLight.started += instance.OnInteriorLight;
                @InteriorLight.performed += instance.OnInteriorLight;
                @InteriorLight.canceled += instance.OnInteriorLight;
            }
        }
    }
    public VehicleKeyboardActions @VehicleKeyboard => new VehicleKeyboardActions(this);
    public interface IVehicleKeyboardActions
    {
        void OnDirection(InputAction.CallbackContext context);
        void OnHeadLights(InputAction.CallbackContext context);
        void OnIndicatorLeft(InputAction.CallbackContext context);
        void OnIndicatorRight(InputAction.CallbackContext context);
        void OnIndicatorHazard(InputAction.CallbackContext context);
        void OnFogLights(InputAction.CallbackContext context);
        void OnShiftFirst(InputAction.CallbackContext context);
        void OnShiftReverse(InputAction.CallbackContext context);
        void OnParkingBrake(InputAction.CallbackContext context);
        void OnIgnition(InputAction.CallbackContext context);
        void OnInteriorLight(InputAction.CallbackContext context);
    }
}
