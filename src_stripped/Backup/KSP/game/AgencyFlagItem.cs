﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.AgencyFlagItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class AgencyFlagItem : KerbalMonoBehaviour
  {
    private const string AGENCY_FLAGS_PREFIX = "Menu/NewCampaign/Agency Flags/";
    [SerializeField]
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;
    private Property<string> _flagName;
    private Property<Sprite> _flagIcon;
    private ToggleExtended _toggle;
    private AgencyFlagManager _agencyFlagManager;
    private AgencyFlag _agencyFlag;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(AgencyFlag flag, AgencyFlagManager agencyFlagManager, bool isFirst) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAgencyFlag() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAgencyFlagName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyFlagItem() => throw null;
  }
}
