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
            _unitBuilder
                .SetUnitName(name)
                .SetUnitHeight(height)
                .SetUnitStature(stature);
            
            // foreach (var cloth in clothes)
            // {
            //     _unitBuilder.SetUnitClothes(cloth);
            // }

            _unitBuilder
                .SetUnitSpecialization(specialization)
                .SetAction(action);

            return _unitBuilder.GetTotalUnit();
        }
    }
}