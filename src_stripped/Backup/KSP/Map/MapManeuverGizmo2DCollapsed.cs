// Decompiled with JetBrains decompiler
// Type: KSP.Map.MapManeuverGizmo2DCollapsed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  public class MapManeuverGizmo2DCollapsed : KerbalMonoBehaviour
  {
    [SerializeField]
    private Canvas _canvas;
    public CanvasGroup Menu;
    public CanvasGroup Idle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEventCamera(Camera toUse) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapManeuverGizmo2DCollapsed() => throw null;
  }
}
