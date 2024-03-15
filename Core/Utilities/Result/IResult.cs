using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    //temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; }//sadece okunabilir
        string Message { get; }//sadece okunabilir

        //yapmak istediğimiz void işlemleri (örneğin void add() başarılıysa Success döner, başarılı değilse Message döner)


    }
}
