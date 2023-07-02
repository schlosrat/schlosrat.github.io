// Decompiled with JetBrains decompiler
// Type: ThermalDebugToolPartRow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ThermalDebugToolPartRow : MonoBehaviour
{
  public TextMeshProUGUI partName;
  public TextMeshProUGUI thermalMass;
  public TextMeshProUGUI temperature;
  public TextMeshProUGUI wettedArea;
  public TextMeshProUGUI shockMult;
  public TextMeshProUGUI reentryFlux;
  public TextMeshProUGUI environmentFlux;
  public TextMeshProUGUI otherFlux;
  public TextMeshProUGUI exposedArea;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ThermalDebugToolPartRow() => throw null;
}
