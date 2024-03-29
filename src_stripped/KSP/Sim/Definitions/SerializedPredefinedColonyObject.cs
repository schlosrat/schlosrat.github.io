﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.SerializedPredefinedColonyObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine.Serialization;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public struct SerializedPredefinedColonyObject
  {
    [FormerlySerializedAs("simObjectName")]
    public string SimObjectName;
    public bool HasPopulationComponent;
    public int PopulationFillLimit;
    public int PopulationFillVacancyDelay;
    public bool PopulationFillLimitEmptySubIdOnly;
    public bool PopulationReuseNonVeterans;
    public bool PopulationReuseVeterans;
    public bool PopulationCreateNewNonVeterans;
    public bool PopulationCreateNewVeterans;
    public bool HasTelemetryComponent;
    public bool IsCommNetSource;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedPredefinedColonyObject(PredefinedColonyObject colonyObject) => throw null;
  }
}
