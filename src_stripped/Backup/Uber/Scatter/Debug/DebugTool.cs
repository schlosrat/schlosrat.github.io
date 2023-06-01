// Decompiled with JetBrains decompiler
// Type: Uber.Scatter.Debug.DebugTool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Uber.Scatter.Debug
{
  [ExecuteInEditMode]
  public class DebugTool : MonoBehaviour
  {
    public Vector2 PolarSphereCorner;
    public float PolarSphereWidth;
    public float PolarSphereHeight;
    public float PolarSphereRadius;
    public VegetationSystemPro VegetationSystemPro;
    public bool AutomaticUpdate;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateCells() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PreloadCells() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearCells() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawPolarBox() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DebugTool() => throw null;
  }
}
