// Decompiled with JetBrains decompiler
// Type: KSP.Sim.BaseEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
