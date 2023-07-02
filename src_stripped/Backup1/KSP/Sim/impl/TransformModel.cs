// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.TransformModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  [DebuggerDisplay("TransformModel= {_Value_ForDebuggerOnly}")]
  public class TransformModel : 
    ITransformModelInternal,
    ITransformModel,
    IStringIdentity,
    IPositionDriver,
    IRotationDriver
  {
    private List<ITransformModel> _children;
    private Vector3d _localPosition;
    private QuaternionD _localRotation;
    private List<ITransformFrameInternal> _parentageCache;
    private bool _parentageCacheDirty;
    private IMotionModelInternal _motionModel;
    private IPositionDriver positionDriver;
    private IRotationDriver rotationDriver;

    public string Guid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public SimulationObjectModel objectModel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ITransformFrame parent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public SimTransformTag SimTag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] protected set => throw null;
    }

    public ITransformFrame bodyFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformFrame celestialFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformFrameInternal _parentInternal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ITransformFrameInternal _bodyFrameInternal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ITransformFrameInternal _celestialFrameInternal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool isInternalTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<ITransformModel> children
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ICoordinateSystem coordinateSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3d localPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public QuaternionD celestialTilt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public QuaternionD launchTilt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public QuaternionD localRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [DebuggerDisplay("Position = {localPosition.x},{localPosition.y},{localPosition.z}")]
    public Position Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [DebuggerDisplay("Rotation = {localRotation.x},{localRotation.y},{localRotation.z},{localRotation.w}")]
    public Rotation Rotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool parentageCacheDirty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public List<ITransformFrameInternal> parentageCache
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IMotionModel motionModel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TransformModel(SimulationObjectModel objectModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TransformModel(string guid, SimTransformTag tag = SimTransformTag.None) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateSimTransformTagFromSimObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static SimTransformTag IntrospectSimTagFromSimObject(SimulationObjectModel simObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ITransformFrame GetSimObjectParentTransformFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ITransformFrame GetSimSOIBodyParentTransformFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ITransformFrame GetTransformFrame(TransformFrameType frameType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Is(IStringIdentity other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetParent(ITransformFrame newParent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddChild(ITransformModel youngChild) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveChild(ITransformModel oldChild) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ITransformModel FindChildByName(string name, bool recursive) => throw null;

    public IPositionDriver PositionDriver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void driver_onPositionUpdated(Position newPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePosition(Position newPosition) => throw null;

    public event Action<Position> PositionUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerPositionRotationUpdatedEvents() => throw null;

    public IRotationDriver RotationDriver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void driver_onRotationUpdated(Rotation newRotation) => throw null;

    public bool CanAcceptRotationUpdate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateRotation(Rotation newRotation) => throw null;

    public event Action<Rotation> RotationUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public ILinearMotionDriver LinearMotionDriver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IAngularMotionDriver AngularMotionDriver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IRigidbodyDriver RigidbodyDriver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector up
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector down
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector forward
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector back
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector left
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector right
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public Vector3d GetLocalPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public QuaternionD GetLocalRotation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLocalPosition(Vector3d newLocalPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLocalRotation(QuaternionD newLocalRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PerformFrameSnap(IMotionFrame newMotionFrame, List<Action> actionList) => throw null;
  }
}
