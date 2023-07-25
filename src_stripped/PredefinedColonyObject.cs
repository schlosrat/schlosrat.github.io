// Decompiled with JetBrains decompiler
// Type: PredefinedColonyObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[DisableCustomEditorBase]
[CreateAssetMenu(fileName = "PredefinedColonyObject", menuName = "ScriptableObjects/PredefinedColonyObject", order = 2)]
[Serializable]
public class PredefinedColonyObject : ScriptableObject
{
  public string SimObjectName;
  public bool HasPopulationComponent;
  public int PopulationFillLimit;
  public int PopulationFillVacancyDelay;
  public bool PopulationFillLimitEmptySubIdOnly;
  public bool PopulationCreateNewNonVeterans;
  public bool PopulationCreateNewVeterans;
  public bool PopulationReuseNonVeterans;
  public bool PopulationReuseVeterans;
  public bool HasTelemetryComponent;
  public bool IsCommNetSource;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PredefinedColonyObject() => throw null;
}
