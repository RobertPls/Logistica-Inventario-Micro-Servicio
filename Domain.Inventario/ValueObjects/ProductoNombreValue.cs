using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.ValueObjects
{
    public record ProductoNombreValue : ValueObject
    {
        public string Name { get; }

        public ProductoNombreValue(string name)
        {
            CheckRule(new StringNotNullOrEmptyRule(name));
            if (name.Length > 100)
            {
                throw new BussinessRuleValidationException("ProductoNombre no puede tener mas de 100 caracteres");
            }
            Name = name;
        }

        public static implicit operator string(ProductoNombreValue value)
        {
            return value.Name;
        }

        public static implicit operator ProductoNombreValue(string name)
        {
            return new ProductoNombreValue(name);
        }
    }
}
