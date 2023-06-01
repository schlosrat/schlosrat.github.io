// Decompiled with JetBrains decompiler
// Type: KSP.Sim.BaseField
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
