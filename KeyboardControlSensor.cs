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

        private SimulatorControls Controls;
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

        protected override void Initialize()
        {
            Controller = GetComponentInParent<IAgentController>();
            Dynamics = GetComponentInParent<IVehicleDynamics>();
            Actions = GetComponentInParent<VehicleActions>();

            Debug.Assert(Dynamics != null);
            Debug.Assert(SimulatorManager.Instance != null);

            Controls = SimulatorManager.Instance.controls;

            if (SystemInfo.operatingSystemFamily == OperatingSystemFamily.Linux && Application.isEditor)
            {
                // empty
            }
            else
            {
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
            }
        }

        protected override void Deinitialize()
        {
            if (SystemInfo.operatingSystemFamily == OperatingSystemFamily.Linux && Application.isEditor)
            {
                // empty
            }
            else
            {
                Controls.VehicleKeyboard.Direction.started -= DirectionStarted;
                Controls.VehicleKeyboard.Direction.performed -= DirectionPerformed;
                Controls.VehicleKeyboard.Direction.canceled -= DirectionCanceled;
                Controls.VehicleKeyboard.ShiftFirst.performed -= ShiftFirstPerformed;
                Controls.VehicleKeyboard.ShiftReverse.performed -= ShiftReversePerformed;
                Controls.VehicleKeyboard.ParkingBrake.performed -= ParkingBrakePerformed;
                Controls.VehicleKeyboard.Ignition.performed -= IgnitionPerformed;
                Controls.VehicleKeyboard.HeadLights.performed -= HeadLightsPerformed;
                Controls.VehicleKeyboard.IndicatorLeft.performed -= IndicatorLeftPerformed;
                Controls.VehicleKeyboard.IndicatorRight.performed -= IndicatorRightPerformed;
                Controls.VehicleKeyboard.IndicatorHazard.performed -= IndicatorHazardPerformed;
                Controls.VehicleKeyboard.FogLights.performed -= FogLightsPerformed;
                Controls.VehicleKeyboard.InteriorLight.performed -= InteriorLightPerformed;
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
            if (SystemInfo.operatingSystemFamily == OperatingSystemFamily.Linux && Application.isEditor)
            {
                // this is a temporary workaround for Unity Editor on Linux
                // see https://issuetracker.unity3d.com/issues/linux-editor-keyboard-when-input-handling-is-set-to-both-keyboard-input-stops-working

                Input = Vector2.zero;
                if (UnityEngine.Input.GetKey(KeyCode.LeftArrow)) Input.x -= 1;
                if (UnityEngine.Input.GetKey(KeyCode.RightArrow)) Input.x += 1;
                if (UnityEngine.Input.GetKey(KeyCode.UpArrow)) Input.y += 1;
                if (UnityEngine.Input.GetKey(KeyCode.DownArrow)) Input.y -= 1;

                var ctx = new UnityEngine.InputSystem.InputAction.CallbackContext();
                if (UnityEngine.Input.GetKeyDown(KeyCode.H)) HeadLightsPerformed(ctx);
                if (UnityEngine.Input.GetKeyDown(KeyCode.Comma)) IndicatorLeftPerformed(ctx);
                if (UnityEngine.Input.GetKeyDown(KeyCode.Period)) IndicatorRightPerformed(ctx);
                if (UnityEngine.Input.GetKeyDown(KeyCode.M)) IndicatorHazardPerformed(ctx);
                if (UnityEngine.Input.GetKeyDown(KeyCode.F)) FogLightsPerformed(ctx);
                if (UnityEngine.Input.GetKeyDown(KeyCode.PageUp)) ShiftFirstPerformed(ctx);
                if (UnityEngine.Input.GetKeyDown(KeyCode.PageDown)) ShiftReversePerformed(ctx);
                if (UnityEngine.Input.GetKeyDown(KeyCode.RightShift)) ParkingBrakePerformed(ctx);
                if (UnityEngine.Input.GetKeyDown(KeyCode.End)) IgnitionPerformed(ctx);
                if (UnityEngine.Input.GetKeyDown(KeyCode.I)) InteriorLightPerformed(ctx);
            }

            if (Controller.Active)
            {
                SteerInput = Mathf.MoveTowards(SteerInput, Input.x, Time.deltaTime);
                MaxSteer = Mathf.Max(Mathf.Abs(SteerInput), MaxSteer);
                AccelInput = Input.y;
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
