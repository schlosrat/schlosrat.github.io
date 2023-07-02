// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.Data.IDemoTelemetry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.Generic;
using System;

namespace KSP.Iteration.Data
{
  public interface IDemoTelemetry
  {
    event Action TelemetryUpdated;

    IProperty<float> Altitude { get; }

    IProperty<float> Velocity { get; }
  }
}
