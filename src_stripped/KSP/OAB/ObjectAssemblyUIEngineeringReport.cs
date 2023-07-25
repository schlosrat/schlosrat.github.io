// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyUIEngineeringReport
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.UI;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  [RequireComponent(typeof (KSP2UIWindow))]
  public class ObjectAssemblyUIEngineeringReport : KerbalMonoBehaviour
  {
    public GameObject FlawListLineItemPrefab;
    public Transform FlawListRoot;
    private ObjectAssemblyUIEvents _eventsUI;
    private OABSessionInformation _stats;
    private Coroutine _updateFlawsCoroutine;
    private ObjectAssemblyUIEngineeringReportAssemblyStats _assemblyStatsUIHandler;
    private KSP2UIWindow _uiWindow;
    private CanvasGroup _canvasGroup;
    private bool _isInitialized;
    private AssemblyPartsPicker _assemblyPartsPicker;
    private RectTransform _flawListRootRect;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      OABSessionInformation stats,
      ObjectAssemblyBuilderEvents eventsBuilder,
      ObjectAssemblyUIEvents eventsUI,
      AssemblyPartsPicker assemblyPartsPicker)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnWindowResized(RectTransform rect) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDataAndUi() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateUi() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateConcernsList(bool updateData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator ProcessUpdate(bool updateData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleInteractivity(bool bValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyUIEngineeringReport() => throw null;
  }
}
