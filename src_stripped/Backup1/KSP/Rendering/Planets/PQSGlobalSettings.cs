// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQSGlobalSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  [CreateAssetMenu(fileName = "pqs_settings", menuName = "KSP/Settings/PQS Settings")]
  public class PQSGlobalSettings : ScriptableObject
  {
    public PQSGlobalSettings.SubdivisionInfo subdivisionInfo;
    public float colliderCullingDistance;
    public GameObject colliderPrefab;
    public Material pqsShadowMaterial;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSGlobalSettings() => throw null;

    [Serializable]
    public class SubdivData
    {
      [Tooltip("Minimum subdivision level (quad depth)")]
      public int minLevel;
      [Tooltip("Maximum subdivision level (quad depth)")]
      public int maxLevel;
      [Tooltip("The multiple of the planet radius where the tesselation level is set to minLevel")]
      public int minDetailMultiplier;
      [Tooltip("The altitude radius multiplier in which we stop trying to perform quad subdivision")]
      public float disableSubdivRadiusMultiplier;
      [Tooltip("A multiplier for each of the subdivision threshold calculations")]
      public float subdivisionThreshold;
      [Tooltip("Surface altitude to use the surface settings at")]
      [Header("Terrain Tesselation Settings")]
      public float surfaceSettingsAltitude;
      [Tooltip("Surface - distance cone altitude falloff")]
      public float surfaceTesselationAltitudeFalloff;
      [Tooltip("Surface - distance in the camera forward direction to extend terrain tesselation out to")]
      public float surfaceTesselationDistance;
      [Tooltip("Orbit altitude to use the orbit settings at")]
      public float orbitSettingsAltitude;
      [Tooltip("Orbit - distance cone altitude falloff")]
      public float orbitTesselationAltitudeFalloff;
      [Tooltip("Orbit - distance in the camera forward direction to extend terrain tesselation out to")]
      public float orbitTesselationDistance;
      [Tooltip("The number of steps to use for tesselation calculations in front of the camera")]
      public int numTesselationSteps;
      [Tooltip("The frustum cone angle to use for the tesselation frustum")]
      [Range(0.0f, 60f)]
      public float tesselationFrustumAngle;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SubdivData() => throw null;
    }

    [Serializable]
    public class SubdivisionInfo
    {
      public PQSGlobalSettings.SubdivData subdivData;
      public double collapseSeaLevelValue;
      public double collapseAltitudeValue;
      public double collapseAltitudeMax;
      public double visRadSeaLevelValue;
      public double visRadAltitudeValue;
      public double visRadAltitudeMax;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Setup(PQS pqs, PQData d, PQSGlobalSettings.SubdivData sd) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SubdivisionInfo() => throw null;
    }
  }
}
