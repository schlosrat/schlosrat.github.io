// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ITransformFrameInternal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
