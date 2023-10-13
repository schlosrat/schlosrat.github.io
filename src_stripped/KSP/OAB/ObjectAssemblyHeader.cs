// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyHeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class ObjectAssemblyHeader : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    [Space]
    private LaunchLocationManager _launchLocationManager;
    public Button launchButton;
    public Button exitButton;
    public OABAutosave OABAutoSave;
    [SerializeField]
    private TextMeshProUGUI locationText;
    private DataContext _oahDataContext;
    private ObjectAssemblyUIEvents eventsUI;
    private ObjectAssemblyBuilderEvents eventsBuilder;
    [HideInInspector]
    public Property<string> LaunchLocationOption;
    [HideInInspector]
    public Property<string> LaunchButtonStatus;
    [HideInInspector]
    public Property<double> LaunchButtonDeltaV;
    [HideInInspector]
    public Property<bool> LaunchAvailable;

    public LaunchLocationManager LaunchLocationManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(ObjectAssemblyBuilder builder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateLocation(
      OABVariant variant,
      OABEnvironmentType env,
      OABConstructionType con)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnExit(InputAction.CallbackContext obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnExit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDefaultVesselText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyHeader() => throw null;
  }
}
