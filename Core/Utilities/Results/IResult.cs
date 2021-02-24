using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{   
    //Temel voidler için başlangıç.
    public interface IResult
    {
        bool Success { get; } // Yapmaya çalıştığın işlem başarılı mı? Başarısız mı ? Read only.
        string Message { get; } // Başarılı,Başarısız Read Only.
    }
}
