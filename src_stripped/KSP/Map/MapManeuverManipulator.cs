// Decompiled with JetBrains decompiler
// Type: KSP.Map.MapManeuverManipulator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  public class MapManeuverManipulator : KerbalMonoBehaviour
  {
    public Color baseColor;
    public Color highlightColor;
    public MapManeuverManipulator oppositeManipulator;
    public MeshRenderer headRenderer;
    public MeshRenderer oppositeHeadRenderer;
    public MeshRenderer tailRenderer;
    public MeshRenderer oppositeTailRenderer;
    public ManeuverGizmoInputType handleType;
    private RaycastHit[] _raycastHits;
    private static MapManeuverManipulator currentHighlight;

    public static MapManeuverManipulator CurrentHighlightedManipulator
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapManeuverManipulator() => throw null;
  }
}
