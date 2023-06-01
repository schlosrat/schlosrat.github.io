// Decompiled with JetBrains decompiler
// Type: JTemp.UISearchBar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using TMPro;

namespace JTemp
{
  public class UISearchBar : UIInteract
  {
    public TMP_InputField inputField;
    public UIContainer containerToSearch;
    public bool constantlyUpdate;
    public Action<string> OnSearchFieldEdited;
    public Action<string> OnSearchFieldEndEdit;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void SetCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UISearchBar() => throw null;
  }
}
