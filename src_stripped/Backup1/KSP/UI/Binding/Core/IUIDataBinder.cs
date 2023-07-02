// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.IUIDataBinder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace KSP.UI.Binding.Core
{
  public interface IUIDataBinder : IUIDataBindable
  {
    bool IsBound { get; }

    Type BoundType { get; }

    object GetDataObject();

    T GetDataObjectAs<T>() where T : class;
  }
}
