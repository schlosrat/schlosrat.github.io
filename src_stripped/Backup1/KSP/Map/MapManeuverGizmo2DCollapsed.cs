// Decompiled with JetBrains decompiler
// Type: KSP.Map.MapManeuverGizmo2DCollapsed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
