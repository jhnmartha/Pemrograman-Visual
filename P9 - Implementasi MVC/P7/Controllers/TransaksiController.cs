using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P7.Models;

namespace P7.Controllers
{
    internal class TransaksiController
    {
        public List<TransaksiModel> AmbilSemuaTransaksi()
        {
            return TransaksiModel.GetAll();
        }

        public void TambahTransaksi(TransaksiModel transaksi)
        {
            transaksi.Insert();
        }

        public void UbahTransaksi(TransaksiModel transaksi)
        {
            transaksi.Update();
        }

        public void HapusTransaksi(int id)
        {
            var transaksi = new TransaksiModel { Id = id };
            transaksi.Delete();
        }
    }
}
