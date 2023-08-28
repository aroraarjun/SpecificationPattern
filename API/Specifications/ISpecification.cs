using System.Linq.Expressions;

namespace API.Specifications
{
    public interface ISpecification<T>
    {
        //creating  generic expression -- expression taking function , function taking type return bool
        Expression<Func<T, bool>> Criteria {get;}
        List<Expression<Func<T, object>>> Includes {get;}
    }
}