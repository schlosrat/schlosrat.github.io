// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.KerbalCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Flight
{
  public class KerbalCamera : MonoBehaviour
  {
    private int _shadowCascadesOverride;
    private int _antiAliasingOverride;
    private float _shadowDistanceOverride;
    private int _revertShadowCascades;
    private int _revertAntiAliasing;
    private float _revertShadowDistance;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPreRender() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPostRender() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalCamera() => throw null;
  }
}
