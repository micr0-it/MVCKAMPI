﻿using DataAccesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context context = new Context();
        DbSet<T> _object; // T değerine karsılık gelen sınıfı tutar

        //T degerıne karsılık gelecek sınıfı yapıcı methodla bulucaz
        public GenericRepository()
        {
            _object = context.Set<T>();  //Contexte baglı oalrak gonderılen t degerı
        }
        public void Delete(T p)
        {
            var SilinenEntity = context.Entry(p);
            SilinenEntity.State = EntityState.Deleted;
            //_object.Remove(p);
            context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter); //sadece bir değer döndürür
        }

        public void Insert(T p)
        {
            var EklenenEntity = context.Entry(p);
            EklenenEntity.State = EntityState.Added;
            //_object.Add(p);
            context.SaveChanges();
        }

        public List<T> List()  // HER ŞEYİ GETİR
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)  // PARAMETREYE GÖRE GETİR ŞARTA UYUYORSA
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var GüncellenenEntity = context.Entry(p);
            GüncellenenEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
