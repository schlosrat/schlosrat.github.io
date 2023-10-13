// Decompiled with JetBrains decompiler
// Type: ToggleByDistance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class ToggleByDistance : MonoBehaviour
{
  [SerializeField]
  [Tooltip("True = Off when too close, False = Off when too far")]
  private bool turnOffWhenTooClose;
  [FormerlySerializedAs("GOsToToggle")]
  [SerializeField]
  private GameObject[] gameObjectsToToggle;
  [SerializeField]
  [FormerlySerializedAs("target1")]
  private Transform distanceTarget1;
  [FormerlySerializedAs("target2")]
  [SerializeField]
  private Transform distanceTarget2;
  [SerializeField]
  private float distanceThreshold;
  [SerializeField]
  [Tooltip("Optional OffsetSliders to update with")]
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
