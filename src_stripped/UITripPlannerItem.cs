// Decompiled with JetBrains decompiler
// Type: UITripPlannerItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class UITripPlannerItem : KerbalMonoBehaviour
{
  [Header("Self")]
  [SerializeField]
  private TextMeshProUGUI _destinationNameText;
  [SerializeField]
  private TextMeshProUGUI _dvCostText;
  [SerializeField]
  private string dvCostFormat;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Show(string destination, double deltaVCost) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Hide() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public UITripPlannerItem() => throw null;
}
