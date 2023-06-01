// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Widget.UIWidget_info_resourcecost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Widget
{
  public class UIWidget_info_resourcecost : UIWidget
  {
    [Header("Resource Icon - Readable")]
    [SerializeField]
    private UIValueBinder icon;
    [SerializeField]
    [Header("Info - Readable")]
    private UIValueBinder infoText;

    public IUIValueBindable<Texture> Icon
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IUIValueBindable<string> InfoText
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIWidget_info_resourcecost() => throw null;
  }
}
