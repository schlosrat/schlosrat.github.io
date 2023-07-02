// Decompiled with JetBrains decompiler
// Type: ToggleByDistance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class ToggleByDistance : MonoBehaviour
{
  [Tooltip("True = Off when too close, False = Off when too far")]
  [SerializeField]
  private bool turnOffWhenTooClose;
  [FormerlySerializedAs("GOsToToggle")]
  [SerializeField]
  private GameObject[] gameObjectsToToggle;
  [FormerlySerializedAs("target1")]
  [SerializeField]
  private Transform distanceTarget1;
  [SerializeField]
  [FormerlySerializedAs("target2")]
  private Transform distanceTarget2;
  [SerializeField]
  private float distanceThreshold;
  [Tooltip("Optional OffsetSliders to update with")]
  [SerializeField]
  private OffsetSliders updateTarget;
  private float distanceSquared;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateToggle() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ToggleByDistance() => throw null;
}
