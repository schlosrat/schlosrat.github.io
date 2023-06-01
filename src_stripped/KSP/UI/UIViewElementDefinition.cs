// Decompiled with JetBrains decompiler
// Type: KSP.UI.UIViewElementDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  [Serializable]
  public class UIViewElementDefinition
  {
    public string ID;
    public ViewState State;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIViewElementDefinition DeepCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIViewElementDefinition() => throw null;
  }
}
