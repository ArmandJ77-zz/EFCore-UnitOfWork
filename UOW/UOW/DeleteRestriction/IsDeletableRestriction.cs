using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace UOW.DeleteRestriction
{
    public static class IsDeletableRestriction
    {
        private const string IsDeletedProperty = "IsDeleted";

        private static readonly MethodInfo PropertyMethod =
            typeof(EF).GetMethod(nameof(EF.Property),
                BindingFlags.Static | BindingFlags.Public).MakeGenericMethod(typeof(bool));

        public static LambdaExpression GetRestrictionExpression(Type type)
        {
            var parm = Expression.Parameter(type, "it");
            var prop = Expression.Call(PropertyMethod, parm, Expression.Constant(IsDeletedProperty));
            var condition = Expression.MakeBinary(ExpressionType.Equal, prop, Expression.Constant(false));
            var lambda = Expression.Lambda(condition, parm);
            return lambda;
        }
    }
}
