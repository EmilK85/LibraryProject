//Emil Kronström & Love Hermansson
//OOP2
//02/11 -15
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories {
    /// <summary>
    /// Basic repository functionality, exposes CRUD-operations.
    /// </summary>
    interface IRepository<T, Tid> {
        void Add(T item);
        void Remove(T item);
        T Find(Tid id);
        void Edit(T item);
        IEnumerable<T> All();
    }
}
