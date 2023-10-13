// Decompiled with JetBrains decompiler
// Type: UITripPlannerItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
