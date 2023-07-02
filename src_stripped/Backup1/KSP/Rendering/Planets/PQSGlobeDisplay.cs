// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQSGlobeDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  [AddComponentMenu("PQuadSphere/Tools/Globe Display")]
  public class PQSGlobeDisplay : MonoBehaviour
  {
    public Color color;
    public Font font;
    public float altitude;
    public int resolution;
    public int latitudeLines;
    public int longitudeLines;
    private PQS pqs;
    private Mesh globeMesh;
    private Material globeMaterial;
    private Canvas textCanvas;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateGlobe() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateLatitudeLines(List<Vector3> verts, List<int> points) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<Vector3> CreateLatitudeLine(float latitude) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateLongitudeLines(List<Vector3> verts, List<int> points) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<Vector3> CreateLongitudeCircle(float longitude) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateGlobeNumber(int value, bool isLatitude, Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSGlobeDisplay() => throw null;
  }
}
