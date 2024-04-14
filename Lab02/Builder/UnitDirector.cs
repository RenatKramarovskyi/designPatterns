namespace Builder
{
    public class UnitDirector
    {
        private IUnitBuilder _unitBuilder;

        public UnitDirector(IUnitBuilder builder)
        {
            _unitBuilder = builder;
        }

        public IUnit ConstructUnit(string name, int height, string stature, string specialization, string action)
        {
           return  _unitBuilder
                .SetUnitName(name)
                .SetUnitHeight(height)
                .SetUnitStature(stature)
                .SetUnitSpecialization(specialization)
                .SetAction(action)
                .GetTotalUnit();
        }
    }
}