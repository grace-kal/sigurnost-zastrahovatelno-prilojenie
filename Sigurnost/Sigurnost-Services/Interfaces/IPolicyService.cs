using Sigurnost_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnost_Services.Interfaces
{
    public interface IPolicyService
    {
        //TO DO
        //MAKE GENERIC
        Task CreateInsuranceContract(InsuranceContract model);
        Task EditInsuranceContract(InsuranceContract model);
        Task DeleteInsuranceContract(int id);
        Task<InsuranceContract> GetInsuranceContractById(int id);
        Task<List<InsuranceContract>> GetInsuranceContractsByOwnerId(Guid id);
        Task<List<InsuranceContract>> GetInsuranceContractsByAgentId(Guid id);

        Task CreateCarInsuranceInfo(CarInsuranceInfo model);
        Task EditCarInsuranceInfo(CarInsuranceInfo model);
        Task DeleteCarInsuranceInfo(int id);
        Task<CarInsuranceInfo> GetCarInsuranceInfoById(int id);

        Task CreateHomeInsuranceInfo(HomeInsuranceInfo model);
        Task EditHomeInsuranceInfo(HomeInsuranceInfo model);
        Task DeleteeHomeInsuranceInfo(int id);
        Task<HomeInsuranceInfo> GetHomeInsuranceInfoById(int id);


    }
}
