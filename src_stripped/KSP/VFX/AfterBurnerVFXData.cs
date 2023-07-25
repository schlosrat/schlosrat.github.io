// Decompiled with JetBrains decompiler
// Type: KSP.VFX.AfterBurnerVFXData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
