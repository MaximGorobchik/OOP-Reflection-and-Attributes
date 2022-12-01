namespace _03BarracksFactory.Core.Factories
{
    using System;
    using System.Reflection;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            //TODO: implement for Problem 3
            string unitsNamespace = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Select(t => t.Namespace)
            .Distinct()
            .Where(n => n != null)
            .FirstOrDefault(n => n.Contains("Units"));

            Type typeOfUnit = Type.GetType($"{unitsNamespace}.{unitType}");
            IUnit instanceOfUnit = (IUnit)Activator.CreateInstance(typeOfUnit);

            return instanceOfUnit;
            throw new NotImplementedException();
        }
    }
}
