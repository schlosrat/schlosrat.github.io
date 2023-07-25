// Decompiled with JetBrains decompiler
// Type: KSP.UI.KerbalManagerPanelContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public class KerbalManagerPanelContext : ApiDataContext
  {
    [DataList("kerbalSlotList")]
    public ContextListProperty<KerbalManagerSlotContext> KerbalSlotList;
    private Action _fill;
    private Action _empty;
    private Action<int> _transfer;
    [DataProperty("panelName")]
    public Property<string> PanelName;
    [DataProperty("panelType")]
    public Property<string> PanelType;
    [DataProperty("panelID")]
    public Property<string> PanelId;
    [DataProperty("hasRoom")]
    public Property<bool> HasRoom;
    [DataProperty("isEmpty")]
    public Property<bool> IsEmpty;

    [DataAction("fill")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Fill() => throw null;

    [DataAction("empty")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Empty() => throw null;

    [DataAction("transfer")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Transfer(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalManagerPanelContext(
      ContextListProperty<KerbalManagerSlotContext> kerbalSlotList,
      Action fillAction,
      Action emptyAction,
      Action<int> transferAction,
      string panelName,
      string panelType,
      string panelId,
      bool hasRoom,
      bool isEmpty)
    {
      throw null;
    }
  }
}
