using AvaloniaControls.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Dialogs.Internal;

namespace Shop;


public class TableTecnic : AvaloniaDialogsInternalViewModelBase
{
  public ObservableCollection<Tecnic> Products { get; }

  public TableTecnic()
  {
    var products = new List<Tecnic> 
    {
      new Tecnic("Neil", "Armstrong"),
      new Tecnic("Buzz", "Lightyear"),
      new Tecnic("James", "Kirk")
    };
    Products = new ObservableCollection<Tecnic>(products);
  }
}
