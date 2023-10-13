// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Missions.Definitions.MissionGranter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace Assets.Scripts.Missions.Definitions
{
  [CreateAssetMenu(fileName = "MissionGranter", menuName = "ScriptableObjects/MissionGranter", order = 1)]
  public class MissionGranter : ScriptableObject
  {
    [Tooltip("Internal name key for finding this misison granter.")]
    public string NameKey;
    [Tooltip("The loc key string for the granter's display name.")]
    [Header("Mission Granter Name")]
    public string LocalizationNameKey;
    [Header("Mission Granter Description")]
    [Tooltip("The loc key string for the granter's description text.")]
    public string LocalizationDescriptionKey;
    [Header("Mission Granter Logo")]
    [Tooltip("The Addressable file key to the granter’s logo, if available. This will look like \"Assets/path/to/myImage.png\"")]
    public string LogoKey;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionGranter() => throw null;
  }
}
