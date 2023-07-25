// Decompiled with JetBrains decompiler
// Type: KSP.Test.ITransformFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.Test
{
  public interface ITransformFrame
  {
    TransformFrameType type { get; }

    ITransformModel transform { get; }

    Vector3d ToLocalPosition(ITransformFrame referenceFrame, Vector3d referenceFramePosition);

    QuaternionD ToLocalRotation(ITransformFrame referenceFrame, QuaternionD referenceFramePosition);

    QuaternionD ToWorldRotation(QuaternionD thisLocalRotation);
  }
}
