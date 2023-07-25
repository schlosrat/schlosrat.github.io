// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.VegetationBeacon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Utility;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Vegetation
{
  [ExecuteInEditMode]
  [HelpURL("http://www.awesometech.no/index.php/vegetation-beacon")]
  [AwesomeTechnologiesScriptOrder(99)]
  public class VegetationBeacon : MonoBehaviour
  {
    public float Radius;
    public AnimationCurve FalloffCurve;
    public List<VegetationTypeSettings> VegetationTypeList;
    private Vector3 _lastPosition;
    private Quaternion _lastRotation;
    private BeaconMaskArea _currentMaskArea;
    private bool _needInit;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateVegetationMask() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddVegetationTypes(BaseMaskArea maskArea) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationBeacon() => throw null;
  }
}
