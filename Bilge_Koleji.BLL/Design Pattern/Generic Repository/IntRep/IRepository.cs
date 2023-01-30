using ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Bilge_Koleji.BLL.Design_Pattern.Generic_Repository.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {
        //List Comands
        List<T> GetAll();
        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetUpdates();

        //Modify Comands
        void Add(T item);
        void AddRange(List<T> list);
        void Delete(T item);
        void DeleteRange(List<T> list);
        void Update(T item);
        void UpdateRange(List<T> list);
        void Destory(T item);
        void DestoryRange(List<T> list);

        //Ling

        List<T> Where(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        T FirstOfDefault(Expression<Func<T, bool>> exp);
        object Select(Expression<Func<T, bool>> exp);
        IQueryable<X> SelectViaClass<X>(Expression<Func<T, X>> exp);

        //Find Comand
        T Find(int id);

        //Get LastDatas
        List<T> GetLastDatas(int number);

        //Get FirstDatas
       List<T> GetFirstDatas(int number);



    }
}
