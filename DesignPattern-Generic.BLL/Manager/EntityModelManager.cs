using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern_Generic.BLL.Contracts;
using DesignPattern_Generic.Models.EntityModels;
using DesignPattern_Generic.Repositories.Contracts;

namespace DesignPattern_Generic.BLL.Manager
{
    public class EntityModelManager:Manager<EntityModel>,IEntityModelManager
    {
        public EntityModelManager(IEntityModelRepository repository) : base(repository)
        {
            
        }
    }
}
