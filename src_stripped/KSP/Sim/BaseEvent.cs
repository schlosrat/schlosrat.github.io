// Decompiled with JetBrains decompiler
// Type: KSP.Sim.BaseEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public class BaseEvent
  {
    public int id;
    public string name;
    public bool active;
    public bool guiActive;
    public bool requireFullControl;
    public bool guiActiveEditor;
    public bool guiActiveUncommand;
    public string guiIcon;
    public string guiName;
    public string category;
    public bool guiActiveUnfocused;
    public float unfocusedRange;
    public bool externalToEVAOnly;
    public bool advancedTweakable;
    public bool isPersistent;
    public bool assigned;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BaseEvent() => throw null;
  }
}
