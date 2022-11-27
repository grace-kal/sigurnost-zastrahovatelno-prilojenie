using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnost_Models
{
    public class InsuranceContract
    {
        //public InsuranceContract(IEnumerable<HomeInsuranceInfo> homeInsuranceInfos, IEnumerable<CarInsuranceInfo> carInsuranceInfos)
        //{
        //    HomeInsuranceInfos = homeInsuranceInfos;
        //    CarInsuranceInfos = carInsuranceInfos;
        //}

        [Key]
        public int InsuranceContractId { get; set; }

        [Required]
        public float OverallPriceOfPolicy { get; set; }

        [Required]
        public int NumberOfDeposits { get; set; }

        [Required]
        public DateTime DateOfBeggining { get; set; }

        [ForeignKey("User"), Required]
        public string ClientId { get; set; }
        public virtual User Client { get; set; }

        [ForeignKey("User"), Required]
        public string AgentId { get; set; }
        public virtual User Agent { get; set; }

        [ForeignKey("InsuranceLevel"), Required]
        public int InsuranceLevelId { get; set; }
        public virtual InsuranceLevel InsuranceLevel { get; set; }

        public virtual IEnumerable<CarInsuranceInfo> CarInsuranceInfos { get; set; }
        public virtual IEnumerable<HomeInsuranceInfo> HomeInsuranceInfos { get; set; }
    }
}
