﻿// Decompiled with JetBrains decompiler
// Type: UITripPlannerItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class UITripPlannerItem : KerbalMonoBehaviour
{
  [SerializeField]
  [Header("Self")]
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
