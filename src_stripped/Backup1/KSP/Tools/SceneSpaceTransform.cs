// Decompiled with JetBrains decompiler
// Type: KSP.Tools.SceneSpaceTransform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Tools
{
  internal struct SceneSpaceTransform
  {
    public Vector3 scenePosition;
    public Quaternion sceneRotation;
    public Vector3 sceneScale;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneSpaceTransform(
      ITransformModel transform,
      IScaledSpaceProvider spaceProvider,
      double scale = 1.0)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneSpaceTransform(
      ITransformModel transform,
      IPhysicsSpaceProvider spaceProvider,
      double scale = 1.0)
    {
      throw null;
    }
  }
}
