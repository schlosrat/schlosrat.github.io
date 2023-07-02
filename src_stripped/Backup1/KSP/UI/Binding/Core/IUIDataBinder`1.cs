// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.IUIDataBinder`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.UI.Binding.Core
{
  public interface IUIDataBinder<T> : IUIDataBindable<T>, IUIDataBindable
  {
    T Data { get; }
  }
}
