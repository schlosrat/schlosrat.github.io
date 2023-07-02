// Decompiled with JetBrains decompiler
// Type: PredefinedColonyObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
