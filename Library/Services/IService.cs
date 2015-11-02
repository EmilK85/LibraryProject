//Emil Kronström & Love Hermansson
//OOP2
//02/11 -15
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;

namespace Library.Services {
    /// <summary>
    /// Allows services to notify when their
    /// underlying data model changes.
    /// </summary>
    interface IService {
        event EventHandler Updated;
    }
}
