﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselDeltaVCalculationMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.DeltaV;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  public class VesselDeltaVCalculationMessage : FlightMessageBase
  {
    public VesselDeltaVComponent DeltaVComponent;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselDeltaVCalculationMessage() => throw null;
  }
}