// Decompiled with JetBrains decompiler
// Type: KSP.Game.Kerbal3DModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Modding.Variety;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Game
{
  public class Kerbal3DModel : KerbalMonoBehaviour, IUpdate
  {
    private const string EVA_ASSET_PREFIX = "KerbalEVA_";
    private const string IVA_ASSET_PREFIX = "KerbalIVA_";
    private bool verboseLogging;
    public KerbalInfo ThisKerbalInfo;
    public bool CharacterExists;
    public bool IsEVAKerbal;
    public bool IsInExternalSeat;
    [FormerlySerializedAs("StatRulesSetName")]
    [FormerlySerializedAs("StatGroupName")]
    public string AttributesRulesSetName;
    public Action<string> OnCharacterCompletelyGenerated;
    [SerializeField]
    private bool userOverrideForceGenerateOnStartup;
    [SerializeField]
    private string overrideCharacterKey;
    private KerbalRosterManager _manager;
    private Dictionary<string, VarietyPreloadInfo> _preloadedAttributes;
    private int _characterReuseCooldown;
    private int _reuseCooldownCount;
    private bool _animatorsInitialized;
    private GameObject _modelsRoot;

    public int SeatIdx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] internal set => throw null;
    }

    public string FullName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Dictionary<string, object> Attributes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    private bool IsReadyToGenerate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool IsGenerating
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAttribute(string attribute, object value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object GetAttribute(string attribute) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PreloadAllAsyncAssets(
      Dictionary<string, KerbalVarietyAttributeRule> attributeRules,
      KerbalAttributes kerbalAttributes,
      Action callbackFinished)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AttachToNamedParent(GameObject goToAttach, string attachTargetsName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Build3DKerbal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Build3DKerbal(KerbalAttributes kerbalAttributes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Build3DKerbal(
      Dictionary<string, KerbalVarietyAttributeRule> attributeRules,
      KerbalAttributes kerbalAttributes)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuildCharacterFromLoadedAttributes(
      Dictionary<string, KerbalVarietyAttributeRule> attributeRules,
      Dictionary<string, VarietyPreloadInfo> preloadedAttributes)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableJetpackModel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RecursivelyApplyPreloadedAttributes(
      Dictionary<string, VarietyPreloadInfo> preloadedAttributes,
      string attributeName,
      KerbalVarietyAttributeRule attributeRule)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmptySeat() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitAnimationManagers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryToInit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IUpdate.OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Kerbal3DModel() => throw null;
  }
}
