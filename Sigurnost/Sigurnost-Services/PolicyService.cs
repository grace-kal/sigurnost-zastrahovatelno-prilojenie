using Sigurnost_DataAccess.Repositories.Interfaces;
using Sigurnost_Models;
using Sigurnost_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnost_Services
{
    public class PolicyService : IPolicyService
    {
        //TO DO
        //MAKE GENERIC
        private readonly IPolicyRepository _policyRepository;
        public PolicyService(IPolicyRepository policyRepository)
        {
            _policyRepository = policyRepository;
        }
        public async Task CreateCarInsuranceInfo(CarInsuranceInfo model)
        {
            throw new NotImplementedException();
        }

        public async Task CreateHomeInsuranceInfo(HomeInsuranceInfo model)
        {
            throw new NotImplementedException();
        }

        public async Task CreateInsuranceContract(InsuranceContract model)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteCarInsuranceInfo(int id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteeHomeInsuranceInfo(int id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteInsuranceContract(int id)
        {
            throw new NotImplementedException();
        }

        public async Task EditCarInsuranceInfo(CarInsuranceInfo model)
        {
            throw new NotImplementedException();
        }

        public async Task EditHomeInsuranceInfo(HomeInsuranceInfo model)
        {
            throw new NotImplementedException();
        }

        public async Task EditInsuranceContract(InsuranceContract model)
        {
            throw new NotImplementedException();
        }

        public async Task<CarInsuranceInfo> GetCarInsuranceInfoById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<HomeInsuranceInfo> GetHomeInsuranceInfoById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<InsuranceContract> GetInsuranceContractById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<InsuranceContract>> GetInsuranceContractsByAgentId(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<InsuranceContract>> GetInsuranceContractsByOwnerId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
