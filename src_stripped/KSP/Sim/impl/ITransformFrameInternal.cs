// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ITransformFrameInternal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;

namespace KSP.Sim.impl
{
  public interface ITransformFrameInternal : ITransformFrame, ICoordinateSystem
  {
    ITransformModelInternal _transformInternal { get; }

    ITransformFrameInternal FindCommonParent(ITransformFrameInternal otherFrameInternal);

    ref Matrix4x4D localMatrix { get; }

    ref Matrix4x4D localMatrixInverse { get; }

    QuaternionD localRotation { get; }

    bool IsLocalMatrixDirty { get; }

    void SetLocalMatrixDirty();

    void AddChild(ITransformModel youngChild);

    void RemoveChild(ITransformModel oldChild);

    void AttachMotionFrame(IMotionFrame motionFrame);
  }
}
