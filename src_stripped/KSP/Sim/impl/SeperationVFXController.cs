// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.SeperationVFXController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class SeperationVFXController : MonoBehaviour
  {
    [HideInInspector]
    public PartBehavior thisPart;
    [HideInInspector]
    public int curNumberOfVFXSpawned;
    [HideInInspector]
    public Dictionary<Joint, Tuple<Vector3, Quaternion>> potentialVFXPosRots;
    [SerializeField]
    [Tooltip("First is name of atmo effect, Second is name of vacuum effect.")]
    private SeperationVFXController.atmoVacNamePair[] pairsOfVFXNamesFromManifest;
    private AtmosphereTransitionVFXHandling atmoFadeHandler;
    private List<Tuple<GameObject, GameObject>> currentSeperationVFX;
    private const int numberOfAllowedSeperationVFXPerPart = 1;
    private bool initialized;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(PartBehavior part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TrySpawnBreakVFX(ConfigurableJoint joint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Quaternion CalcVFXOrientation(Vector3 jointLocalPos, Transform partTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator InstantiateSeperationVFX(
      SeperationVFXController.atmoVacNamePair atmoVacNamePair,
      PartBehavior partToAttachTo,
      Vector3 localPos,
      string tagName)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAtmoVacFading() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SeperationVFXController() => throw null;

    [Serializable]
    internal struct atmoVacNamePair
    {
      public string atmoVFXName;
      public string vacVFXName;
    }
  }
}
