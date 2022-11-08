using ShareKernel.Core;
using ShareKernel.Rules;

namespace ShareKernel.ValueObjects
{
    public record DescripcionValue : ValueObject
    {
        public string Descripcion { get; }

        public DescripcionValue(string name)
        {
            CheckRule(new StringNotNullOrEmptyRule(name));
            if(name.Length > 500)
            {
                throw new BussinessRuleValidationException("Descripcion no puede tener mas de 500 caracteres");
            }
            Descripcion = name;
        }

        public static implicit operator string(DescripcionValue value)
        {
            return value.Descripcion;
        }

        public static implicit operator DescripcionValue(string name)
        {
            return new DescripcionValue(name);
        }
    }
}
