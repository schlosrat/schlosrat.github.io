// Decompiled with JetBrains decompiler
// Type: KSP.Api.IDataContextWritable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;

namespace KSP.Api
{
  public interface IDataContextWritable
  {
    void SetHierarchyParent(IDataContextReadonly subParent, bool fireEvent = true);

    void AddProperty(string key, IProperty property);

    void AddAction(string key, IAction action);

    void AddList(string key, IContextListProperty list);

    void AddSubContext(string key, IDataContextReadonly subContext);

    void RemoveProperty(string key);

    void RemoveAction(string key);

    void RemoveList(string key);

    void RemoveSubContext(string key);

    void SetNumberRange(string key, UIValueNumberRange numberRange);

    void SetLabel(string key, string locKey);

    void SetToStringDelegate(string key, ToStringDelegate toStringDelegate);

    void ClearNumberRange(string key);

    void ClearLabel(string key);

    void ClearToStringDelegate(string key);

    void ClearAllData();
  }
}
