// Decompiled with JetBrains decompiler
// Type: KSP.Map.Map3DSpaceProviderTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  public class Map3DSpaceProviderTarget : KerbalMonoBehaviour
  {
    [Header("Local Position")]
    [Tooltip("Does this object have its local position impacted by the associated item's model?")]
    public bool adjustPosition;
    [Tooltip("Does this object have its local rotation impacted by the associated item's model?")]
    [Header("Local Rotation")]
    public bool adjustRotation;
    [Tooltip("Does this object have its local scale impacted by the associated item's model?")]
    [Header("Local Scale")]
    public bool adjustScale;
    [Tooltip("Hand-authored planets have additional scale to be accounted for. This does so during scale calculations. Try togging this if the object you have is way too small or way too large.")]
    public bool scaleAsAuthoredPlanet;
    [Tooltip("If this is 1, then the selection will be the radius of the reference model scaled for the map (for example, if it's a celestial body, scaleOversize would be the exact size of the 3D Scaled planet it in the map.)")]
    public double scaleOversize;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Map3DSpaceProviderTarget() => throw null;
  }
}
