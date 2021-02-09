using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess //namespace -isim uzayı demek kolayca erişim
{
    //core katmanları diğer katmanlara bağımlı kalmaz 
    //generic constraint
    //class -ref tip demek
    //IEntity:IEntity olabilir veya IEntity implemente eden bir nesnne olabilir ama soyut nesne işe yaramaz
    //new():new lenebilir olmalı
   public interface TEntityRepository<T> where T:class,IEntity ,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);//filtre zorunlu değil ise tüm data
        T Get(Expression<Func<T, bool>> filter);//örnek kredi detayı gibi ,tek birşey detayı
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

     
    }
}
