// Decompiled with JetBrains decompiler
// Type: KSP.Utilities.Scripting.ScriptExecutionContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace KSP.Utilities.Scripting
{
  [Serializable]
  public enum ScriptExecutionContext
  {
    Invalid,
    Main,
    Simulation,
    Mission,
    Mod,
    Count,
  }
}
