// Decompiled with JetBrains decompiler
// Type: KSP.OAB.BAESizeLimits
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class BAESizeLimits : IObjectAssemblyBuilderSizeLimits
  {
    private Vector3 CenterPos;
    private float MaxHeight;
    private float MinHeight;
    private float MaxRadiusSqr;
    private DebugShapesDraw.Cylinder DebugCylinder;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BAESizeLimits(
      GameObject gameObj,
      Vector3 center,
      float maxHeight,
      float minHeight,
      float radius)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAssemblyOutOfBounds(Bounds assemblyBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableDebugSizeLimits(bool enable) => throw null;
  }
}
