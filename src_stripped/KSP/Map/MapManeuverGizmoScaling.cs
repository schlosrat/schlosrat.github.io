// Decompiled with JetBrains decompiler
// Type: KSP.Map.MapManeuverGizmoScaling
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  public class MapManeuverGizmoScaling : KerbalMonoBehaviour
  {
    [SerializeField]
    private Camera _cameraToScaleFor;
    [SerializeField]
    [Range(0.0f, 100f)]
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
