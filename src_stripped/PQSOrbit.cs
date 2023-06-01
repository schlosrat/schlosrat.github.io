// Decompiled with JetBrains decompiler
// Type: PQSOrbit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Rendering.Planets;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("PQuadSphere/Tools/Orbit Camera")]
public class PQSOrbit : MonoBehaviour
{
  public bool isActive;
  public double rotationSpeed;
  private double smooth;
  private double distanceMin;
  private double distanceMax;
  private double scrollSpeed;
  private double x;
  private double y;
  private double distanceCurrent;
  private bool showGUI;
  private QuaternionD smoothedQ;
  private Vector3d smoothPos;
  private Vector3d realPos;
  private Transform target;
  private PQS pqs;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Reset() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnGUI() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateMouse() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InputUI() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateTransform() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PQSOrbit() => throw null;
}
