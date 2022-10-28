using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KappaESB.Interfaces.General
{
    /// <summary>
    /// Основные действия, которые происходят для всех запросов на сервер. Ипользуется, например, для авторизации.
    /// </summary>
    public interface IGeneralAction
    {
        /// <summary>
        /// Выполнить действие до того, как будет выполнена основная логика запроса.
        /// </summary>
        /// <param name="func">Выполняемое действие. В случае успешного выполнения необходимо вернуть true, иначе - false, и выполнение действий прервется.</param>
        /// <returns></returns>
        IGeneralAction DoBefore(Func<HttpContext, bool> func);
        /// <summary>
        /// Выполнить действие после, как будет выполнена основная логика запроса.
        /// </summary>
        /// <param name="func">Выполняемое действие. Прервать действие уже нельзя.</param>
        /// <returns></returns>
        IGeneralAction DoAfter(Action<HttpContext> func);
    }
}
