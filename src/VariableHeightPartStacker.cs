// Decompiled with JetBrains decompiler
// Type: VariableHeightPartStacker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class VariableHeightPartStacker : KerbalMonoBehaviour
{
  public string AttachBoneName;
  [FormerlySerializedAs("stackCount")]
  [SerializeField]
  [Space(10f)]
  [Range(0.0f, 50f)]
  private int _stackCount;
  public GameObject BaseGameObject;
  [FormerlySerializedAs("repeatableStackObject")]
  public GameObject RepeatableStackObject;
  [FormerlySerializedAs("repeatableStackCollision")]
  [Tooltip("Used for a single scaled collision volume. Leave empty if collision lives on the repeatable stack object.")]
  public Transform ScalableStackCollision;
  [FormerlySerializedAs("topGameObject")]
  public GameObject TopGameObject;
  private List<GameObject> _stackedObjects;
  private float _initialStackCollisionScale;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateStack() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetStackCount(int newCount) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleScalableCollision(bool isActive) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetCollisionScale(int multiplier) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ReparentBaseTransform(Transform newParent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ResetStack() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public VariableHeightPartStacker() => throw null;
}
