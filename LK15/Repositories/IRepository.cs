using LK15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK15
{
    public interface IRepository<T>
    {
        public ShopContext shopContext { get; set; }
        T Get(int id);
        void Update(T entity);
        void Delete(int id);
        void Add (T entity);
    }
}
 