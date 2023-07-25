// Decompiled with JetBrains decompiler
// Type: KSP.ModularCamera.ICameraDriver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;

namespace KSP.ModularCamera
{
  public interface ICameraDriver : ICameraDriverReadOnly
  {
    ICameraDriver Clone();

    void Reset(Transform pivot, Transform gimbal, Transform camera, bool validate = true);

    void CopyTransformsFrom(ICameraDriver other);

    void Activate(bool validate = true);

    void Deactivate(bool validate = true);

    void SetPitch(float localPitch, bool validate = true);

    void SetYaw(float localYaw, bool validate = true);

    void SetRoll(float localRoll, bool validate = true);

    void AddOffset(Vector3 worldOffset, bool validate = true);

    void SetPivotPosition(Vector3 worldPosition, bool validate = true);

    void ShiftCameraToPosition(Vector3 worldPosition, bool validate = true);

    void SetTargetDistance(float worldDistance, bool validate = true);

    void ForceCameraPositionUnvalidated(Vector3 worldPosition);

    void ForceCameraDistanceUnvalidated(float worldDistance);

    void BindInputInterpreter(CameraInputBinding binding, CameraInputInterpreter handler);

    void CopyInputInterpretersFrom(ICameraDriver other);

    void ClearInputInterpreters();

    void ClearInputInterpreterFor(CameraInputBinding binding);

    void ApplyInput(CameraInputBinding binding, CameraInputValueList inputValues, bool validate = true);

    void AddInputModifier(CameraInputBinding binding, CameraInputModifier modifier);

    void CopyInputModifiersFrom(ICameraDriver other);

    void ClearInputModifiers();

    void ClearInputModifiers(CameraInputBinding binding);

    void AddValidator(ValidatorType type, Validator validator);

    void CopyValidatorsFrom(ICameraDriver other);

    void ClearValidators();

    void ClearValidators(ValidatorType type);

    void RunValidator(ValidatorType type, bool validate = true);
  }
}
