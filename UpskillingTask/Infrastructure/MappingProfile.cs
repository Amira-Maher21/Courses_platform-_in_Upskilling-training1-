using AutoMapper;

namespace UpskillingTask.Infrastructure
{
	public class MappingProfile : Profile
	{
		//AddInclude Columes + Dto + Class
		
		public MappingProfile()
		{
			//CreateMap<Employee, WebUserDto>()
			//		   .ForMember(P => P.Id, m => m.MapFrom(A => A.EmployeeId))
			//		   .ForMember(P => P.Name, m => m.MapFrom(A => $"{A.Name} {A.FatherName} {A.GrandFatherName} {A.FamilyName}"))
			//		   .ForMember(P => P.GenderID, O => O.MapFrom(E => E.GenderId))
			//		
			//		   .ForMember(a => a.MeasurementEmployeeName, a => a.MapFrom(s => $"{s.MeasurementEmployee.Name} {s.MeasurementEmployee.FatherName} {s.MeasurementEmployee.GrandFatherName}
			//		   {s.MeasurementEmployee.FamilyName}"))

			//		  .ForMember(P => P.isSociety, O => O.Ignore())
			//		   .ReverseMap
		}
	}
}
