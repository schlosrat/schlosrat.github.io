// Decompiled with JetBrains decompiler
// Type: PredefinedColonyObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
