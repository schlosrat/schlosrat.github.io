// Decompiled with JetBrains decompiler
// Type: KSP.VFX.AfterBurnerVFXData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  public class AfterBurnerVFXData : KerbalMonoBehaviour
  {
    [SerializeField]
    private SkinnedMeshRenderer _targetSkinnedMesh;
    [SerializeField]
    private int _afterBurnerBlendShapeIndex;
    [SerializeField]
    private float _minBlendShapeWeight;
    [SerializeField]
    private float _maxBlendShapeWeight;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBlendshapeWeightBy0To1(float zeroToOneValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetMinMaxBlendShapeWeightFrom0To1(float zeroToOneValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AfterBurnerVFXData() => throw null;
  }
}
