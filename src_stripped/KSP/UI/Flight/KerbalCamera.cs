// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.KerbalCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
