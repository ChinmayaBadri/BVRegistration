using AutoMapper;
using Chinmaya.DAL;
using Chinmaya.Registration.Models;
using Chinmaya.Registration.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinmaya.Registration.DAL
{
    [DbConfigurationType(typeof(CodeConfig))] // point to the class that inherit from DbConfiguration
    public class Master
    {
        /// <summary>
        /// gets key value model list by the master type
        /// </summary>
        /// <param name="masterValue"> master type </param>
        /// <returns> key value model </returns>
        public IEnumerable<KeyGuidValueModel> GetMasterData(Utility.MasterType masterValue)
        {
            using (var _ctx = new ChinmayaEntities())
            {                
                switch (masterValue)
                {
                    case Utility.MasterType.ROLE:
                        return Mapper.Map<List<Role>, List<KeyGuidValueModel>>(_ctx.Roles.ToList());
					case Utility.MasterType.GENDER:
						return Mapper.Map<List<Gender>, List<KeyGuidValueModel>>(_ctx.Genders.ToList());
					case Utility.MasterType.COUNTRY:
						return Mapper.Map<List<Country>, List<KeyGuidValueModel>>(_ctx.Countries.ToList());
					case Utility.MasterType.STATE:
						return Mapper.Map<List<State>, List<KeyGuidValueModel>>(_ctx.States.ToList());
					case Utility.MasterType.CITY:
						return Mapper.Map<List<City>, List<KeyGuidValueModel>>(_ctx.Cities.ToList());
					case Utility.MasterType.SECURITYQUESTIONS:
						return Mapper.Map<List<SecurityQuestion>, List<KeyGuidValueModel>>(_ctx.SecurityQuestions.ToList());
					case Utility.MasterType.AGEGROUPID:
						return Mapper.Map<List<AgeGroup>, List<KeyGuidValueModel>>(_ctx.AgeGroups.ToList());
					case Utility.MasterType.RELATIONSHIP:
						return Mapper.Map<List<Relationship>, List<KeyGuidValueModel>>(_ctx.Relationships.ToList());
					case Utility.MasterType.GRADE:
						return Mapper.Map<List<Grade>, List<KeyGuidValueModel>>(_ctx.Grades.ToList());
					case Utility.MasterType.WEEKDAY:
						return Mapper.Map<List<Weekday>, List<KeyGuidValueModel>>(_ctx.Weekdays.ToList());
					case Utility.MasterType.FREQUENCY:
						return Mapper.Map<List<Frequency>, List<KeyGuidValueModel>>(_ctx.Frequencies.ToList());
					case Utility.MasterType.ACCOUNTTYPE:
						return Mapper.Map<List<AccountType>, List<KeyGuidValueModel>>(_ctx.AccountTypes.ToList());
					case Utility.MasterType.SESSION:
						return Mapper.Map<List<Session>, List<KeyGuidValueModel>>(_ctx.Sessions.ToList());
					default:
                        return new List<KeyGuidValueModel>();
                }            
            }
        }
    }
}
