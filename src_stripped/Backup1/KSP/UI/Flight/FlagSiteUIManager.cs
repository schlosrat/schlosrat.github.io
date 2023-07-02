// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.FlagSiteUIManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Messages;
using KSP.Sim.impl;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Flight
{
  public class FlagSiteUIManager : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _flagSiteBindRoot;
    [SerializeField]
    private CanvasGroup _canvasGroup;
    [SerializeField]
    private InputFieldExtended _siteNameInputField;
    [SerializeField]
    private InputFieldExtended _siteDescriptionInputField;
    private KerbalBehavior _kerbalBehavior;
    private const string DATA_CONTEXT_NAME = "FlagSite";
    private const string ACTION_CANCEL_KEY = "OnCancelFlagSite";
    private const string ACTION_ACCEPT_KEY = "OnAcceptFlagSite";
    private DataContext _uiData;
    private bool _isInitialized;

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BindContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameStateChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPlantFlag(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CanShowFlagSite(GameState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Cancel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Accept() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlagSiteUIManager() => throw null;
  }
}
