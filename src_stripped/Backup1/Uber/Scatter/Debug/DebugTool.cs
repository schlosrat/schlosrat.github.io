// Decompiled with JetBrains decompiler
// Type: Uber.Scatter.Debug.DebugTool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
