// Decompiled with JetBrains decompiler
// Type: KSP.Map.GizmoTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Map
{
  public class GizmoTest : fx_fly_camera
  {
    public MapManeuverGizmo Gizmo;
    public TextMeshProUGUI DebugText;
    public List<GizmoTestFocusCommand> Focusable;
    public Camera PerspectiveCam;
    public Toggle Toggle;
    private Vector3? _last;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PositionGizmo(Vector3 pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoTest() => throw null;
  }
}
