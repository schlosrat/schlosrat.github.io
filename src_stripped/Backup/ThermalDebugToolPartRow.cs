// Decompiled with JetBrains decompiler
// Type: ThermalDebugToolPartRow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ThermalDebugToolPartRow : MonoBehaviour
{
  public TextMeshProUGUI partName;
  public TextMeshProUGUI thermalMass;
  public TextMeshProUGUI temperature;
  public TextMeshProUGUI wettedArea;
  public TextMeshProUGUI shockMult;
  public TextMeshProUGUI reentryFlux;
  public TextMeshProUGUI environmentFlux;
  public Button focusButton;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ThermalDebugToolPartRow() => throw null;
}
