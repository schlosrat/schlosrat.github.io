// Decompiled with JetBrains decompiler
// Type: JTemp.UISearchBar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
