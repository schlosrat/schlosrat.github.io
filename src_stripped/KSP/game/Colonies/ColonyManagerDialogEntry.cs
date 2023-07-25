// Decompiled with JetBrains decompiler
// Type: KSP.Game.Colonies.ColonyManagerDialogEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game.Colonies
{
  public class ColonyManagerDialogEntry : KerbalMonoBehaviour
  {
    [SerializeField]
    private TextMeshProUGUI _labelFlight;
    [SerializeField]
    private TextMeshProUGUI _labelStatus;
    [SerializeField]
    private TextMeshProUGUI _labelOrigin;
    [SerializeField]
    private ButtonExtended _multiFunctionButton_1;
    [SerializeField]
    private ButtonExtended _multiFunctionButton_2;
    [SerializeField]
    private Text _multiFunctionButtonText_1;
    [SerializeField]
    private Text _multiFunctionButtonText_2;
    private ColonyManagerDialog _parent;
    private bool _flightMode;
    private ActiveFlight _flightTarget;
    private DeliveryRoute _routeTarget;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeFlight(ActiveFlight flight, ColonyManagerDialog parent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeRoute(DeliveryRoute route, ColonyManagerDialog parent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MFBFuction1() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MFBFuction2() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColonyManagerDialogEntry() => throw null;
  }
}
