using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading;
using EntityFrameworkSamples.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntityFrameworkSamples
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_PickSerialNumber()
        {
            string formatSerialNumber = null;
            bool saveFailed;

            do
            {
                saveFailed = false;
                using (var context = new GoodsContext())
                {
                    try
                    {
                        var serialNumber = context.SerialNumbers.Where(s => s.Date == DateTime.Now.Date).SingleOrDefault();

                        if (serialNumber == null)
                        {
                            serialNumber = new SerialNumber() { Date = DateTime.Now.Date, SomethingCount = 1 };
                            context.SerialNumbers.Add(serialNumber);
                        }
                        else
                        {
                            serialNumber.SomethingCount += 1;
                        }

                        context.SaveChanges();

                        formatSerialNumber = String.Format("{0:MMdd}-{1:00}", serialNumber.Date, serialNumber.SomethingCount);
                    }
                    catch (DbUpdateConcurrencyException concurrencyException)
                    {
                        saveFailed = true;

                        //發生Concurrency update的問題，將memory中現有欄位值更新為資料庫的值
                        var entry = concurrencyException.Entries.Single();
                        entry.OriginalValues.SetValues(entry.GetDatabaseValues());

                        // Waiting 1~99ms
                        Thread.Sleep(new Random(Guid.NewGuid().GetHashCode()).Next(1, 100));
                    }
                }
            } while (saveFailed);
        }
    }
}
