// Decompiled with JetBrains decompiler
// Type: KSP.Map.MapManeuverGizmoScaling
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
