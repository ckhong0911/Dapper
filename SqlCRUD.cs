using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  internal class SqlCRUD
  {
    // Connect string
    public static string cnn =
      $"Data Source={Properties.Settings.Default.ip};" +
      $"Initial Catalog=CT_PSI;Persist Security Info=True;" +
      $"User ID={Properties.Settings.Default.account};" +
      $"Password={Properties.Settings.Default.password};" +
      $"Pooling=False";
  }
}
