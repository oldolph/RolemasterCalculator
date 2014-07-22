using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RolemasterCalculator.Models.BaseTypes;
using RolemasterCalculator.DAL.AccessRepository.CriticalRepository;
using RolemasterCalculator.Models.Critical;

namespace RolemasterCalculator.BLL.Critical
{
    public class CriticalController : IBaseType
    {
        private ICriticalRepository _criticalRepository;

        public CriticalController() : this(new CriticalRepository()) { }

        public CriticalController(ICriticalRepository criticalRepository)
        {
            _criticalRepository = criticalRepository;
        }

        public IList<TypeDetail> GetTypes()
        {
            return _criticalRepository.GetTypes();
        }

        public TypeDetail GetType(int id)
        {
            return _criticalRepository.GetTypes().SingleOrDefault(x => x.ID == id);
        }

        public string GetCritical(int roll, int critType, string severity)
        {
            return _criticalRepository.GetCritical(roll, critType, severity);
        }
    }
}
