using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace DataAccess.Concrete.EntityFramework;

public class EfPropertyDal : IPropertyDal
{
    public void Add(Property entity)
    {
        using (BrithomeContext context = new())
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }
    }

    public void Delete(Property entity)
    {
        using (BrithomeContext context = new())
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }

    public Property Get(Expression<Func<Property, bool>> filter)
    {
        using (BrithomeContext context = new())
        {
            return context.Set<Property>().SingleOrDefault(filter);

        }
    }

    public List<Property> GetAll(Expression<Func<Property, bool>> filter = null)
    {
        using (BrithomeContext context = new()) { 
        return filter == null 
            ? context.Set<Property>().ToList()
            : context.Set<Property>().Where(filter).ToList();
        }
    }

    public void Update(Property entity)
    {
        using (BrithomeContext context = new())
        {

            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }

    }
}