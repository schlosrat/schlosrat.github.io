// Decompiled with JetBrains decompiler
// Type: TrackRigObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class TrackRigObject : MonoBehaviour
{
  public Transform targetToTrack;
  public bool keepInitialOffset;
  public TrackRigObject.TrackMode trackingMode;
  private Transform thisTransform;
  private Vector3 posOffset;
  private Quaternion rotOffset;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void FixedUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Track() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TrackRigObject() => throw null;

  public enum TrackMode
  {
    FixedUpdate,
    Update,
    LateUpdate,
  }
}
