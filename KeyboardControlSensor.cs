/**
 * Copyright (c) 2019-2021 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using UnityEngine;
using Simulator.Bridge;
using Simulator.Utilities;
using Simulator.Sensors.UI;
using System.Collections.Generic;

namespace Simulator.Sensors
{
    [SensorType("Keyboard Control", new System.Type[] { })]
    public class KeyboardControlSensor : SensorBase, IVehicleInputs
    {
        public float SteerInput { get; private set; } = 0f;
        public float AccelInput { get; private set; } = 0f;
        public float BrakeInput { get; private set; } = 0f;

        private KeyboardControlInputs Controls;
        private IVehicleDynamics Dynamics;
        private VehicleActions Actions;
        private Vector2 Input = Vector2.zero;
        private IAgentController Controller;

        [AnalysisMeasurement(MeasurementType.Input)]
        public float MaxSteer = 0f;
        [AnalysisMeasurement(MeasurementType.Input)]
        public float MaxAccel = 0f;
        [AnalysisMeasurement(MeasurementType.Input)]
        public float MaxBrake = 0f;

        [SensorParameter]
        public bool InvertAccel = false;
        [SensorParameter]
        public bool InvertSteer = false;

        protected override void Initialize()
        {
            Controller = GetComponentInParent<IAgentController>();
            Dynamics = GetComponentInParent<IVehicleDynamics>();
            Actions = GetComponentInParent<VehicleActions>();

            Debug.Assert(Dynamics != null);
            Debug.Assert(SimulatorManager.Instance != null);

            Controls = new KeyboardControlInputs();

            Controls.VehicleKeyboard.Direction.started += DirectionStarted;
            Controls.VehicleKeyboard.Direction.performed += DirectionPerformed;
            Controls.VehicleKeyboard.Direction.canceled += DirectionCanceled;
            Controls.VehicleKeyboard.ShiftFirst.performed += ShiftFirstPerformed;
            Controls.VehicleKeyboard.ShiftReverse.performed += ShiftReversePerformed;
            Controls.VehicleKeyboard.ParkingBrake.performed += ParkingBrakePerformed;
            Controls.VehicleKeyboard.Ignition.performed += IgnitionPerformed;
            Controls.VehicleKeyboard.HeadLights.performed += HeadLightsPerformed;
            Controls.VehicleKeyboard.IndicatorLeft.performed += IndicatorLeftPerformed;
            Controls.VehicleKeyboard.IndicatorRight.performed += IndicatorRightPerformed;
            Controls.VehicleKeyboard.IndicatorHazard.performed += IndicatorHazardPerformed;
            Controls.VehicleKeyboard.FogLights.performed += FogLightsPerformed;
            Controls.VehicleKeyboard.InteriorLight.performed += InteriorLightPerformed;

            Controls.Enable();
        }
                
        protected override void Deinitialize()
        {
            if (Controls != null)
            {
                Controls.Disable();
                Controls.Dispose();

                Controls = null;
            }
        }
       
        private void DirectionStarted(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            Input = obj.ReadValue<Vector2>();            
        }

        private void DirectionPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            Input = obj.ReadValue<Vector2>();            
        }

        private void DirectionCanceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            Input = Vector2.zero;            
        }

        private void ShiftFirstPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            if (!Controller.Active)
                return;

            Dynamics.ShiftFirstGear();
        }

        private void ShiftReversePerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            if (!Controller.Active)
                return;

            Dynamics.ShiftReverse();
        }

        private void ParkingBrakePerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            if (!Controller.Active)
                return;

            Dynamics.ToggleHandBrake();
        }

        private void IgnitionPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            if (!Controller.Active)
                return;

            Dynamics.ToggleIgnition();
        }

        private void HeadLightsPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            if (Actions == null)
                return;

            Actions.IncrementHeadLightState();
        }

        private void IndicatorLeftPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            if (Actions == null)
                return;

            Actions.LeftTurnSignal = !Actions.LeftTurnSignal;
        }

        private void IndicatorRightPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            if (Actions == null)
                return;

            Actions.RightTurnSignal = !Actions.RightTurnSignal;
        }

        private void IndicatorHazardPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            if (Actions == null)
                return;

            Actions.HazardLights = !Actions.HazardLights;
        }

        private void FogLightsPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            if (Actions == null)
                return;

            Actions.FogLights = !Actions.FogLights;
        }

        private void InteriorLightPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            if (Actions == null)
                return;

            Actions.InteriorLight = !Actions.InteriorLight;
        }

        private void Update()
        {
            if (Controller.Active)
            {
                SteerInput = Mathf.MoveTowards(SteerInput, InvertSteer ? Input.x * - 1 : Input.x * 1, Time.deltaTime);
                MaxSteer = Mathf.Max(Mathf.Abs(SteerInput), MaxSteer);
                AccelInput = InvertAccel ? Input.y * - 1 : Input.y * 1;
                MaxAccel = Mathf.Max(Mathf.Abs(AccelInput), MaxAccel);
                MaxBrake = Mathf.Min(AccelInput, MaxBrake);
            }
        }

        public override void OnBridgeSetup(BridgeInstance bridge)
        {
            //
        }

        public override void OnVisualize(Visualizer visualizer)
        {
            Debug.Assert(visualizer != null);
            var graphData = new Dictionary<string, object>()
            {
                {"Accel", AccelInput},
                {"Steer", SteerInput},
                {"Speed", Dynamics.Velocity.magnitude},
                {"Hand Brake", Dynamics.HandBrake},
                {"Ignition", Dynamics.CurrentIgnitionStatus},
                {"Reverse", Dynamics.Reverse},
                {"Gear", Dynamics.CurrentGear},
                {"RPM", Dynamics.CurrentRPM},
                {"Velocity", Dynamics.Velocity}
            };
            visualizer.UpdateGraphValues(graphData);
        }

        public override void OnVisualizeToggle(bool state)
        {
            //
        }
    }
}
