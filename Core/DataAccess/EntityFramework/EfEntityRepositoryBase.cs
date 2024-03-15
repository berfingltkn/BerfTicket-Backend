using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var entityToAdd = context.Entry(entity);
                entityToAdd.State = EntityState.Added;
                context.SaveChanges();

                //using(){} ->  nesnenin kullanıldıktan sonra otomatik temizlenmesini sağlar.
                //Entry -> entity varlığı context üzerinde izlenen bir varlık haline gelir. Bu, entity framework tarafından değişiklikleri takip etme, veritabanına ekleme veya güncelleme için kullanılan bir mekanizmadır
                //State ile entityToAdd üzerindeki durum değiştirilir ve varlığın eklenmesi gerektiği belirtilir. Bu entity framework e yeni bir ekleme olduğunu belirtir.
                //SaveChanges()-> değişiklikler veritabanına kaydedilir.


            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var entityToDelete = context.Entry(entity);
                entityToDelete.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                //eğer filtre yoksa hepsini listele, filtre varsa filtreye uygun listele.
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var entityToUpdate = context.Entry(entity);
                entityToUpdate.State = EntityState.Modified;
                context.SaveChanges();


            }
        }
    }
}
