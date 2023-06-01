// Decompiled with JetBrains decompiler
// Type: KSP.Map.MapManeuverGizmoScaling
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  public class MapManeuverGizmoScaling : KerbalMonoBehaviour
  {
    [SerializeField]
    private Camera _cameraToScaleFor;
    [Range(0.0f, 100f)]
    [SerializeField]
    public float _targetNoots;
    [Min(0.0f)]
    [SerializeField]
    public float _objectBaseScale;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCamera(Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapManeuverGizmoScaling() => throw null;
  }
}
