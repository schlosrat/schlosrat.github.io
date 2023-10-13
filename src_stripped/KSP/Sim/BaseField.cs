// Decompiled with JetBrains decompiler
// Type: KSP.Sim.BaseField
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class BaseField
  {
    public bool active;
    public bool guiActive;
    public bool guiActiveEditor;
    public string guiName;
    public string guiUnits;
    public string guiFormat;
    public string category;
    public bool advancedTweakable;
    public bool uiControlOnly;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BaseField(
      string name,
      string units,
      string format,
      string category,
      bool advancedTweakable,
      bool uiControlOnly)
    {
      throw null;
    }
  }
}
