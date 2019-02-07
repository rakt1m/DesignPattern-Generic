using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern_Generic.Models.EntityModels;
using DesignPattern_Generic.Repositories.Contracts;

namespace DesignPattern_Generic.Repositories.Repositories
{
   public class EntityModelRepository:Repository<EntityModel>,IEntityModelRepository
    {
    }
}
