using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Aplication.AutoMapper
{
    public class AutoMapperConfig
    {
        public static Type[] RegisterMappings()
        {
            return new Type[]
            {
                typeof(MappingsProfile)
            };
        }
    }
}
