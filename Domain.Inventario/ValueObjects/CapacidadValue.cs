using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Inventario.ValueObjects
{
    public record CapacidadValue : ValueObject
    {
        public long Value { get; }
        public CapacidadValue(long value)
        {
            if (value < 0)
            {
                throw new BussinessRuleValidationException("Cantidad no puede ser negativa");
            }
            Value = value;
        }

        public static implicit operator long(CapacidadValue value)
        {
            return value.Value;
        }

        public static implicit operator CapacidadValue(long value)
        {
            return new CapacidadValue(value);
        }
    }
}
