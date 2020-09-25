﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Paycompute.Entity
{
    public class PaymentRecord
    {
        public int Id { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        [MaxLength(100)]
        public Employee Em{ get; set;}
        public string FullName { get; set; }
        public string NiNo { get; set; }
        public DateTime Paydate { get; set; }
        public string PayMonth { get; set; }
        [ForeignKey("TaxYear")]
        public int TaxYearId { get; set; }
        public TaxYear TaxYear { get; set; }
        public string TaxCode { get; set; }
        [Column(TypeName = "money")]
        public decimal HourlyRate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal HoursWorked { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ContractualHours { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal OvertimeHours { get; set; }
        [Column(TypeName = "money")]
        public decimal ContractualEarnings { get; set; }
        [Column(TypeName = "money")]
        public decimal OvertimeEarnings { get; set; }
        [Column(TypeName = "money")]
        public decimal Tax { get; set; }
        [Column(TypeName = "money")]
        public decimal NIC { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnionFee { get; set; }
        [Column(TypeName = "money")]
        public Nullable<decimal> SLC { get; set; }
        [Column(TypeName = "money")]
        public decimal TotalEarning { get; set; }
        [Column(TypeName = "money")]
        public decimal TotalDeduction { get; set; }
        [Column(TypeName = "money")]
        public decimal NetpPayment { get; set; }

    }
}
