// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ITransformModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;

namespace KSP.Sim
{
  public interface ITransformModel : IStringIdentity, IPositionDriver, IRotationDriver
  {
    new string Guid { get; }

    SimulationObjectModel objectModel { get; }

    IMotionModel motionModel { get; }

    bool isInternalTransform { get; }

    QuaternionD celestialTilt { get; set; }

    QuaternionD launchTilt { get; set; }

    ITransformFrame bodyFrame { get; }

    ITransformFrame celestialFrame { get; }

    ITransformFrame parent { get; set; }

    SimTransformTag SimTag { get; }

    ITransformFrame GetSimObjectParentTransformFrame();

    ITransformFrame GetSimSOIBodyParentTransformFrame();

    void TriggerPositionRotationUpdatedEvents();

    List<ITransformModel> children { get; }

    void SetParent(ITransformFrame newParent);

    ICoordinateSystem coordinateSystem { get; }

    Vector3d localPosition { get; }

    QuaternionD localRotation { get; }

    new Position Position { get; set; }

    new Rotation Rotation { get; set; }

    IRigidbodyDriver RigidbodyDriver { set; }

    IPositionDriver PositionDriver { get; set; }

    IRotationDriver RotationDriver { get; set; }

    ILinearMotionDriver LinearMotionDriver { get; set; }

    IAngularMotionDriver AngularMotionDriver { get; set; }

    Vector up { get; }

    Vector down { get; }

    Vector forward { get; }

    Vector back { get; }

    Vector left { get; }

    Vector right { get; }

    void PerformFrameSnap(IMotionFrame newMotionFrame, List<Action> onSnapComplete);

    ITransformFrame GetTransformFrame(TransformFrameType frameType);

    ITransformModel FindChildByName(string childName, bool recursive);
  }
}
