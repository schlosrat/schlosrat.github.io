// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.VegetationBeacon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Utility;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Vegetation
{
  [AwesomeTechnologiesScriptOrder(99)]
  [ExecuteInEditMode]
  [HelpURL("http://www.awesometech.no/index.php/vegetation-beacon")]
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
