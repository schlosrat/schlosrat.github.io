// Decompiled with JetBrains decompiler
// Type: KSP.Game.StartupFlow.LegalMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game.StartupFlow
{
  public class LegalMenu : KerbalMonoBehaviour
  {
    private const string EULA_VERSION = "1";
    private const string PRIVACY_POLICY_VERSION = "2";
    private const string TERMS_OF_SERVICE_VERSION = "1";
    private const string MAIN_MENU_PREFIX = "Menu/Main/";
    private const string PHOTOSENSITIVITY_KEY = "SeizureWarningTitle";
    private const string EULA_FULL_KEY = "EULA full";
    private const string PRIVACY_POLICY_KEY = "Privacy Policy";
    private const string TERMS_OF_SERVICE_KEY = "Terms Of Service";
    private const string ACCEPT_KEY = "I accept";
    private const string NEXT_KEY = "Next";
    private const string PRIVACY_POLICY_ACCEPT_INFO_KEY = "PrivacyPolicyAcceptInfo";
    private const string EULA_LINK = "https://www.take2games.com/eula/";
    private const string PRIVACY_POLICY_LINK = "https://www.take2games.com/privacy/";
    private const string TERMS_OF_SERVICE_LINK = "https://www.take2games.com/legal/";
    private const float MIN_PHOTOSENSITIVITY_SECONDS = 2f;
    private const float MAX_PHOTOSENSITIVITY_SECONDS = 10f;
    public ContextBindRoot BindRoot;
    [SerializeField]
    private ScrollRect _legalScroll;
    [SerializeField]
    private List<LanguageFontAsset> languageFontAssets;
    [Header("Legal Submenus")]
    [SerializeField]
    private LegalSubmenu _eula;
    [SerializeField]
    private LegalSubmenu _privacyPolicy;
    [SerializeField]
    private LegalSubmenu _termsOfService;
    [SerializeField]
    private LegalSubmenu _photosensitivity;
    private Property<string> _menuTitleKey;
    private Property<string> _eulaText;
    private Property<string> _acceptButtonKey;
    private Property<string> _acceptInfoKey;
    private Property<bool> _showAccept;
    private Property<bool> _showAcceptInfo;
    private Property<bool> _showBack;
    private Property<bool> _isAcceptEnabled;
    private DataContext _dataContext;
    private List<LegalSubmenu> _submenus;
    private List<Coroutine> _runningCoroutines;
    private string _currentLanguage;
    private bool _waitingForContentLoad;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OpenEULA() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OpenPrivacyPolicy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OpenTermsOfService() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OpenPhotosensitivityWarning() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StartupFlow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OpenEULALink() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OpenPrivacyPolicyLink() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OpenTermsOfServiceLink() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLegalAccepted() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnBackPressed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FinishStartupFlow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadLegalTexts() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AreAllLegalTextsAccepted() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAcceptanceForAllLegalTextsLatestVersion() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSystemLaguageAsCurrent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator SetBoolPropertyAfterSeconds(
      Property<bool> property,
      bool value,
      float seconds)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator AutoAcceptAfterSeconds(float seconds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegalMenu() => throw null;
  }
}
