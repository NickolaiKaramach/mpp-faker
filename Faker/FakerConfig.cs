using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Faker.Generators.Interface;

namespace Faker
{
    public class FakerConfig
    {
        private readonly List<Type> _excludedTypes = new List<Type>();
        private readonly Dictionary<MemberInfo, IGenerator> _generators;

        public FakerConfig()
        {
            _generators = new Dictionary<MemberInfo, IGenerator>();
        }

        internal IGenerator GetGeneratorByName(string parameterName)
        {
            foreach (var member in _generators.Keys.Where(member =>
                member.Name.Equals(parameterName, StringComparison.OrdinalIgnoreCase)))
            {
                _generators.TryGetValue(member, out var generator);
                return generator;
            }

            return null;
        }

        internal IGenerator GetGeneratorByMemberInfo(MemberInfo memberInfo)
        {
            _generators.TryGetValue(memberInfo, out var generator);
            return generator;
        }

        internal void ExcludeType(Type type)
        {
            _excludedTypes.Add(type);
        }

        internal void RemoveFromExcludedTypes(Type type)
        {
            _excludedTypes.Remove(type);
        }

        internal bool Excluded(Type type)
        {
            return _excludedTypes.Contains(type);
        }

        public void Add<TClass, TMember, TGenerator>(Expression<Func<TClass, TMember>> expressionTree)
            where TGenerator : IGenerator
        {
            var generator = (IGenerator) Activator.CreateInstance<TGenerator>();

            var body = (MemberExpression) expressionTree.Body;
            var memberInfo = body.Member;
            _generators.Add(memberInfo, generator);
        }
    }
}