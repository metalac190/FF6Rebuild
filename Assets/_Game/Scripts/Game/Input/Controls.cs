// GENERATED AUTOMATICALLY FROM 'Assets/_Game/Scripts/Game/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Encounter"",
            ""id"": ""7486e84a-bebf-46b8-9928-cf845c7d47b3"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""0ef76409-e332-4673-a561-502cd9b2fbcd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""d2cfe6ca-8e63-4dea-abdf-12437beae3f2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""5271758d-f1be-4b49-b3af-41581ef880fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""880cdde8-7b4c-4967-a5f8-e3380a51fa97"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""fbed2ab4-00b8-4874-b6a5-56f77b5cb1c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""71361f95-818a-40b8-9593-4a6aa8455ea2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectToggle"",
                    ""type"": ""Button"",
                    ""id"": ""d57f5778-ef1e-4ec0-82db-63c0d90c06c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""50ffbbd4-972f-4508-9e10-d035c3b53958"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Skip"",
                    ""type"": ""Button"",
                    ""id"": ""32453c25-00ac-4b12-a1c8-c1108ac6f725"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8a685855-66ee-4823-a4a7-d716f2469cac"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2357203-d07e-42f3-9e66-9535a7941f9b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9a9dfe7-16ff-42a3-81bf-50c2d6aa3b9a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6e28671-a2f6-4a12-ad9d-e7ef65d0b2e1"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d15332a-5bb0-4c4c-b40e-091cd560e58b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b49e43c-8264-49e9-abdc-0673c4071303"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db6fb880-38e9-40fc-9201-a96cd43a4455"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ce1151f-3eb7-4806-8ead-ec2ac7d23e7b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75ff0edf-25c1-47a4-a498-4e05ff1dfe69"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbbd1cf0-7b40-4402-bc8b-b4ca7e36b1d2"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3893a25b-a16b-4cf4-a117-f103b741ec4e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c2474a6-5bed-4fb4-afe4-6468bb4c4dfe"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03881172-3cc5-4252-bce9-ae1e820e77c3"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""SelectToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7a11d77-6b77-4027-bed9-1398c2755945"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b231c178-9a30-4daa-a274-a7cf7eb53637"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardAndMouse"",
            ""bindingGroup"": ""KeyboardAndMouse"",
            ""devices"": []
        }
    ]
}");
        // Encounter
        m_Encounter = asset.FindActionMap("Encounter", throwIfNotFound: true);
        m_Encounter_Up = m_Encounter.FindAction("Up", throwIfNotFound: true);
        m_Encounter_Down = m_Encounter.FindAction("Down", throwIfNotFound: true);
        m_Encounter_Left = m_Encounter.FindAction("Left", throwIfNotFound: true);
        m_Encounter_Right = m_Encounter.FindAction("Right", throwIfNotFound: true);
        m_Encounter_Confirm = m_Encounter.FindAction("Confirm", throwIfNotFound: true);
        m_Encounter_Cancel = m_Encounter.FindAction("Cancel", throwIfNotFound: true);
        m_Encounter_SelectToggle = m_Encounter.FindAction("SelectToggle", throwIfNotFound: true);
        m_Encounter_Pause = m_Encounter.FindAction("Pause", throwIfNotFound: true);
        m_Encounter_Skip = m_Encounter.FindAction("Skip", throwIfNotFound: true);
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

    // Encounter
    private readonly InputActionMap m_Encounter;
    private IEncounterActions m_EncounterActionsCallbackInterface;
    private readonly InputAction m_Encounter_Up;
    private readonly InputAction m_Encounter_Down;
    private readonly InputAction m_Encounter_Left;
    private readonly InputAction m_Encounter_Right;
    private readonly InputAction m_Encounter_Confirm;
    private readonly InputAction m_Encounter_Cancel;
    private readonly InputAction m_Encounter_SelectToggle;
    private readonly InputAction m_Encounter_Pause;
    private readonly InputAction m_Encounter_Skip;
    public struct EncounterActions
    {
        private @Controls m_Wrapper;
        public EncounterActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_Encounter_Up;
        public InputAction @Down => m_Wrapper.m_Encounter_Down;
        public InputAction @Left => m_Wrapper.m_Encounter_Left;
        public InputAction @Right => m_Wrapper.m_Encounter_Right;
        public InputAction @Confirm => m_Wrapper.m_Encounter_Confirm;
        public InputAction @Cancel => m_Wrapper.m_Encounter_Cancel;
        public InputAction @SelectToggle => m_Wrapper.m_Encounter_SelectToggle;
        public InputAction @Pause => m_Wrapper.m_Encounter_Pause;
        public InputAction @Skip => m_Wrapper.m_Encounter_Skip;
        public InputActionMap Get() { return m_Wrapper.m_Encounter; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EncounterActions set) { return set.Get(); }
        public void SetCallbacks(IEncounterActions instance)
        {
            if (m_Wrapper.m_EncounterActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_EncounterActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_EncounterActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_EncounterActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_EncounterActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_EncounterActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_EncounterActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_EncounterActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_EncounterActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_EncounterActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_EncounterActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_EncounterActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_EncounterActionsCallbackInterface.OnRight;
                @Confirm.started -= m_Wrapper.m_EncounterActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_EncounterActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_EncounterActionsCallbackInterface.OnConfirm;
                @Cancel.started -= m_Wrapper.m_EncounterActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_EncounterActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_EncounterActionsCallbackInterface.OnCancel;
                @SelectToggle.started -= m_Wrapper.m_EncounterActionsCallbackInterface.OnSelectToggle;
                @SelectToggle.performed -= m_Wrapper.m_EncounterActionsCallbackInterface.OnSelectToggle;
                @SelectToggle.canceled -= m_Wrapper.m_EncounterActionsCallbackInterface.OnSelectToggle;
                @Pause.started -= m_Wrapper.m_EncounterActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_EncounterActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_EncounterActionsCallbackInterface.OnPause;
                @Skip.started -= m_Wrapper.m_EncounterActionsCallbackInterface.OnSkip;
                @Skip.performed -= m_Wrapper.m_EncounterActionsCallbackInterface.OnSkip;
                @Skip.canceled -= m_Wrapper.m_EncounterActionsCallbackInterface.OnSkip;
            }
            m_Wrapper.m_EncounterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @SelectToggle.started += instance.OnSelectToggle;
                @SelectToggle.performed += instance.OnSelectToggle;
                @SelectToggle.canceled += instance.OnSelectToggle;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Skip.started += instance.OnSkip;
                @Skip.performed += instance.OnSkip;
                @Skip.canceled += instance.OnSkip;
            }
        }
    }
    public EncounterActions @Encounter => new EncounterActions(this);
    private int m_KeyboardAndMouseSchemeIndex = -1;
    public InputControlScheme KeyboardAndMouseScheme
    {
        get
        {
            if (m_KeyboardAndMouseSchemeIndex == -1) m_KeyboardAndMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardAndMouse");
            return asset.controlSchemes[m_KeyboardAndMouseSchemeIndex];
        }
    }
    public interface IEncounterActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnSelectToggle(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnSkip(InputAction.CallbackContext context);
    }
}
