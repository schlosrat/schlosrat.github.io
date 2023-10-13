// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ConnectionGraphNodeFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;

namespace KSP.Sim
{
  [Flags]
  public enum ConnectionGraphNodeFlags
  {
    None = 0,
    IsActive = 1,
    IsControlSource = 2,
  }
}
