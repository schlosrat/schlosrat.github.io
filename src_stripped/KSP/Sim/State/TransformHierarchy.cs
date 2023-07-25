// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.TransformHierarchy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.State
{
  public struct TransformHierarchy
  {
    public string transformGuid;
    public TransformFrameType referenceFrameType;
    public Vector3d localPosition;
    public QuaternionD localRotation;
    public IList<TransformHierarchy> children;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TransformHierarchy FromTransform(ITransformModel transform) => throw null;
  }
}
