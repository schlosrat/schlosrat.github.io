// Decompiled with JetBrains decompiler
// Type: KSP.ModularCamera.CameraDriverBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.ModularCamera.internals;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace KSP.ModularCamera
{
  public class CameraDriverBase : ICameraDriver, ICameraDriverReadOnly, ICameraDriverInternalState
  {
    private Dictionary<Validator, HashSet<ValidatorType>> validatorsActive;
    private Stack<CameraDriverBase.ValidatorStackEntry> validatorCallStack;

    public Transform PivotTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Transform GimbalTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Transform CameraTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Dictionary<CameraInputBinding, CameraInputInterpreter> InputInterpreters
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Dictionary<CameraInputBinding, List<CameraInputModifier>> InputModifiers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Dictionary<ValidatorType, Validator> Validators
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static ICameraDriverInternalState GetInternals(ICameraDriver driver) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraDriverBase(ICameraDriver other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ICameraDriver Clone() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraDriverBase(Transform pivot, Transform gimbal, Transform camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset(Transform pivot, Transform gimbal, Transform camera, bool validate = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTransformsFrom(ICameraDriver other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Activate(bool validate = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deactivate(bool validate = true) => throw null;

    public Matrix4x4 WorldToPivot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Matrix4x4 PivotToWorld
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Matrix4x4 WorldToGimbal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Matrix4x4 GimbalToWorld
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Quaternion PivotLocalRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Quaternion PivotToWorldRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Quaternion GimbalLocalRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Quaternion GimbalWorldRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 GimbalWorldForward
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 GimbalWorldUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 GimbalWorldRight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float Pitch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetPitch(float value, bool validate = true) => throw null;

    public float Yaw
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetYaw(float value, bool validate = true) => throw null;

    public float Roll
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetRoll(float value, bool validate = true) => throw null;

    public float TargetDistance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float CameraDistance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 TargetOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 CameraOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 PivotPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 TargetPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 CameraPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void AddOffset(Vector3 worldOffset, bool validate = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetPivotPosition(Vector3 worldPosition, bool validate = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ShiftCameraToPosition(Vector3 worldPosition, bool validate = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetTargetDistance(float worldDistance, bool validate = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ForceCameraPositionUnvalidated(Vector3 worldPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ForceCameraDistanceUnvalidated(float floatDistance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsInputInterpreted(CameraInputBinding binding) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindInputInterpreter(CameraInputBinding binding, CameraInputInterpreter handler) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyInputInterpretersFrom(ICameraDriver other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearInputInterpreters() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearInputInterpreterFor(CameraInputBinding binding) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyInput(
      CameraInputBinding binding,
      CameraInputValueList inputValues,
      bool validate = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsInputModified(CameraInputBinding binding) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraInputValueList GetModifiedInputs(
      CameraInputBinding binding,
      CameraInputValueList rawInputs)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddInputModifier(CameraInputBinding binding, CameraInputModifier modifier) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyInputModifiersFrom(ICameraDriver other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearInputModifiers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearInputModifiers(CameraInputBinding binding) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddValidator(ValidatorType type, Validator validator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyValidatorsFrom(ICameraDriver other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearValidators() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearValidators(ValidatorType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ValidatorStackDump(StringBuilder builder, Validator highLight = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RunValidator(ValidatorType type, bool validate = true) => throw null;

    private struct ValidatorStackEntry
    {
      public int index;
      public ValidatorType type;
      public Validator validator;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ValidatorStackEntry(ValidatorType type, Validator validator, int index) => throw null;
    }
  }
}
