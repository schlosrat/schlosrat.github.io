// Decompiled with JetBrains decompiler
// Type: KSP.Game.AgencyFlagItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
