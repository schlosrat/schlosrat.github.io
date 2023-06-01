// Decompiled with JetBrains decompiler
// Type: PQSObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Rendering.Planets;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class PQSObject : MonoBehaviour
{
  public Vector2 LatLong;
  public float Rotation;
  public float VerticalOffset;
  public float MaxVerticalOffset;
  public float MinVerticalOffset;
  public bool SavePlayModePosition;
  public PQS Pqs;
  private bool _needUpdate;
  private int frameCounter;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdatePosition() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Reset() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PQSObject() => throw null;
}
